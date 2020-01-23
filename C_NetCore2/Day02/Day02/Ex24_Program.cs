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
            WriteLine("String object creation");
            string authorName = "Gaurav Aroraa"; //string literal assignment
            WriteLine($"{authorName}");
            string property = "Name: ";
            string person = "Gaurav";
            string personName = property + person; //string concatenation
            WriteLine($"{personName}");

            char[] langauge = { 'c', 's', 'h', 'a', 'r', 'p' };
            string strLanguage = new string(langauge); //initializing the cosntructor
            WriteLine($"{strLanguage}");
            string repeatMe = new string('*', 5);
            WriteLine($"{repeatMe}");
            string[] members = { "Shivprasad", "Denim", "Vikas", "Gaurav" };
            string name = string.Join(" ", members); //method returing string
            WriteLine($"{name}");
            ReadLine();
        }
       
    }
}
