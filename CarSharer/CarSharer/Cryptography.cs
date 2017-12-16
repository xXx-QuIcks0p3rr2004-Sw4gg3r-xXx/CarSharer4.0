using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CarSharer
{
    public class Cryptography
    {
        /// <summary>
        /// Method that hashes a string with sha256.
        /// </summary>
        /// <param name="value">String to hash.</param>
        /// <returns>Returns a hashed string.</returns>
        public static String sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
