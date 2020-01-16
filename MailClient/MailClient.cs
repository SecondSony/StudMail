using MailClient.DB;
using MailClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailClient
{
    public class MailClient
    {
        public DBConnection Database;
        public string CurrentFolder;
        public string Folder;
        public UserInfo CurrentUser;
        public static NetworkStatus CurrentNetwork;
        private Thread threadCheckNetwork;
        private static object lockObj;

        public MailClient()
        {
            Database = new DBConnection();
            CurrentFolder = "INBOX";
            Folder = "";
            CurrentNetwork = NetworkStatus.Disconnected;
            threadCheckNetwork = new Thread(checkNetwork);
            threadCheckNetwork.Name = "Проверка соединения интернета";
            threadCheckNetwork.Start();
        }

        ~MailClient()
        {

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
                        lock (lockObj)
                        {
                            CurrentNetwork = NetworkStatus.Connected;
                        }
                    }
                }
                catch (Exception)
                {
                    lock (lockObj)
                    {
                        CurrentNetwork = NetworkStatus.Disconnected;
                    }
                }
                
                Thread.Sleep(10000);
            }
        }

        public void AuthUser(string email, string password)
        {

        }

        public List<FolderInfo> GetFolders()
        {
            return null;
        }

        public List<LetterInfo> GetLetters()
        {
            return null;
        }

        public LetterInfo GetLetter()
        {
            return null;
        }

        public bool SendLetter()
        {
            return false;
        }
    }
}
