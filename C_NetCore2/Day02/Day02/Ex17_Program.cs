using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;


namespace Day02
{
    class Program
    {
        public abstract class Person
        {
            public abstract string Name { get; set; }
        }

        public class Author : Person
        {
            public override string Name { get; set; }
        }

        public class Reviewer : Person
        {
            public override string Name { get; set; }
        }

        public class TeamMember : Person
        {
            public override string Name { get; set; }
            public void GetMemberName()
            {
                Console.WriteLine($"Member name:{Name}");
            }
        }
        static void Main(string[] args)
        {
            WriteLine("foreach loop example");
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            WriteLine("foreach on Array.");
            foreach (var vowel in vowels)
            {
                WriteLine($"{vowel}");
            }
            WriteLine();
            var persons = new List<Person>
            {
                new Author {Name = "Gaurav Aroraa"},
                new Reviewer {Name = "Shivprasad Koirala"},
                new TeamMember {Name = "Vikas Tiwari"},
                new TeamMember {Name = "Denim Pinto"}
            };
            WriteLine("foreach on collection");
            foreach (var person in persons)
            {
                WriteLine($"{person.Name}");
            }
        }
       
    }
}
