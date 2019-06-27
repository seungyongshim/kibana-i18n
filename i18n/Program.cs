

using System;
using System.IO;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("i18n.Tests")]

namespace i18n
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine($"TargetFile [ReferenceFile]");
                return;
            }

            string sourceFile = args.Length > 1 ? args[0] : null;
            string targetFile = args.Length > 1 ? args[0] : null;
            string refereFile = args.Length > 2 ? args[1] : null;

            Console.WriteLine($"{sourceFile} {targetFile} {refereFile}");

            var source = File.ReadAllText(sourceFile);

            var reference = refereFile??File.ReadAllText(refereFile);

            var target = i13nConverter.RemoveNoKibanaAndUpdate(source, reference);

            File.WriteAllText(targetFile, target);

        }
    }
}
