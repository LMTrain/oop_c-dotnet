using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace Day03
{
    public static void InferTupleNames(int num1, int num2)
    {
        (int, int) noNamed = (num1, num2);
        Console.WriteLine($"NoNamed:{noNamed.Item1},{noNamed.Item2}");
        (int, int) ignoredName = (A: num1, B: num2);
        Console.WriteLine($"IgnoredName:{ignoredName.Item1},{ignoredName.Item2}");
        (int a, int b) typeNamed = (num1, num2);
        Console.WriteLine($"typeNamed using default member-names:{typeNamed.Item1},{typeNamed.Item2}");
        Console.WriteLine($"typeNamed:{typeNamed.a},{typeNamed.b}");
        var named = (num1, num2);
        Console.WriteLine($"named using default member-names:{named.Item1},{named.Item2}");
        Console.WriteLine($"named:{named.num1},{named.num2}");
        var noNamedVariation = (num1, num1);
        Console.WriteLine($"noNamedVariation:{noNamedVariation.Item1},{noNamedVariation.Item2}");
        var explicitNaming = (n: num1, num1);
        Console.WriteLine($"explicitNaming:{explicitNaming.n},{explicitNaming.num1}");
        var partialnamed = (num1, 5);
        Console.WriteLine($"partialnamed:{partialnamed.num1},{partialnamed.Item2}");

    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C# 7.1 feature: Infer tuple names");
            Write("Enter first number:");
            var number1 = ReadLine();
            Write("Enter second number:");
            var number2 = ReadLine();
            InferTupleNames(Convert.ToInt32(number1), Convert.ToInt32(number2));
            ReadLine();
        }

        private static void InferTupleNames(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
