using System;
using System.Collections.Generic;
using static System.Console;


namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Statement example:");
            int singleLineStatement; //declarative statement
            WriteLine("'int singleLineStatement;' is a declarative statment.");
            singleLineStatement = 125; //assignment statement
            WriteLine("'singleLineStatement = 125;' is an assignmnet statement.");
            WriteLine($"{nameof(singleLineStatement)} = {singleLineStatement}");
            var persons = new List<Person>
            {
                new Author
                {
                    Name = "Gaurav Aroraa"
                }
            }; //declarative and assignmnet statement
            WriteLine("'var persons = new List<Person>();' is a declarative and assignmnet statement.");
            //block statement
            foreach (var person in persons)
            {
                WriteLine("'foreach (var person in persons){}' is a block statement.");
                WriteLine($"Name:{person.Name}");
                ReadLine();
            }
        }
        public abstract class Person
        {
            public abstract string Name { get; set; }
        }
        public class Author : Person
        {
            public override string Name { get; set; }
        }
    }
}
