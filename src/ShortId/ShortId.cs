using System;
using System.Security.Cryptography;
using System.Text;

namespace Damurka.Generator
{
    public static class ShortId
    {
        private const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        private static readonly RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        /// <summary>
        /// Generates a random string of a specified length with the option to add numbers and special characters.
        /// </summary>
        /// <param name="size">The size of the generated string.</param>
        /// <param name="allowableCharacters">Characters to be used</param>
        /// <returns>The unique ID</returns>
        public static string Generate(int length = 8, string allowableCharacters = Characters)
        {
            if (string.IsNullOrWhiteSpace(allowableCharacters) || allowableCharacters.Contains(" "))
                throw new InvalidOperationException("Allowable characters cannot be null or contain spaces");
            if (allowableCharacters.Length <= 0 || allowableCharacters.Length >= 256)
                throw new ArgumentOutOfRangeException("Allowable character must contains 1 to 255 characters", nameof(allowableCharacters));
            if (length <= 0)
                throw new ArgumentOutOfRangeException("Length must be greater than zero.", nameof(length));

            var data = new byte[length];
            rngCsp.GetNonZeroBytes(data);

            var chars = allowableCharacters.ToCharArray();
            var result = new StringBuilder(length);
            foreach (var d in data)
                result.Append(chars[d % chars.Length]);
            return result.ToString();
        }
    }
}
