using System.Linq;
using static System.Char;

namespace BSNChecker.ConsoleApp
{
    public interface IValidator
    {
        bool Validate(string input);
    }
    public class Validator : IValidator
    {
        public bool Validate(string input)
        {
            return false;
        }
    }
}
