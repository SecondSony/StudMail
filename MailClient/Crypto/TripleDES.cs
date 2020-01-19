using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace MailClient.Crypto
{
    public class TripleDES
    {
        private const int blockSize = 128;
        private const int charSize = 16;
        private const int shiftKey = 2;
        private const int keyRound = 12;
        private string[] blocks;

        /// <summary>
        /// Генерирует ключ и вектор
        /// </summary>
        /// <returns></returns>
        public static List<byte[]> GenKey()
        {
            using (var tdes = System.Security.Cryptography.TripleDES.Create())
            {
                var list = new List<byte[]>();

                tdes.GenerateKey();
                tdes.GenerateIV();

                list.Add(tdes.Key);
                list.Add(tdes.IV);

                return list;
            }
        }

        public static byte[] Encrypt(string text, byte[] key, byte[] iv)
        {
            byte[] encrypted;

            using (var tdes = System.Security.Cryptography.TripleDES.Create())
            {
                tdes.Key = key;
                tdes.IV = iv;

                ICryptoTransform encryptor = tdes.CreateEncryptor(tdes.Key, tdes.IV);

                using (var mStream = new MemoryStream())
                {
                    using (var cStream = new CryptoStream(mStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (var writer = new StreamWriter(cStream))
                        {
                            writer.Write(text);
                        }
                    }

                    encrypted = mStream.ToArray();
                }
            }

            return encrypted;
        }

        public static string Decrypt(byte[] msgHash, byte[] key, byte[] iv)
        {
            string plaintext = "";

            using (var tdes = System.Security.Cryptography.TripleDES.Create())
            {
                tdes.Key = key;
                tdes.IV = iv;

                ICryptoTransform decryptor = tdes.CreateDecryptor(tdes.Key, tdes.IV);

                using (var mStream = new MemoryStream(msgHash))
                {
                    using (var cStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (var reader = new StreamReader(cStream))
                        {
                            plaintext = reader.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
