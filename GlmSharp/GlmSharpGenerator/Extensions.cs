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
        
        public static IEnumerable<string> AsComment(this string s)
        {
            yield return "/// <summary>";
            yield return "/// " + s;
            yield return "/// </summary>";
        }
    }
}
