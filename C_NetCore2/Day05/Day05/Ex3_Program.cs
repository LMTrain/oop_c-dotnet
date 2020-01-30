using System;
using static System.Console;
using static System.Convert;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Getting information using 'typeof' operator for class ");
            var typeInfo = typeof(Program);
            typeInfo.GetConstructor(new[] { typeof(Program) });
            WriteLine();
            WriteLine("Analysis result(s):");
            WriteLine("=========================");
            WriteLine($"Assembly:{typeInfo.AssemblyQualifiedName}");
            WriteLine($"Name:{typeInfo.Name}");
            WriteLine($"Full Name:{typeInfo.FullName}");
            WriteLine($"Namespace:{typeInfo.Namespace}");
            WriteLine("=========================");
            ReadLine();
        }
    }
}
