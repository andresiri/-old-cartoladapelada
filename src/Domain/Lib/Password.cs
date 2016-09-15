using System;
using System.Security.Cryptography;
using System.Text;

namespace Domain.Lib
{
    public class Password
    {
        public static string hash(string password, string salt)
        {
            var bytes = new UTF8Encoding().GetBytes(password + salt);
            byte[] hashBytes;

            using (var algorithm = SHA512.Create())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
