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
            WriteLine("do...while example");
            Write("Enter repeatitive length:");
            int length = Convert.ToInt32(ReadLine());
            int count = 0;
            do
            {
                count++;
                WriteLine(new string('*', count));


            }
            while (count < length);
            ReadLine();
        }
       
    }
}
