using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Transport_Dev
{
    /// <summary>
    /// STARY SYSTEM
    /// </summary>
    /*public static class AesEncrypterOldStream
    {

        private const string tokenFile = @"key.token";

        /// <summary>
        /// Funkcja do wygenerowania tokenu IV oraz Key
        /// </summary>
        public static void GenerateKey()
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;

                byte[] key = aes.Key;
                byte[] IV = aes.IV;

                string resultkey = Convert.ToBase64String(key);
                string resultiv = Convert.ToBase64String(IV);

                using (StreamWriter sw = new StreamWriter(tokenFile))
                {
                    sw.WriteLine(resultkey);
                    sw.WriteLine(resultiv);
                }
            }
        }

        /// <summary>
        /// Funkcja szyfrująca hasło
        /// </summary>
        /// <param name="text">Hasło w formie plain textu</param>
        /// <returns>Zaszyfrowane hasło</returns>
        /// <exception cref="ArgumentNullException">Gdy nie ma podanego hasła</exception>
        /// <exception cref="ArgumentException">Gdy nie ma pliku z tokenem</exception>
        public static string EncryptToAesAndOutput(string text)
        {
            byte[] Key;
            byte[] IV;
            byte[] encrypted;
            string encryptedText;

            if (text == null || text.Length <= 0)
                throw new ArgumentNullException(nameof(text));
            if (!File.Exists(tokenFile))
                throw new ArgumentException(nameof(tokenFile));

            using (StreamReader sr = new StreamReader(tokenFile))
            {
                string? tokenKey = sr.ReadLine();
                string? tokenIV = sr.ReadLine();

                #pragma warning disable CS8604 //Wartość nigdy nie będzie nullem
                Key = Convert.FromBase64String(tokenKey);
                IV = Convert.FromBase64String(tokenIV);
                #pragma warning restore CS8604
            }

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using MemoryStream ms = new MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (StreamWriter sw = new StreamWriter(cs))
                {
                    sw.Write(text);
                }
                encrypted = ms.ToArray();
            }

            encryptedText = Convert.ToBase64String(encrypted);

            return encryptedText;
        }
    }*/
}