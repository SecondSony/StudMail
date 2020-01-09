using System.Security.Cryptography;
using System.Text;

namespace MailClient.Crypto
{
    public class UserSHA1
    {
        public static string ComputeHashSHA1(string rawData)
        {
            using (var sha = new SHA1Managed())
            {
                var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                var builder = new StringBuilder();

                foreach (var data in hash) builder.Append(data.ToString("x2"));

                return builder.ToString();
            }
        }
    }
}
