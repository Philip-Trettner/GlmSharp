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

        public abstract string StructComment { get; }

        public virtual IEnumerable<string> BaseClasses { get { yield break; } }

        public IEnumerable<string> CSharpFile
        {
            get
            {
                var baseclasses = BaseClasses.ToArray();
                yield return "using System;";
                yield return "using System.Collections;";
                yield return "using System.Collections.Generic;";
                yield return "using System.Globalization;";
                yield return "using System.Numerics;";
                yield return "using System.Linq;";
                yield return "";
                yield return "// ReSharper disable InconsistentNaming";
                yield return "";
                yield return "namespace GlmSharp";
                yield return "{";
                foreach (var line in StructComment.AsComment()) yield return line.Indent();
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


        public string SqrOf(string s) => BaseTypeInfo.IsComplex ? s + ".LengthSqr()" : s + "*" + s;
        public string SqrOf(char s) => SqrOf(s.ToString());

        public string SqrtOf(string s) => BaseTypeInfo.Decimal ? s + ".Sqrt()" : string.Format("Math.Sqrt({0})", s);
        public string SqrtOf(char s) => SqrOf(s.ToString());


        public string AbsString(string s) => BaseTypeInfo.IsSigned ? (BaseTypeInfo.IsComplex ? s + ".Magnitude" : string.Format("Math.Abs({0})", s)) : s;
        public string AbsString(char s) => BaseTypeInfo.IsSigned ? (BaseTypeInfo.IsComplex ? s + ".Magnitude" : string.Format("Math.Abs({0})", s)) : s.ToString();

        public string ConstantSuffixFor(string s)
        {
            if (BaseTypeInfo == BaseTypeInfo.TypeFloat)
                return s + "f";

            if (BaseTypeInfo == BaseTypeInfo.TypeDouble)
                return s + "d";

            if (BaseTypeInfo == BaseTypeInfo.TypeDecimal)
                return s + "m";

            throw new InvalidOperationException("unknown type");
        }
    }
}
