using System.Security.Cryptography;
using System.Text;

namespace Application.Utils
{
    public static class StringUtils
    {
        public static string Hash(this string input)
        {
            //hash the string
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                input = Convert.ToBase64String(hash);
            }
            return input;
        }

    }
}
