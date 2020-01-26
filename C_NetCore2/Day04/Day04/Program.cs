using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Convert;
using System.Linq;

namespace Day04
{
    class Program
    {
        public class PersonCollection
        {
            private readonly string[] _persons = Persons();

            public bool this[string name] => IsValidPerson(name);

            private bool IsValidPerson(string name) => _persons.Any(person => person == name);

            private static string[] Persons() => new[] { "Shivprasad", "Denim", "Vikas", "Merint", "Gaurav" };
        }
        static void Main(string[] args)
        {
            WriteLine("Indexer example.");
            Write("Enter person name to search from collection:");
            var name = ReadLine();
            var person = new PersonCollection();
            var result = person[name] ? "exists." : "does not exist.";
            WriteLine($"Person name '{name}' {result}");
        }
    }
}
