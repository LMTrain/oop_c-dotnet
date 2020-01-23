using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("for loop example");
            Write("Enter repeatitive length:");
            int length = Convert.ToInt32(ReadLine());
            for (int countIndex = 0; countIndex < length; countIndex++)
            {               
                WriteLine(new string('*', countIndex));
            }           
            ReadLine();
        }
       
    }
}
