using System;
using System.Collections.Generic;
using System.Text;

namespace Day03
{
    class OddEven
    {
        public static bool CompareToTuple(int number)
        {
            var oddEvenValueTuple = FindOddEvenBySingleNumber(number);
            var differentTupleValue = FindOddEvenBySingleNumberNamedElement(number + 1);
            var res = oddEvenValueTuple.CompareTo(differentTupleValue);
            return res == 0; // 0 if other is a ValueTuple instance and 1 if other is null
        }

        public static bool CompareToTuple1(int number)
        {
            var oddEvenValueTuple = FindOddEvenBySingleNumber(number);
            var sameTupleValue = FindOddEvenBySingleNumberNamedElement(number);
            var res = oddEvenValueTuple.CompareTo(sameTupleValue);
            return res == 0; // 0 if other is a ValueTuple instance and 1 if other is null
        }

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
        private static bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }
    }
}
