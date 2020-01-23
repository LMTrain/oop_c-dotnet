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
            WriteLine("Two-Dimentional array. \n");

            int[,] numbers = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            for (int rowsIndex = 0; rowsIndex < 2; rowsIndex++)
            {
                for (int colIndex = 0; colIndex < 2; colIndex++)
                {
                    WriteLine($"numbers[{rowsIndex},{colIndex}] = {numbers[rowsIndex, colIndex]}");
                }
            }
            ReadLine();
        }
       
    }
}
