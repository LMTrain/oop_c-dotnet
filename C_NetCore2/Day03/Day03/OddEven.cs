using System;
using System.Collections.Generic;
using System.Text;

namespace Day03
{
    class OddEven
    {
        
        public static (int, string) FindOddEvenBySingleNumber(int number)
        {
            var oddOrEven = IsOddNumber(number) ? "Odd" : "Even";

            return (number, oddOrEven); //tuple literal
        }

        public static (int number, string oddOrEven) FindOddEvenBySingleNumberNamedElement(int number)
        {
            var result = IsOddNumber(number) ? "Odd" : "Even";

            return (number: number, oddOrEven: result); //returning named tuple element in tuple literal
        }
        private static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        private static bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }
    }
}
