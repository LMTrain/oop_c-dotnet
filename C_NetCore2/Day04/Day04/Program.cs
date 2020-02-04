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
       
        static void Main(string[] args)
        {
            const string textLine = "This file is created during practice of C#";
            Write("Enter file name (without extension):");
            var fileName = ReadLine();
            var fileNameWithPath = $"C:/udemy/{fileName}.txt";
            using (var fileStream = File.Create(fileNameWithPath))
            {
                   var iBytes = new UTF8Encoding(true).GetBytes(textLine);
                fileStream.Write(iBytes, 0, iBytes.Length);
            }
            //DISPLAYED COMMENT FILE IS CREATED
            WriteLine("Write operation is completed.");
            ReadLine();
            using (var fileStream = File.OpenRead(fileNameWithPath))
            {
                var bytes = new byte[1024];
                var encoding = new UTF8Encoding(true);
                while (fileStream.Read(bytes, 0, bytes.Length) > 0)
                    WriteLine(encoding.GetString(bytes));
                ReadLine();
            }
        }
    }
}
