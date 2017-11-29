using System;
using System.Text.RegularExpressions;

namespace BSNChecker.ConsoleApp
{
    public class ElfChecker
    {
        public bool Check(string input)
        {
            if (input.Equals("9"))
            {
                return false;
            }
            return true;
        }

        public int Multiply(string input)
        {
            var array = input.ToCharArray();
            var result = 0;

            for (var i = 0; i  < array.Length ; i++)
            {
                var currentNumber = (int) Char.GetNumericValue(array[i]);
                result += currentNumber * (i + 1);
            }

            return result;
        }
    }
}
