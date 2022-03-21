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
        /// Generowanie hasła AES
        /// </summary>
        /// <param name="text">Hasło</param>
        /// <returns>Zaszyfrowane hasło</returns>
        /// <exception cref="ArgumentNullException">Kiedy nie ma hasła</exception>
        /// <exception cref="ArgumentException">Kiedy jest brak pliku token.dat</exception>
        public static string EncryptToAesAndOutput(string text)
        {
            byte[] Key;
            byte[] IV;
            byte[] encrypted;
            string encryptedText;

            if (text == null || text.Length <= 0)
                throw new ArgumentNullException(nameof(text));
            if (!File.Exists(tokenDat))
                throw new ArgumentException(nameof(tokenDat));

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
    }
}