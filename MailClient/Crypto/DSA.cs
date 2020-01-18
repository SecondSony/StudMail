using MailClient.Helpers;
using System;
using System.Security.Cryptography;
using System.Text;

namespace MailClient.Crypto
{
    public class DSA
    {
        public static DSAKeyPair GenKeyPair()
        {
            using (var provider = new DSACryptoServiceProvider())
            {
                var keyPair = new DSAKeyPair();
                keyPair.PrivateKey = provider.ExportCspBlob(true);
                keyPair.PublicKey = provider.ExportCspBlob(false);

                return keyPair;
            }
        }

        // TODO:
        public static string GenSign(string msg, string privateSignKey)
        {
            using (var provider = new DSACryptoServiceProvider())
            {
                provider.ImportCspBlob(Convert.FromBase64String(privateSignKey));
                var formatter = new DSASignatureFormatter(provider);
                formatter.SetHashAlgorithm("SHA1");
                var signature = formatter.CreateSignature(Encoding.UTF8.GetBytes(msg));
                return Convert.ToBase64String(signature);
            }
        }

        // TODO:
        public static string CreateSign(string msg, string privateSignKey)
        {
            using (var provider = new DSACryptoServiceProvider())
            {
                var alg = new HashAlgorithmName("SHA1");
                return Convert.ToBase64String(provider.SignData(Encoding.UTF8.GetBytes(msg), alg));
            }
        }

        public static bool VerifySign(string msg, string msgSign, string publicSignKey)
        {
            using (var provider = new DSACryptoServiceProvider())
            {
                var signature = Convert.FromBase64String(msgSign);
                provider.ImportCspBlob(Convert.FromBase64String(publicSignKey));
                var deformatter = new DSASignatureDeformatter(provider);
                deformatter.SetHashAlgorithm("SHA1");
                return deformatter.VerifySignature(UserSHA1.ComputeHashSHA1(msg), signature);
            }
        }
    }
}
