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
            WriteLine("Jagged array.\n");
            string[][,] collaborators = new string[3][,]
            {
                new[,] {{"Name", "Shivprasad Koirala"}, {"Age", "40"}},
                new[,] {{"Name", "Gaurav Aroraa" }, {"Age", "43"}},
                new[,] {{"Name", "Vikas Tiwari"}, {"Age", "28"}}
            };

            for (int index = 0; index < collaborators.Length; index++)
            {
                for (int rowIndex = 0; rowIndex < 2; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < 2; colIndex++)
                    {
                        WriteLine($"collaborators[{index}][{rowIndex},{colIndex}] = {collaborators[index][rowIndex, colIndex]}");
                    }
                }
            }
        }
       
    }
}
