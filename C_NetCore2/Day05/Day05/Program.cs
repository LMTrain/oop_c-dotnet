using System;
using static System.Console;
using static System.Convert;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Getting information using 'GetType()' method for class 'Day05.Program'");
            var info = Type.GetType("Day05.Program");
            WriteLine();
            WriteLine("Analysis result(s):");
            WriteLine("=========================");
            WriteLine($"Assembly:{info.AssemblyQualifiedName}");
            WriteLine($"Name:{info.Name}");
            WriteLine($"Full Name:{info.FullName}");
            WriteLine($"Namespace:{info.Namespace}");
            WriteLine("=========================");
            ReadLine();
        }
    }
}
