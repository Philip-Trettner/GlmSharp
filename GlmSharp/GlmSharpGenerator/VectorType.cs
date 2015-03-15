using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace GlmSharpGenerator
{
    class VectorType : TypeBase
    {
        public int Components { get; set; } = 3;
        public override string ClassName => Name + Components;

        public string CompString => "xyzw".Substring(0, Components);

        public override IEnumerable<string> BaseClasses
        {
            get
            {
                yield return string.Format("IReadOnlyList<{0}>", BaseType);
            }
        }

        public string CompParameterString => CompString.Select(c => BaseType + " " + c).CommaSeparated();
        public IEnumerable<string> CompParameters => CompString.Select(c => BaseType + " " + c);

        public string CompArgString => CompString.CommaSeparated();
        public IEnumerable<string> CompArgs => CompString.Select(c => c.ToString());

        public string DefaultValue => "default(" + BaseType + ")";

        public IEnumerable<string> SubCompParameters(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => BaseType + " " + c);
        public string SubCompParameterString(int start, int end) => SubCompParameters(start, end).CommaSeparated();
        public IEnumerable<string> SubCompArgs(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => c.ToString());
        public string SubCompArgString(int start, int end) => SubCompArgs(start, end).CommaSeparated();

        public SwizzleType SwizzleType => new SwizzleType { BaseType = BaseType, BaseName = Name, Components = Components, Name = "swizzle_" + Name, IsGeneric = IsGeneric };

        private IEnumerable<string> Constructor(string comment, string args, IEnumerable<string> assignments)
        {
            foreach (var line in comment.AsComment())
                yield return line;
            yield return string.Format("public {0}({1})", ClassName, args);
            yield return "{";
            var it = assignments.GetEnumerator();
            foreach (var c in CompString)
                yield return string.Format("this.{0} = {1};", c, it.MoveNext() ? it.Current : DefaultValue).Indent();
            yield return "}";
        }

        protected override IEnumerable<string> Body
        {
            get
            {
                // components
                for (var i = 0; i < Components; ++i)
                {
                    foreach (var line in string.Format("{0}-component", "xyzw"[i]).AsComment()) yield return line;
                    yield return string.Format("public {0} {1};", BaseType, "xyzw"[i]);
                }

                // swizzle
                foreach (var line in "Returns an object that can be used for swizzling (e.g. swizzle.zy)".AsComment()) yield return line;
                yield return string.Format("public swizzle_{0} swizzle => new swizzle_{0}({1});", ClassNameThat, CompArgString);

                // values
                foreach (var line in "Returns an array with all values".AsComment()) yield return line;
                yield return string.Format("public {0}[] Values => new[] {{ {1} }};", BaseType, CompArgString);

                // ctors
                foreach (var line in Constructor("Component-wise constructor", CompParameterString, CompArgs)) yield return line;
                foreach (var line in Constructor("all-same-value constructor", BaseType + " v", "v".RepeatTimes(Components))) yield return line;

                for (var comps = 2; comps <= 4; ++comps)
                {
                    foreach (var line in Constructor("from-vector constructor (empty fields are zero/false)",
                        Name + comps + GenericSuffic + " v",
                        "v".DotComp(comps)))
                        yield return line;

                    for (var ucomps = comps; ucomps < Components; ++ucomps)
                        foreach (var line in Constructor("from-vector-and-value constructor (empty fields are zero/false)",
                            Name + comps + GenericSuffic + " v, " + SubCompParameterString(comps, ucomps),
                            "v".DotComp(comps).Concat(SubCompArgs(comps, ucomps))))
                            yield return line;
                }

                // IEnumerable
                foreach (var line in "Returns an enumerator that iterates through all components.".AsComment()) yield return line;
                yield return string.Format("public IEnumerator<{0}> GetEnumerator()", BaseType);
                yield return "{";
                foreach (var c in CompString)
                    yield return string.Format("yield return {0};", c).Indent();
                yield return "}";

                foreach (var line in "Returns an enumerator that iterates through all components.".AsComment()) yield return line;
                yield return "IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();";

                // IReadOnlyList
                foreach (var line in string.Format("Returns the number of components ({0}).", Components).AsComment()) yield return line;
                yield return string.Format("public int Count => {0};", Components);

                foreach (var line in "Gets/Sets a specific indexed component (a bit slower than direct access).".AsComment()) yield return line;
                yield return string.Format("public {0} this[int index]", BaseType);
                yield return "{";
                yield return "    get";
                yield return "    {";
                yield return "        switch (index)";
                yield return "        {";
                for (var c = 0; c < Components; ++c)
                    yield return string.Format("            case {0}: return {1};", c, "xyzw"[c]);
                yield return "            default: throw new ArgumentOutOfRangeException(\"index\");";
                yield return "        }";
                yield return "    }";
                yield return "    set";
                yield return "    {";
                yield return "        switch (index)";
                yield return "        {";
                for (var c = 0; c < Components; ++c)
                    yield return string.Format("            case {0}: this.{1} = value; break;", c, "xyzw"[c]);
                yield return "            default: throw new ArgumentOutOfRangeException(\"index\");";
                yield return "        }";
                yield return "    }";
                yield return "}";
            }
        }
    }
}
