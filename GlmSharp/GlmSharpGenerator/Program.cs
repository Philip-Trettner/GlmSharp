using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator
{
    class Program
    {
        public static readonly Dictionary<string, TypeBase> Types = new Dictionary<string, TypeBase>();

        static IEnumerable<string> SupportedTypes
        {
            get
            {
                yield return "int";
                yield return "uint";
                yield return "float";
                yield return "bool";
                yield return "double";
                yield return "long";
                yield return "T";
            }
        }

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: path/to/gen-folder/");
                return;
            }
            var path = args[0];

            Console.WriteLine("GlmSharp Generator");
            foreach (var type in SupportedTypes)
                for (var comp = 2; comp <= 4; ++comp)
                {
                    var name = type.StartsWith("f") ? "vec" : type[0] + "vec";
                    if (type == "T")
                        name = "gvec";
                    var vect = new VectorType
                    {
                        Name = name,
                        Components = comp,
                        BaseType = type,
                        IsGeneric = type == "T"
                    };
                    var swizzler = vect.SwizzleType;
                    Types.Add(vect.ClassName, vect);
                    Types.Add(swizzler.ClassName, swizzler);
                }

            Console.WriteLine();
            Console.WriteLine("Types:");
            foreach (var type in Types.Keys)
                Console.WriteLine("    " + type);

            Console.WriteLine();
            Console.WriteLine("Generate:");
            foreach (var type in Types.Values)
            {
                var filename = Path.Combine(path, type.ClassName + ".cs");
                File.WriteAllLines(filename, type.CSharpFile);
                Console.WriteLine("    " + filename);
            }
        }
    }
}
