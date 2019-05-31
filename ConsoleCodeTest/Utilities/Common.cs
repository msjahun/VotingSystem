using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleCodeTest.Utilities
{
    public static class Common
    {

        public static int H(string textToHash)
        {
            string hashedName = ComputeSha256Hash(textToHash);
            string FirstEightChars = GetFirstEightCharacters(hashedName);


            int hexToInt = ConvertHextoInt(FirstEightChars);
            return hexToInt;
        }
       public static int ConvertHextoInt(string hex)
        {


            int intValue = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return intValue;
        }
        public static string GetFirstEightCharacters(string Hashedhex)
        {

            // Get first 12 characters substring from a string    
            string firstEightChars = Hashedhex.Substring(0, 6);
            return firstEightChars;
        }
       public static string ComputeSha256Hash(string rawData)
        {//ComputeSha256Hash
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }



        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }
    }
}

