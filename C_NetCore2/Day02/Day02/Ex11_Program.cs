using System;
using static System.Console;


namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            int thisIsvalueTypeVariable = 786;
            object thisIsObjectTypeVariable = thisIsvalueTypeVariable; //Boxing
            thisIsvalueTypeVariable += 1;
            WriteLine("Boxing");
            WriteLine($"Before boxing: Value of {nameof(thisIsvalueTypeVariable)}: {thisIsvalueTypeVariable}");
            WriteLine($"After boxing: Value of {nameof(thisIsObjectTypeVariable)}: {thisIsObjectTypeVariable}");

            thisIsObjectTypeVariable = 1900;
            thisIsvalueTypeVariable = (int)thisIsObjectTypeVariable; //Unboxing
            WriteLine("Unboxing");
            WriteLine($"Before Unboxing: Value of {nameof(thisIsObjectTypeVariable)}: {thisIsObjectTypeVariable}");
            WriteLine($"After Unboxing: Value of {nameof(thisIsvalueTypeVariable)}: {thisIsvalueTypeVariable}");

        }
    }
}
