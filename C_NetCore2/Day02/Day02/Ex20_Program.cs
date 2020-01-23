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
            //var charArray = new[] { 'a', 'e', 'i', 'o', 'u' };
            //string[] cardinalDirections = { "North", "East", "South", "West" };
            //char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            //WriteLine("One-Dimensional array.\n");
            WriteLine("Array example.\n");
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            WriteLine("char[] vowels = {'a', 'e', 'i', 'o', 'u'};\n");
            WriteLine("acces array using for loop");
            for (int rankIndex = 0; rankIndex < vowels.Length; rankIndex++)
            {
                Write($"{vowels[rankIndex]} ");
            }
            WriteLine();
            WriteLine("acces array using foreach loop");
            foreach (char vowel in vowels)
            {
                Write($"{vowel} ");
            }
            ReadLine();
        }
       
    }
}
