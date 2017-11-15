using System.Text.RegularExpressions;

namespace BSNChecker.ConsoleApp
{
    public class Validator
    {
        public bool ValidateBsnNumber(string input)
        {
            Regex regex = new Regex(@"^[0-9]{9}$");

            return regex.IsMatch(input);
        }
    }
}
