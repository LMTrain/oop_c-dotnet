using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C# 7.1 feature: default expression");
            int thisIsANewDefault = default;
            int thisIsAnOlderDefault = default;
            var thisIsAnOlderDefaultAndValid = default(int);
            //var thisIsNotValid = default; //Not valid, as we cannot assign default to implicit-typed variable
            const int thisIsANewDefaultConst = default; //valid
            const int thisIsAnOlderDefaultCont = default; //valid
                                                          //const int? thisIsInvalid = default; //Invalid, as nullable cannot be declared const

            WriteLine($"New default:{thisIsANewDefault}. Old default:{thisIsAnOlderDefault}");
        }
    }
}
