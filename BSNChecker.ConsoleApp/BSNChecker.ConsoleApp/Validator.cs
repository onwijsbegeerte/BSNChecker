using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;

namespace BSNChecker.ConsoleApp
{
    public class Validator
    {
        public bool ValidateBsnNumber(string input)
        {
            if (input.Length != 8 && input.Length != 9)
            {
                return false;
            }

            Regex regex = new Regex(@"[0-9]");

            return regex.IsMatch(input);
        }
    }
}
