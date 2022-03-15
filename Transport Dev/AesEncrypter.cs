using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Transport_Dev
{
    public static class AesEncrypter
    {

        private const string tokenFile = @"key.token";

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

        public static string EncryptToAesAndOutput(string text, byte[] Key, byte[] IV)
        {
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException(nameof(text));
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException(nameof(Key));
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException(nameof(IV));
            byte[] encrypted;
            string encryptedText;

            using (Aes aes = Aes.Create())
            {
                aes.IV = IV;
                aes.Key = Key;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using MemoryStream ms = new MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (StreamWriter ws = new StreamWriter(cs))
                {
                    ws.Write(text);
                }
                encrypted = ms.ToArray();
            }

            encryptedText = Convert.ToBase64String(encrypted);

            return encryptedText;
        }
    }
}