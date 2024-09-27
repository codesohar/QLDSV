using System.Text.RegularExpressions;

namespace QLDIEM.Controller
{
    internal class Invalidate
    {
        public static bool IsNullOrEmpty(string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool isStringUTF8(string s)
        {
            return Regex.IsMatch(s, @"[\u0080-\uFFFF]");
        }

        public static bool IsPhoneNumber(string number)
        {
            Regex regex = new Regex(@"^\d{10}$|^\(\d{3,5}\)\d{3,4}\-\d{3,4}$");
            return regex.IsMatch(number);
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
