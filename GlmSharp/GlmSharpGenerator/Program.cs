using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator
{
    class Program
    {

        private static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: path/to/gen-folder/net45/ path/to/gen-folder/net20/");
                return;
            }

            Console.WriteLine("GlmSharp Generator");
            foreach (var version in new[] { 45, 20 })
            {
                string path;
                switch (version)
                {
                    case 45:
                        path = args[0];
                        break;
                    case 20:
                        path = args[1];
                        break;
                    default:
                        throw new InvalidOperationException();
                }

                AbstractType.Version = version;
                AbstractType.InitTypes();

                // see: https://www.opengl.org/sdk/docs/man4/html/ for functions

                Console.WriteLine();
                Console.WriteLine("Types:");
                foreach (var type in AbstractType.Types.Keys)
                    Console.WriteLine("    " + type);

                Console.WriteLine();
                Console.WriteLine("Generate:");
                foreach (var type in AbstractType.Types.Values)
                {
                    if (!string.IsNullOrEmpty(type.Folder))
                        Directory.CreateDirectory(Path.Combine(path, type.Folder));
                    var filename = type.PathOf(path);
                    var lines = type.CSharpFile.ToArray();
                    var currLines = File.Exists(filename) ? File.ReadAllLines(filename) : new string[] { };
                    if (!lines.SequenceEqual(currLines))
                    {
                        File.WriteAllLines(filename, lines);
                        Console.WriteLine("    CHANGED " + filename);
                    }
                }
            }
        }
    }
}
