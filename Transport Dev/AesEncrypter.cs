using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Transport_Dev
{
    public static class AesEncrypter
    {
        private const string tokenDat = @"token.dat";

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

                using (FileStream stream = File.Open(tokenDat, FileMode.Create))
                using (BinaryWriter bw = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    bw.Write(key.Length);
                    bw.Write(key, 0, key.Length);
                    bw.Write(IV.Length);
                    bw.Write(IV, 0, IV.Length);
                }
            }
        }

        /// <summary>
        /// Hashowanie hasła w formacie AES
        /// </summary>
        /// <param name="text">Hasło</param>
        /// <returns>Zaszyfrowane hasło</returns>
        /// <exception cref="ArgumentNullException">Kiedy nie ma hasła</exception>
        /// <exception cref="FileNotFoundException">Kiedy jest brak pliku token.dat</exception>
        public static string EncryptToAesAndOutput(string text)
        {
            byte[] Key;
            byte[] IV;
            byte[] encrypted;
            string encryptedText;

            if (text == null || text.Length <= 0)
                throw new ArgumentNullException(nameof(text));
            if (!File.Exists(tokenDat))
                throw new FileNotFoundException(nameof(tokenDat));

            using (FileStream stream = File.Open(tokenDat, FileMode.Open))
            using (BinaryReader br = new BinaryReader(stream, Encoding.UTF8, false))
            {
                Key = br.ReadBytes(br.ReadInt32());
                IV = br.ReadBytes(br.ReadInt32());
            }

            using (Aes aes = Aes.Create())
            {
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);

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

        /// <summary>
        /// Dehashowania hasła w formacie AES
        /// </summary>
        /// <param name="encryptedText">Zaszyfrowane hasło</param>
        /// <returns>Hasło w formie plain textu</returns>
        /// <exception cref="ArgumentNullException">Kiedy nie ma hasła</exception>
        /// <exception cref="FileNotFoundException">Kiedy jest brak pliku token.dat</exception>
        public static string DecryptFromAesAndOutput(string encryptedText)
        {
            byte[] Key;
            byte[] IV;
            string decryptedText;

            if (encryptedText == null || encryptedText.Length <= 0)
                throw new ArgumentNullException(nameof(encryptedText));
            if (!File.Exists(tokenDat))
                throw new FileNotFoundException(nameof(tokenDat));

            using (FileStream stream = File.Open(tokenDat, FileMode.Open))
            using (BinaryReader br = new BinaryReader(stream, Encoding.UTF8, false))
            {
                Key = br.ReadBytes(br.ReadInt32());
                IV = br.ReadBytes(br.ReadInt32());
            }

            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            using (Aes aes = Aes.Create())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);

                using MemoryStream ms = new MemoryStream(encryptedBytes);
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    decryptedText = sr.ReadToEnd();
                }
            }

            return decryptedText;
        }
    }
}