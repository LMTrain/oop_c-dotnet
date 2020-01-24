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
            Write("Enter number: ");
            var num = ReadLine();
            var resultNum = OddEven.FindOddEvenBySingleNumberNamedElement(Convert.ToInt32(num));
            WriteLine($"Number:{resultNum.number} is {resultNum.oddOrEven}.");
            WriteLine();
            var comp = OddEven.CompareToTuple(Convert.ToInt32(num));
            WriteLine($"Comparison of two Tuple objects having different value is:{comp}");
            var comp1 = OddEven.CompareToTuple1(Convert.ToInt32(num));
            WriteLine($"Comparison of two Tuple objects having same value is:{comp1}");
        }
    }
}
