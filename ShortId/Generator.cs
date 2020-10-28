using System;
using System.Security.Cryptography;
using System.Text;

namespace Damurka.ShortId
{
    public static class Generator
    {
        private const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Numbers = "1234567890";
        private const string Specials = "-_";

        private const int MinChars = 8;

        private static readonly RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        /// <summary>
        /// Generates a random string of a specified length with the option to add numbers and special characters.
        /// </summary>
        /// <param name="size">The size of the generated string.</param>
        /// <param name="useNumbers">Whether or not numbers are included in the string.</param>
        /// <param name="useSpecial">Whether or not special characters are included.</param>
        /// <returns></returns>
        public static string Generate(int size = MinChars, bool useNumbers = true, bool useSpecial = false)
        {
            if (size < MinChars)
                throw new ArgumentException($"The specified length is lower than accepted limit of {MinChars}");

            var chars = GetCharacters(useNumbers, useSpecial);
            var data = new byte[size];
            rngCsp.GetNonZeroBytes(data);
            var result = new StringBuilder(size);
            foreach (var d in data)
                result.Append(chars[d % (chars.Length - 1)]);
            return result.ToString();
        }

        /// <summary>
        /// Get the characters to be used
        /// </summary>
        /// <param name="useNumber">Whether or not numbers are included in the string.</param>
        /// <param name="useSpecial">Whether or not special characters are included.</param>
        /// <returns></returns>
        private static char[] GetCharacters(bool useNumber, bool useSpecial)
        {
            var sb = Letters;

            if (useNumber)
                sb += Numbers;

            if (useSpecial)
                sb += Specials;

            return sb.ToCharArray();
        }
    }
}
