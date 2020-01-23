using System;
using static System.Console;


namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Operators example\n");
            var csharpOperator = new CSharpOperators();
            Write("Enter first number:");
            csharpOperator.Num1 = Convert.ToInt32(ReadLine());
            Write("Enter second number:");
            csharpOperator.Num2 = Convert.ToInt32(ReadLine());
            Clear();
            csharpOperator.Display();
            ReadLine();
        }
    }
}
