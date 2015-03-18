using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator
{
    static class Extensions
    {
        public static string Indent(this string s, int lvl = 1)
        {
            return new string(' ', lvl * 4) + s;
        }

        public static IEnumerable<string> Indent(this IEnumerable<string> ss, int lvl = 1)
        {
            return ss.Select(s => s.Indent(lvl));
        }

        public static IEnumerable<string> TypedArgs(this IEnumerable<string> ss, AbstractType type)
        {
            return ss.Select(s => type.Name + " " + s);
        }

        public static IEnumerable<string> Format(this IEnumerable<string> ss, string format)
        {
            return ss.Select(s => string.Format(format, s));
        }

        public static string CommaSeparated<T>(this IEnumerable<T> coll)
        {
            var cc = coll.Select(c => c.ToString()).ToArray();
            return cc.Length == 0 ? "" : cc.Aggregate((s1, s2) => s1 + ", " + s2);
        }

        public static string Aggregated<T>(this IEnumerable<T> coll, string seperator)
        {
            var cc = coll.Select(c => c.ToString()).ToArray();
            return cc.Length == 0 ? "" : cc.Aggregate((s1, s2) => s1 + seperator + s2);
        }

        public static IEnumerable<string> LhsRhs(this AbstractType type)
        {
            yield return type.NameThat + " lhs";
            yield return type.NameThat + " rhs";
        }
        public static IEnumerable<string> TypedArgs(this AbstractType type, params string[] args)
        {
            return args.Select(a => type.NameThat + " " + a);
        }
        public static IEnumerable<string> SConcat(this IEnumerable<string> coll, params string[] args)
        {
            return coll.Concat(args);
        }

        public static IEnumerable<string> AsComment(this string s, bool withTrailingEmptyLine = true)
        {
            if (withTrailingEmptyLine)
                yield return "";
            yield return "/// <summary>";
            yield return "/// " + s;
            yield return "/// </summary>";
        }

        public static IEnumerable<string> RepeatTimes(this string s, int times)
        {
            for (var i = 0; i < times; ++i)
                yield return s;
        }

        public static IEnumerable<string> DotComp(this string s, int maxComp = 4)
        {
            for (var i = 0; i < maxComp; ++i)
                yield return s + "." + "xyzw"[i];
        }

        public static IEnumerable<string> ImpulseString(this int arg, string imp, string nonimp, int maxComp = 4)
        {
            for (var i = 0; i < maxComp; ++i)
                yield return i == arg ? imp : nonimp;
        }

        public static IEnumerable<T> ExactlyN<T>(this IEnumerable<T> coll, int n, T obj)
        {
            var it = coll.GetEnumerator();
            for (var i = 0; i < n; ++i)
                yield return it.MoveNext() ? it.Current : obj;
        }

        public static IEnumerable<int> IndexUpTo(this int n)
        {
            for (var i = 0; i < n; ++i)
                yield return i;
        }

        public static IEnumerable<T> ForIndexUpTo<T>(this int n, Func<int, T> f)
        {
            for (var i = 0; i < n; ++i)
                yield return f(i);
        }
    }
}
