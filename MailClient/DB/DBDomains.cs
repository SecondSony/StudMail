using MailClient.Helpers;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace MailClient.DB
{
    public class DBServers
    {
        public static List<ServerInfo> GetServers(SQLiteConnection connection)
        {
            var domains = new List<ServerInfo>();
            var reqStr = $"SELECT Servers.domain, Servers.smtp_host, Servers.smtp_port, " +
                         $"Servers.imap_host, Servers.imap_port, Servers.pop3_host, " +
                         $"Servers.pop3_port, Servers.ssl FROM Servers";

            if (connection.State == ConnectionState.Open)
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ServerInfo
                            {
                                Domain = reader.GetString(0).Trim(' '),
                                SmtpHost = reader.GetString(1).Trim(' '),
                                SmtpPort = reader.GetInt64(2),
                                ImapHost = reader.GetString(3).Trim(' '),
                                ImapPort = reader.GetInt64(4),
                                Pop3Host = reader.GetString(5).Trim(' '),
                                Pop3Port = reader.GetInt64(6),
                                IsSsl = reader.GetInt32(7) == 1 ? true : false
                            };

                            domains.Add(item);
                        }
                    }
                }
            }

            return domains;
        }

        public static ServerInfo GetServerInfo(SQLiteConnection connection, string domain)
        {
            var reqStr = $"SELECT Servers.smtp_host, Servers.smtp_port, Servers.imap_host, " +
                         $"Servers.imap_port, Servers.pop3_host, Servers.pop3_port, Servers.ssl " +
                         $"FROM Servers WHERE Servers.domain='{domain}'";

            if (connection.State == ConnectionState.Open)
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var serverInfo = new ServerInfo();
                            serverInfo.Domain = domain;
                            serverInfo.SmtpHost = reader.GetString(0).Trim(' ');
                            serverInfo.SmtpPort = reader.GetInt64(1);
                            serverInfo.ImapHost = reader.GetString(2).Trim(' ');
                            serverInfo.ImapPort = reader.GetInt64(3);
                            serverInfo.Pop3Host = reader.GetString(4).Trim(' ');
                            serverInfo.Pop3Port = reader.GetInt64(5);
                            serverInfo.IsSsl = reader.GetInt32(6) == 1 ? true : false;

                            return serverInfo;
                        }
                    }
                }
            }

            return null;
        }

        public static bool IsDomainExists(SQLiteConnection connection, string domain)
        {
            var reqStr = $"SELECT Servers.domain FROM Servers WHERE Servers.domain='{domain}'";

            if (connection.State == ConnectionState.Open)
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }

            return false;
        }

        public static bool Add(SQLiteConnection connection, ServerInfo newItem)
        {
            var reqStr = $"INSERT INTO Servers(domain, smtp_host, smtp_port, imap_host, " +
                         $"imap_port, pop3_host, pop3_port, ssl) VALUES('{newItem.Domain}', " +
                         $"'{newItem.SmtpHost}', '{newItem.SmtpPort}', '{newItem.ImapHost}', " +
                         $"'{newItem.ImapPort}', '{newItem.Pop3Host}', '{newItem.Pop3Port}', " +
                         $"'{((newItem.IsSsl == true) ? 1 : 0)}')";

            if (!IsDomainExists(connection, newItem.Domain))
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }

        public static bool Remove(SQLiteConnection connection, string domain)
        {
            var reqStr = $"DELETE FROM Servers WHERE Servers.domain='{domain}'";

            if (IsDomainExists(connection, domain))
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }
    }
}
