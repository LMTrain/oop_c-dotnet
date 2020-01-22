using System;
using static System.Console;


namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var disposableClass = new DisposableClass())
            {
                WriteLine($"{disposableClass.GetMessage()}");
                ReadLine();
            }

        }
    }
}
