using System.Text.RegularExpressions;

namespace PasswordValidate.Services
{
    public class PasswordValidateService
    {
        private const string Pattern = @"^(?!.*(.).*\1)(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";

        public static bool Validate(string content)
        {
            Regex rx = new Regex(Pattern);
            MatchCollection matches = rx.Matches(content);
            return matches.Count > 0 ? true : false;
        }
    }
}
