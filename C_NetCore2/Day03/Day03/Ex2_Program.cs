using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter first number: ");
            var userInputFirst = ReadLine();
            Write("Enter second number: ");
            var userInputSecond = ReadLine();
            var noNamed = OddEven.FindOddEvenBySingleNumber(Convert.ToInt32(userInputFirst));
            var named = OddEven.FindOddEvenBySingleNumberNamedElement(Convert.ToInt32(userInputSecond));
            WriteLine($"First Number:{noNamed.Item1} is {noNamed.Item2} using noNamed tuple.");
            WriteLine($"Second Number:{named.number} is {named.oddOrEven} using Named tuple.");

            WriteLine("Assigning 'Named' to 'NoNamed'");
            noNamed = named;
            WriteLine($"Number:{noNamed.Item1} is {named.Item2} after assignment.");
            Write("Enter third number: ");
            var userInputThird = ReadLine();
            var noNamed2 = OddEven.FindOddEvenBySingleNumber(Convert.ToInt32(userInputThird));
            WriteLine(
                $"Third Number:{noNamed2.Item1} is {noNamed2.Item2} using second noNamed tuple.");
            WriteLine("Assigning 'second NoNamed' to 'Named'");
            named = noNamed2;
            WriteLine($"Second Number:{named.number} is {named.oddOrEven} after assignment.");
            ReadLine();
        }
    }
}
