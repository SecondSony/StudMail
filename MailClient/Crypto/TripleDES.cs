using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient.Crypto
{
    public class TripleDES
    {
        private const int blockSize = 128;
        private const int charSize = 16;
        private const int shiftKey = 2;
        private const int keyRound = 12;
        private string[] blocks;

        public string Encrypt(string text, ref string key)
        {
            return "";
        }

        public string Decrypt(string text, ref string key)
        {
            return "";
        }


    }
}
