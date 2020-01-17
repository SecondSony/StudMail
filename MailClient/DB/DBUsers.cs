using MailClient.Crypto;
using MailClient.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вопросы с хэшем пароля, проверкой существующего аккаунта, изменчивости юзера в AuthUser, 
// DBFolders, записи в БД юзеров, папок, писем, зачем Property, MailClient
namespace MailClient.DB
{
    public class DBUsers
    {
        public static void GetFolders(SQLiteConnection connection, int userId, ref List<FolderInfo> folders)
        {
            try
            {
                folders.Clear();
                folders = DBFolders.GetFolders(connection, userId);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка при получении папок");
            }
        }

        public static void GetKeys(SQLiteConnection connection, int userId, ref List<RSABookInfo> books)
        {
            try
            {
                books = DBRSABooks.GetBooks(connection, userId);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка при получении ключей");
            }
        }

        public static UserInfo AuthUser(SQLiteConnection connection, string email, string password, int serverId)
        {
            try
            {
                var user = new UserInfo();

                if (IsAccountExists(connection, email, serverId))
                {
                    UpdateAccountData(connection, email, password, serverId);
                    user = GetLoginAccount(connection, email, password, serverId);
                }
                else
                {
                    AddAccount(connection, email, password, serverId);
                    user = GetLoginAccount(connection, email, password, serverId);
                }

                return user;
            }
            catch (SQLiteException)
            {
                throw new SQLiteException("Ошибка при аутентификации");
            }
            
        }

        public static bool IsAccountExists(SQLiteConnection connection, string email, int serverId)
        {
            var reqStr = $"SELECT * FROM users WHERE email='{email}' and server_id='{serverId}'";

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

        public static UserInfo GetLoginAccount(SQLiteConnection connection, string email, string password, int serverId)
        {
            var reqStr = $"SELECT * FROM users WHERE server_id='{serverId}' AND email='{email}' " +
                         $"AND password='{UserSHA1.ComputeHashSHA1(password)}'";

            if (connection.State == ConnectionState.Open)
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var user = new UserInfo();
                        user.Id = reader.GetInt32(0);
                        user.ServerId = reader.GetInt32(3);

                        return user;
                    }
                }
            }

            return null;
        }

        public static bool AddAccount(SQLiteConnection connection, string email, string password, int serverId)
        {
            string reqStr = $"INSERT into users (email,password,server_id) VALUES ('{email}','{UserSHA1.ComputeHashSHA1(password)}','{serverId}')";

            if (!IsAccountExists(connection, email, serverId))
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }

        public static bool RemoveAccount(SQLiteConnection connection, string email, int serverId)
        {
            var reqStr = $"DELETE FROM users WHERE email='{email}' and server_id='{serverId}'";

            if (IsAccountExists(connection, email, serverId))
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }

        public static bool UpdateAccountData(SQLiteConnection connection, string email, string password, int serverId)
        {
            var reqStr = $"UPDATE users SET password='{UserSHA1.ComputeHashSHA1(password)}' WHERE email='{email}'";

            if (IsAccountExists(connection, email, serverId))
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
