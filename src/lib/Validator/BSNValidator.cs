using System.Text.RegularExpressions;

namespace BSNChecker.ConsoleApp
{
    public interface IBSNValidator
    {
        bool Validate(string input);
    }
    public class BSNValidator : IBSNValidator
    {
        private readonly IElfChecker _elfChecker;

        public BSNValidator(IElfChecker elfChecker)
        {
            _elfChecker = elfChecker;
        }

        public bool Validate(string input)
        {
            var regex = new Regex(@"^[0-9]{9}$");
            var result = false;

            if (regex.IsMatch(input))
            {
                result = _elfChecker.Check(input);
            }

            return result;
        }
    }


}
