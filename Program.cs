using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDeveloper mike = new WebDeveloper("Angular6");
            mike.Code();
            mike.Code("C#");
            mike.Code("C#", "HTML");
            mike.Code(null, "HTML");
        }
    }
}
