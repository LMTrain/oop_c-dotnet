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
            WriteLine("break statement example");
            WriteLine("break in for loop");
            for (int count = 0; count < 50; count++)
            {
                if (count == 48)
                {
                    break;
                }
                WriteLine($"{count}");
            }
            WriteLine();
            WriteLine("break in switch statement");
            ReadLine();
        }
       
    }
}
