using System;
using static System.Console;
using static System.Convert;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxValue = int.MaxValue;
            var addSugar = 19;
            //int sumWillthrowError = 2147483647 + 19; //compile time error
            var sumWillNotThrowError = maxValue + addSugar;
            //var sumWillNotThrowError = checked(maxValue + addSugar); //compile time error
            WriteLine($"sum value:{sumWillNotThrowError} is not the correct value because it is larger than {maxValue}.");
        }
    }
}
