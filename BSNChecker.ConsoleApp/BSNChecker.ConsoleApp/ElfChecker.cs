using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BSNChecker.ConsoleApp
{
    public class ElfChecker
    {
        public bool Check(string input)
        {
            if (int.Parse(input) < 11 || Multiply(input) / 11 != 0)
            {
                return false;
            }
            return true;
        }

        public int Multiply(string input)
        {
            var array = input.Reverse().ToArray();
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
