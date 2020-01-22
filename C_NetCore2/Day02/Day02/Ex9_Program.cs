using System;
using static System.Console;


namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamicInt = 10;
            dynamic dynamicString = "This is a string";
            object obj = 10;
            WriteLine($"Run-time type of {nameof(dynamicInt)} is {dynamicInt.GetType()}");
            WriteLine($"Run-time type of {nameof(dynamicString)} is {dynamicString.GetType()}");
            WriteLine($"Run-time type of {nameof(obj)} is {obj.GetType()}");
            ReadLine();

        }
    }
}
