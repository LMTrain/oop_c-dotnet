using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

namespace Day04
{
    internal class StringCalculator
    {
        public int Add(string numbers)
        {
            var result = 0;
            try
            {
                return IsNullOrEmpty(numbers) ? result : AddStringNumbers(numbers);
            }
            catch (NumberIsExcededException excededException)
            {
                Console.WriteLine($"Exception occurred:'{excededException.Message}'");
            }

            return result;
        }

        private bool IsNullOrEmpty(string numbers) => string.IsNullOrEmpty(numbers);

        private int AddStringNumbers(string numbers) => GetSplittedStrings(numbers).Sum(StringToInt32);

        private IEnumerable<string> GetSplittedStrings(string numbers) => numbers.Split(',');

        private int StringToInt32(string n)
        {
            var number = Convert.ToInt32(string.IsNullOrEmpty(n) ? "0" : n);
            if (number > 1000)
                throw new NumberIsExcededException($"Number:{number} excedes the limit of 1000.");
            return number;
        }
    }
    internal class NumberIsExcededException : Exception
    {
        public NumberIsExcededException(string message) : base(message)
        {
        }

        public NumberIsExcededException(string message, Exception innerException) : base(message, innerException)
        {

        }
        protected NumberIsExcededException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }

}
