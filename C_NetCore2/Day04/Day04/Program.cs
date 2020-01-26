using System;
using static System.Console;

namespace Day04
{
    class Program
    {
        internal class StringCalculator
        {
            protected string Num1 { get; set; }
            protected string Num2 { get; set; }           
        }
        public class StringCalculatorImplementation : StringCalculator
        {
            public void Sum()
            {
                StringCalculatorImplementation calculator = new StringCalculatorImplementation();
                Write("Enter number1:");
                calculator.Num1 = ReadLine();
                Write("Enter numbeer2:");
                calculator.Num2 = ReadLine();
                int sum = Convert.ToInt32(calculator.Num1) + Convert.ToInt32(calculator.Num2);
                Write($"Sum of {calculator.Num1} and {calculator.Num2} is { sum}");            
            }
        }
        static void Main(string[] args)
        {
            StringCalculatorImplementation cal = new StringCalculatorImplementation();
            cal.Sum();
        }
    }
}
