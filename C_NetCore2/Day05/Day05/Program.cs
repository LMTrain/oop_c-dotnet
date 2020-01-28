using System;
using static System.Console;
using static System.Convert;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter number: ");
            var num = ReadLine();
            var objInstance = Activator.CreateInstance(typeof(OddEven));
            var method = typeof(OddEven).GetMethod("PrintSingleOddEven");
            var res = method.Invoke(objInstance, new object[] { ToInt32(num) });
            WriteLine($"Number:{num} is {res}");
            ReadLine();
        }
    }
}
