using System;
using static System.Console;
using static System.Convert;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            var thisIsADouble = 30.3D;
            WriteLine("using typeof()");
            WriteLine($"System.Type Object of {nameof(Program)} is {typeof(Program)}\n");
            var objProgram = new Program();
            WriteLine("using GetType()");
            WriteLine($"Sytem.Type Object of {nameof(objProgram)} is {objProgram.GetType()}");
            WriteLine($"Sytem.Type Object of {nameof(thisIsADouble)} is {thisIsADouble.GetType()}");
        }
    }
}
