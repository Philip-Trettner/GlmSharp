using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: path/to/gen-folder/");
                return;
            }
            var path = args[0];

            Console.WriteLine("GlmSharp Generator");
            AbstractType.InitTypes();

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
                File.WriteAllLines(filename, type.CSharpFile);
                Console.WriteLine("    " + filename);
            }
        }
    }
}
