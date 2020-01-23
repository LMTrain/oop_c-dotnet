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
            WriteLine("if else statement example.");
            Write("Enter character:");
            char inputChar = Convert.ToChar(ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(char.ToLower(inputChar)))
                WriteLine($"Character '{inputChar}' is a vowel.");
            else
                WriteLine($"Character '{inputChar}' is a consonent.");
            ReadLine();
        }
       
    }
}
