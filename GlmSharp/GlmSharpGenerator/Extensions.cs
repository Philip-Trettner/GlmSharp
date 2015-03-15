using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
    }
}
