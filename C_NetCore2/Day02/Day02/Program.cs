using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;


namespace Day02
{
    class Program
    {
        public struct BookAuthor
        {
            public string Name;
            public string BookTitle;
            public int Age;
            public string City;
            public string State;
            public string Country;

            public BookAuthor(string name, string bookTitle, int age, string city, string state, string country)
            {
                Name = name;
                BookTitle = bookTitle;
                Age = age;
                City = city;
                State = state;
                Country = country;
            }

            public override string ToString()
            {
                return $"Author {Name} is of {Age} yrs old from {City},{State},{Country} has written book: '{BookTitle}'";
            }
        }

        static void Main(string[] args)
        {
            WriteLine("Structure example\n");
            Write("Author name:");
            var name = ReadLine();
            Write("Book Title:");
            var bookTitle = ReadLine();
            Write("Author age:");
            var age = ReadLine();
            Write("Author city:");
            var city = ReadLine();
            Write("Author state:");
            var state = ReadLine();
            Write("Author country:");
            var country = ReadLine();

            BookAuthor author = new BookAuthor(name, bookTitle, Convert.ToInt32(age), city, state, country);
            WriteLine($"{author.ToString()}");
            BookAuthor author1 = author; //copy structur, it will copy only data as this is not a class

            Write("Change author name:");
            var name1 = ReadLine();
            author.Name = name1;

            WriteLine("Author1");
            WriteLine($"{author.ToString()}");
            WriteLine("Author2");
            WriteLine($"{author1.ToString()}");
        }
       
    }
}
