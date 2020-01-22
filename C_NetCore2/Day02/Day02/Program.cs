using System;
using static System.Console;
using static System.Convert;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Is As Operator");
            var author = new Author { Name = "Gaurav Aroraa" };
            var reviewer = new Reviewer { Name = "Shivprasad Koirala" };
            var team = new TeamMember { Name = "Vikas Tiwari" };
            var stackholder = new Stackholder();
            WriteLine("Author name using as:\n");
            stackholder.GetAuthorName(author);
            WriteLine("\nAuthor name using is:");
            stackholder.GetStackholdersname(author);
            WriteLine("Review name using is:");
            stackholder.GetStackholdersname(reviewer);
            WriteLine("Team member name using is:");
            stackholder.GetStackholdersname(team);
            ReadLine();
        }
    }
}
