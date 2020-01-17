using MailClient.Helpers;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace MailClient.DB
{
    public class DBLetters
    {
        public static List<int> GetUids(SQLiteConnection connection, int folderId)
        {
            var uids = new List<int>();
            var msg = $"SELECT letters.uid FROM letters INNER JOIN folders ON letters.folder_id =" +
                      $" folders.id WHERE folders.id='{folderId}'";

            if (connection.State == ConnectionState.Open)
            {
                using (var cmd = new SQLiteCommand(msg, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        uids.Add(reader.GetInt32(0));
                    }
                }
            }

            return uids;
        }

        public static List<LetterInfo> GetLetters(SQLiteConnection connection, int folderId)
        {
            var letters = new List<LetterInfo>();
            var msg = $"SELECT * FROM letters INNER JOIN folders ON letters.folder_id = " +
                      $"folders.id WHERE folders.id='{folderId}'";

            if (connection.State == ConnectionState.Open)
            {
                using (var cmd = new SQLiteCommand(msg, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var letter = new LetterInfo();
                        letter.Id = reader.GetInt32(0);
                        letter.FolderId = reader.GetInt32(1);
                        letter.Uid = reader.GetInt32(2);
                        letter.MsgBase64 = reader.GetString(3).Trim(' ');

                        letters.Add(letter);
                    }
                }
            }

            return letters;
        }

        public LetterInfo GetLetter(SQLiteConnection connection, int folderId, int uid)
        {
            var reqStr = $"SELECT * FROM letters WHERE folder_id='{folderId}' and uid='{uid}'";

            if (connection.State == ConnectionState.Open)
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var letter = new LetterInfo
                        {
                            Id = reader.GetInt32(0),
                            FolderId = reader.GetInt32(1),
                            Uid = reader.GetInt32(2),
                            MsgBase64 = reader.GetString(3).Trim(' ')
                        };

                        return letter;
                    }
                }
            }

            return null;
        }

        // TODO:
        public static bool IsLetterExists(SQLiteConnection connection, long folderId, long uid)
        {
            var reqStr = $"SELECT letters.uid FROM letters WHERE letters.folder_id='{folderId}' " +
                         $"AND letters.uid='{uid}'";

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

        // TODO:
        public static bool Add(SQLiteConnection connection, LetterInfo newItem)
        {
            var reqStr = $"INSERT INTO letters(folder_id, uid, message_base64) " +
                         $"VALUES('{newItem.FolderId}', '{newItem.Uid}', '{newItem.MsgBase64}')";

            if (!IsLetterExists(connection, newItem.FolderId, newItem.Uid))
            {
                using (var cmd = new SQLiteCommand(reqStr, connection))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }

            return false;
        }

        public static bool Remove(SQLiteConnection connection, int folderId, int uid)
        {
            var reqStr = $"DELETE FROM letters WHERE folder_id='{folderId}' and uid='{uid}'";

            if (IsLetterExists(connection, folderId, uid))
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
