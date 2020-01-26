using System;
using static System.Console;

namespace Day04
{
    class Program
    {
       static void Main(string[] args)
        {
            var calculator = new StringCalculator();
            Write("Enter numbers comma separated:");
            var num = ReadLine();

            Write($"Sum of {num} is {calculator.Add(num)}");
            ReadLine();
        }
    }
}
