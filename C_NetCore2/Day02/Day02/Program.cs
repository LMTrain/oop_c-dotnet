using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;


namespace Day02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            WriteLine("continue statement example");
            WriteLine("continue in for loop");
            for (int count = 0; count < 15; count++)
            {
                if (count < 8)
                {
                    continue;
                }
                WriteLine($"{count}");
            }
            ReadLine();
        }
       
    }
}
