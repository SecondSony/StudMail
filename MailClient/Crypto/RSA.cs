using MailClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MailClient.Crypto
{
    public class RSA
    {
        private bool isOptimalAsymmEncryptionPadding = false;

        public RSAKeyPair GenKeys(RSAKeySize keySize)
        {
            var keyPair = new RSAKeyPair();

            using (var provider = new RSACryptoServiceProvider((int) keySize))
            {
                var publicKey = provider.ToXmlString(false);
                var privateKey = provider.ToXmlString(true);
                var publicKeyWithSize = IncludeKeyInEncryptionString(publicKey);
                var privateKeyWithSize = IncludeKeyInEncryptionString(privateKey);
                keyPair.PublicKey = publicKeyWithSize;
                keyPair.PrivateKey = privateKeyWithSize;
            }
            return keyPair;
        }

        public byte[] Encrypt(byte[] data, string PublicKey)
        {
            string publicKeyXml = GetKeyFromEncryptionString(PublicKey);
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, isOptimalAsymmEncryptionPadding);
            }
        }

        public string Encrypt(string plainText, string publicKey)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(plainText), publicKey));
        }

        public string Decrypt(string encryptedText, string privateKey)
        {
            var decrypted = Decrypt(Convert.FromBase64String(encryptedText), privateKey);
            return Encoding.UTF8.GetString(decrypted);
        }

        public byte[] Decrypt(byte[] data, string PrivateKey)
        {
            string publicAndPrivateKeyXml = GetKeyFromEncryptionString(PrivateKey);
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, isOptimalAsymmEncryptionPadding);
            }
        }

        private string IncludeKeyInEncryptionString(string publicKey)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(publicKey));
        }

        private string GetKeyFromEncryptionString(string rawkey)
        {
            var xmlKey = "";

            if (string.IsNullOrEmpty(rawkey))
            {
                byte[] keyBytes = Convert.FromBase64String(rawkey);
                xmlKey = Encoding.UTF8.GetString(keyBytes);
            }

            return xmlKey;
        }
    }
}
