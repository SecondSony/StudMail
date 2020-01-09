using MailClient.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                Email = reader.GetString(2),
                                OwnPrivate = reader.GetString(3),
                                OwnPublic = reader.GetString(4),
                                OwnPrivateECP = reader.GetString(5),
                                OwnPublicECP = reader.GetString(6),
                                EmailPublic = reader.GetString(7),
                                EmailPublicECP = reader.GetString(8)
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

            if (IsBookExists(connection) && connection.State == ConnectionState.Open)
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

            if (IsBookExists(connection) && connection.State == ConnectionState.Open)
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
