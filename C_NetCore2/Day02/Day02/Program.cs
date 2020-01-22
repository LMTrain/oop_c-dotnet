using System;
using static System.Console;
using static System.Convert;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Various inbuilt types have size as mentioned below:\n");
            WriteLine($"The size of data type int is: {sizeof(int)}");
            WriteLine($"The size of data type long is: {sizeof(long)}");
            WriteLine($"The size of data type double is: {sizeof(double)}");
            WriteLine($"The size of data type bool is: {sizeof(bool)}");
            WriteLine($"The size of data type short is: {sizeof(short)}");
            WriteLine($"The size of data type byte is: {sizeof(byte)}");
        }
    }
}
