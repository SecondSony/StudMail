using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient.Helpers
{
    public enum RSAKeySize
    {
        Key512 = 512,
        Key1024 = 1024,
        Key2048 = 2048,
        Key4096 = 4096
    }

    public class RSAKeyPair
    {
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
    }
}
