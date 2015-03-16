using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator
{
    abstract class TypeBase
    {
        public string Name { get; set; } = "vec";
        public string BaseType { get; set; } = "float";
        public abstract string ClassName { get; }
        public string ClassNameThat => ClassName + GenericSuffix;
        public string GenericSuffix => IsGeneric ? "<T>" : "";
        public BaseTypeInfo BaseTypeInfo { get; set; }

        public bool IsGeneric => BaseTypeInfo.Generic;

        public virtual IEnumerable<string> BaseClasses { get { yield break; } }

        public IEnumerable<string> CSharpFile
        {
            get
            {
                var baseclasses = BaseClasses.ToArray();
                yield return "using System;";
                yield return "using System.Collections;";
                yield return "using System.Collections.Generic;";
                yield return "using System.Numerics;";
                yield return "using System.Linq;";
                yield return "";
                yield return "namespace GlmSharp";
                yield return "{";
                yield return "    [Serializable]";
                yield return "    public struct " + ClassName + GenericSuffix + (baseclasses.Length == 0 ? "" : " : " + baseclasses.CommaSeparated());
                yield return "    {";
                foreach (var line in Body)
                    yield return line.Indent(2);
                yield return "    }";
                yield return "}";
            }
        }

        protected abstract IEnumerable<string> Body { get; }

        public string Comparer(string val) => IsGeneric ?
            string.Format("EqualityComparer<T>.Default.Equals({0}, rhs.{0})", val) :
            string.Format("{0}.Equals(rhs.{0})", val);

        public string ZeroValue => BaseTypeInfo.ZeroValue;
        public string OneValue => BaseTypeInfo.OneValue;

        public string HashCodeOf(string val) => IsGeneric ? string.Format("EqualityComparer<T>.Default.GetHashCode({0})", val) : string.Format("{0}.GetHashCode()", val);
    }
}
