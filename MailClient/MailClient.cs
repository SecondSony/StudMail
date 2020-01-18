using MailClient.DB;
using MailClient.Helpers;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;

namespace MailClient
{
    public class MailClient
    {
        public SpecialFolder CurrentFolder;
        public UserInfo CurrentUser;
        public MimeMessage CurrentReadMsg;
        public IList<IMailFolder> Folders;
        public static NetworkStatus CurrentNetwork;
        public static object ObjLock;
        private Thread threadCheckNetwork;

        public int UserId => (int) CurrentUser.Id;

        public List<FolderInfo> UserFolders
        {
            get => CurrentUser.Folders;
            set => CurrentUser.Folders = value;
        }

        public MailClient(UserInfo user)
        {
            var domain = AuthHelper.GetDomain(user.Email);
            CurrentFolder = SpecialFolder.All;
            CurrentUser = user;
            CurrentUser.Server = DBServers.GetServerInfo(DBConnection.Connection, domain);
            CurrentUser.RSABooks = DBRSABooks.GetBooks(DBConnection.Connection, (int) user.Id);

            ObjLock = new object();
            CurrentNetwork = NetworkStatus.Disconnected;
            threadCheckNetwork = new Thread(checkNetwork);
            threadCheckNetwork.Name = "Проверка соединения интернета";
            threadCheckNetwork.Start();

        }

        ~MailClient()
        {
            threadCheckNetwork = null;
        }

        private static void checkNetwork()
        {
            while (true)
            {
                try
                {
                    Ping ping = new Ping();
                    PingReply pingReply = ping.Send("www.google.com");
                    
                    if (pingReply.Status.ToString().Equals("Success"))
                    {
                        lock (ObjLock)
                        {
                            CurrentNetwork = NetworkStatus.Connected;
                        }
                    }
                }
                catch (Exception)
                {
                    lock (ObjLock)
                    {
                        CurrentNetwork = NetworkStatus.Disconnected;
                    }
                }
                
                Thread.Sleep(5000);
            }
        }

        public void AuthUser(string email, string password)
        {

        }

        public bool GetFolders()
        {
            try
            {
                var domain = AuthHelper.GetDomain(CurrentUser.Email);
                var server = DBServers.GetServerInfo(DBConnection.Connection, domain);
                var list = new List<FolderInfo>();

                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                    client.Connect(server.ImapHost, (int) server.ImapPort, server.IsSsl);
                    client.Authenticate(CurrentUser.Email, CurrentUser.Password);

                    var inbox = client.Inbox;
                    Folders = client.GetFolders(client.PersonalNamespaces.First());

                    client.Disconnect(true);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<LetterInfo> GetLetters()
        {
            return null;
        }

        public LetterInfo GetLetter()
        {
            return null;
        }

        public bool SendLetter(MimeMessage msg)
        {
            try
            {
                var domain = AuthHelper.GetDomain(CurrentUser.Email);
                var server = DBServers.GetServerInfo(DBConnection.Connection, domain);
                
                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                    client.Connect(server.SmtpHost, (int) server.SmtpPort, server.IsSsl);
                    client.Authenticate(CurrentUser.Email, CurrentUser.Password);
                    client.Send(msg);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
