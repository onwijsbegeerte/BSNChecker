using System.Linq;
using static System.Char;

namespace BSNChecker.ConsoleApp
{
    public interface IElfChecker
    {
        bool Check(string input);
    }

    public class ElfChecker : IElfChecker
    {
        public bool Check(string input)
        {
            bool result = multiplyByPosition(input) % 11 == 0;
            return result;
        }

        private int multiplyByPosition(string input)
        {
            var array = input.Reverse().ToArray();
            var result = 0;

            for (var i = 0; i < array.Length; i++)
            {
                var currentNumber = (int)GetNumericValue(array[i]);
                result += currentNumber * (i + 1);
            }

            return result;
        }
    }
}
