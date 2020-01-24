using System;
using static System.Console;

namespace Day04
{
    class Program
    {
        internal class StringCalculator
        {
            public string Num1 { get; set; }
            public string Num2 { get; set; }
            public int Sum() => Convert.ToInt32(Num1) + Convert.ToInt32(Num2);
        }
        static void Main(string[] args)
        {
            Write("Enter number1:");
            var num1 = ReadLine();
            Write("Enter numbeer2:");
            var num2 = ReadLine();
            var sum = Convert.ToInt32(num1) +
            Convert.ToInt32(num2);
            Write($"Sum od {num1} and {num2} is {sum}");
            ReadLine();
        }
    }
}
