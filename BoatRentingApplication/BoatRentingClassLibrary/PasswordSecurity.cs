using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BoatRentingClassLibrary
{
    public static class PasswordSecurity
    {
        public static string GenerateHash(string input)
        {
            //choose algorith
            SHA256 algorithm = SHA256.Create();

            //convert string to bytes
            byte[] bytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            //build hash using string builder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
