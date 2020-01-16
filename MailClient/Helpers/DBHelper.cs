using MailClient.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient.Helpers
{
    public enum DBStatus
    {
        Connected,
        Disconnected
    }

    public class ServerInfo
    {
        public long Id { get; set; }
        public string Domain { get; set; }
        public string SmtpHost { get; set; }
        public long SmtpPort { get; set; }
        public string ImapHost { get; set; }
        public long ImapPort { get; set; }
        public string Pop3Host { get; set; }
        public long Pop3Port { get; set; }
        public bool IsSsl { get; set; }
    }

    public class UserInfo
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long ServerId { get; set; }
        public ServerInfo Server { get; set; }
        public List<FolderInfo> Folders { get; set; }
        public List<RSABookInfo> RSABooks { get; set; }
    }

    public class FolderInfo
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public List<LetterInfo> Letters { get; set; }
        public int Start { get; set; } = 0;
        public int Count { get; set; } = 20;
    }

    public class LetterInfo
    {
        public long Id { get; set; }
        public long FolderId { get; set; }
        public long Uid { get; set; }
        public string MsgBase64 { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public bool IsChecked { get; set; } = false;
    }

    public class RSABookInfo
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string OwnPrivate { get; set; }
        public string OwnPublic { get; set; }
        public string OwnPrivateECP { get; set; }
        public string OwnPublicECP { get; set; }
        public string EmailPublic { get; set; }
        public string EmailPublicECP { get; set; }
    }
}

