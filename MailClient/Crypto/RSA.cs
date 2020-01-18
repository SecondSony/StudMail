using MailClient.Helpers;
using System;
using System.Security.Cryptography;
using System.Text;

namespace MailClient.Crypto
{
    public class RSA
    {
        private static bool isOptimalAsymmEncryptionPadding = false;

        public static RSAKeyPair GenKeys(RSAKeySize keySize)
        {
            try
            {
                using (var provider = new RSACryptoServiceProvider((int) keySize))
                {
                    RSAKeyPair keys = new RSAKeyPair();
                    var publicKey = provider.ToXmlString(false);
                    var privateKey = provider.ToXmlString(true);
                    var publicKeyWithSize = IncludeKeyInEncryptionString(publicKey);
                    var privateKeyWithSize = IncludeKeyInEncryptionString(privateKey);
                    keys.PublicKey = publicKeyWithSize;
                    keys.PrivateKey = privateKeyWithSize;

                    return keys;
                }
            }
            catch (CryptographicException)
            {
                return null;
            }
        }

        public static byte[] Encrypt(byte[] data, string publicKey)
        {
            string publicKeyXml = GetKeyFromEncryptionString(publicKey);
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, isOptimalAsymmEncryptionPadding);
            }
        }

        public static string Encrypt(string plainText, string publicKey)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(plainText), publicKey));
        }

        public static string Decrypt(string encryptedText, string privateKey)
        {
            var decrypted = Decrypt(Convert.FromBase64String(encryptedText), privateKey);
            return Encoding.UTF8.GetString(decrypted);
        }

        public static byte[] Decrypt(byte[] data, string PrivateKey)
        {
            string publicAndPrivateKeyXml = GetKeyFromEncryptionString(PrivateKey);
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, isOptimalAsymmEncryptionPadding);
            }
        }

        private static string IncludeKeyInEncryptionString(string publicKey)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(publicKey));
        }

        private static string GetKeyFromEncryptionString(string rawkey)
        {
            var xmlKey = "";

            if (!string.IsNullOrEmpty(rawkey))
            {
                byte[] keyBytes = Convert.FromBase64String(rawkey);
                xmlKey = Encoding.UTF8.GetString(keyBytes);
            }

            return xmlKey;
        }
    }
}
