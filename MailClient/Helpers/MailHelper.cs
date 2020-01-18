using MailClient.Crypto;
using MimeKit;
using System;
using System.Collections.Generic;

namespace MailClient.Helpers
{
    public class MailHelper
    {
        public uint UID;
        public string Body;
        public string Subject;
        public List<string> From;
        public List<string> To;
        public List<string> Attachments;
        public string EncryptedKey;
        public string IV;
        public string Signature;

        /// <summary>
        /// Генерирует строку зашифрованный текст&защифрованный ключ&вектор&ЭЦП
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static MimeMessage GenEncryptedMsg(MimeMessage msg, string body, List<string> attachments, RSABookInfo book)
        {
            // encryptedMsg – конечная зашифрованная строка
            var encryptedMsg = "";
            var mailMsg = msg;
            var tdesKeys = TripleDES.GenKey();
            var tdesTxt = Convert.ToBase64String(TripleDES.Encrypt(body, tdesKeys[0], tdesKeys[1]));
            var encryptedKey = Convert.ToBase64String(RSA.Encrypt(tdesKeys[0], book.OwnPublic));
            var iv = Convert.ToBase64String(tdesKeys[1]);
            var builder = new BodyBuilder();

            encryptedMsg += tdesTxt + "&" + encryptedKey + "&" + iv + "&";
            encryptedMsg += DSA.CreateSign(encryptedMsg, book.OwnPrivateECP);

            builder.TextBody = encryptedMsg;
            builder.HtmlBody = encryptedMsg;
            foreach (var item in attachments) builder.Attachments.Add(item);
            mailMsg.Body = builder.ToMessageBody();

            return mailMsg;
        }

        public static MimeMessage GenMsg(MimeMessage msg, string body, List<string> attachments)
        {
            var mailMsg = msg;
            var builder = new BodyBuilder();

            builder.TextBody = body;
            builder.HtmlBody = body;
            foreach (var item in attachments) builder.Attachments.Add(item);
            mailMsg.Body = builder.ToMessageBody();

            return mailMsg;
        }
    }
}
