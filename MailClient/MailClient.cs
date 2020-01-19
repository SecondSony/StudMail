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
        public IMailFolder CurrentFolder;
        public UserInfo CurrentUser;
        public MimeMessage CurrentReadMsg;
        public List<MimeMessage> Letters;
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
            CurrentFolder = null;
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

        public bool GetFolders()
        {
            try
            {
                var domain = AuthHelper.GetDomain(CurrentUser.Email);
                var server = DBServers.GetServerInfo(DBConnection.Connection, domain);

                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                    client.Connect(server.ImapHost, (int) server.ImapPort, server.IsSsl);
                    client.Authenticate(CurrentUser.Email, CurrentUser.Password);

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

        public bool GetLetters(int folderId, int curPage)
        {
            try
            {
                var counter = 0;
                var domain = AuthHelper.GetDomain(CurrentUser.Email);
                var server = DBServers.GetServerInfo(DBConnection.Connection, domain);

                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                    client.Connect(server.ImapHost, (int) server.ImapPort, server.IsSsl);
                    client.Authenticate(CurrentUser.Email, CurrentUser.Password);

                    CurrentFolder = client.GetFolder(Folders[folderId].FullName);
                    CurrentFolder.Open(FolderAccess.ReadOnly);
                    Letters = new List<MimeMessage>();

                    for (int i = curPage * 500; i < CurrentFolder.Count; i++)
                    {
                        var msg = CurrentFolder.GetMessage(i);

                        Letters.Add(msg);
                        counter++;

                        if (counter >= 50) break;
                    }

                    CurrentFolder.Close();
                    client.Disconnect(true);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public MimeMessage GetLetter(int folderId, int curPage, int letterId)
        {
            try
            {
                var domain = AuthHelper.GetDomain(CurrentUser.Email);
                var server = DBServers.GetServerInfo(DBConnection.Connection, domain);
                MimeMessage msg;

                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                    client.Connect(server.ImapHost, (int) server.ImapPort, server.IsSsl);
                    client.Authenticate(CurrentUser.Email, CurrentUser.Password);

                    CurrentFolder = client.GetFolder(Folders[folderId].FullName);
                    CurrentFolder.Open(FolderAccess.ReadOnly);

                    msg = CurrentFolder.GetMessage(curPage * 500 + letterId);

                    CurrentFolder.Close();
                    client.Disconnect(true);
                    return msg;
                }
            }
            catch (Exception)
            {
                return null;
            }
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
