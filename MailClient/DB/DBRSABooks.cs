using MailClient.Helpers;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace MailClient.DB
{
    public class DBRSABooks
    {
        public static List<RSABookInfo> GetBooks(SQLiteConnection connection, int userId)
        {
            var books = new List<RSABookInfo>();
            var reqStr = $"SELECT id, user_id, email, own_private_key, own_public_key, " +
                         $"own_private_key_ecp, own_public_key_ecp, email_public_key, " +
                         $"email_public_key_ecp FROM RSABOOKS WHERE user_id = '{userId}'";

            if (connection.State == ConnectionState.Open)
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new RSABookInfo()
                            {
                                Id = reader.GetInt32(0),
                                Email = reader.GetString(2).Trim(' '),
                                OwnPrivate = reader.GetString(3).Trim(' '),
                                OwnPublic = reader.GetString(4).Trim(' '),
                                OwnPrivateECP = reader.GetString(5).Trim(' '),
                                OwnPublicECP = reader.GetString(6).Trim(' '),
                                EmailPublic = reader.GetString(7).Trim(' '),
                                EmailPublicECP = reader.GetString(8).Trim(' ')
                            };

                            books.Add(item);
                        }
                    }
                }
            }

            return books;
        }

        // TODO:
        public static bool IsBookExists(SQLiteConnection connection)
        {
            return false;
        }

        public static bool AddBookInfo(SQLiteConnection connection, RSABookInfo newItem)
        {
            var reqStr = $"INSERT INTO RSABOOKS (user_id, email, own_private_key, own_public_key, " +
                         $"own_private_key_ecp, own_public_key_ecp, email_public_key, " +
                         $"email_public_key_ecp) VALUES('{newItem.UserId}', '{newItem.Email}', " +
                         $"'{newItem.OwnPrivate}', '{newItem.OwnPublic}', '{newItem.OwnPrivateECP}', " +
                         $"'{newItem.OwnPublicECP}', '{newItem.EmailPublic}', '{newItem.EmailPublicECP}')";

            if (!IsBookExists(connection))
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }

        public static bool RemoveBookInfo(SQLiteConnection connection, RSABookInfo rmvItem)
        {
            var reqStr = $"DELETE FROM RSABOOKS WHERE email='{rmvItem.Email}' AND user_id='{rmvItem.UserId}'";

            if (IsBookExists(connection))
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
