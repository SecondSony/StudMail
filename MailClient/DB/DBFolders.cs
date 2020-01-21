using MailClient.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MailClient.DB
{
    public class DBFolders
    {
        public static List<LetterInfo> GetLettersFromDB(SQLiteConnection connection, int folderId)
        {
            return DBLetters.GetLetters(connection, folderId);
        }

        public static List<string> GetNames(SQLiteConnection connection, int userId)
        {
            var localFolders = new List<string>();
            var reqStr = $"SELECT folder_name FROM folders WHERE user_id = '{userId}'";

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    using (var cmd = new SQLiteCommand(reqStr, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                localFolders.Add(reader.GetString(0).Trim(' '));
                            }

                            return localFolders;
                        }
                    }
                }
                catch (Exception)
                {
                    return localFolders;
                }
            }

            return localFolders;
        }

        public static List<FolderInfo> GetFolders(SQLiteConnection connection, int userId)
        {
            var localFolders = new List<FolderInfo>();
            var reqStr = $"SELECT id, folder_name FROM folders WHERE user_id = '{userId}'";

            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    using (var cmd = new SQLiteCommand(reqStr, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var folder = new FolderInfo();
                                folder.Id = reader.GetInt32(0);
                                folder.Name = reader.GetString(1).Trim(' ');

                                localFolders.Add(folder);
                            }

                            return localFolders;
                        }
                    }
                }
                catch (Exception)
                {
                    return localFolders;
                }
            }

            return localFolders;
        }

        public static bool SyncFolders(SQLiteConnection connection, List<string> folders, int userId)
        {
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    var localFolders = GetNames(connection, userId);
                    var intersect = folders.Intersect(localFolders).ToArray();
                    var newFolders = folders.Except(intersect).ToArray();
                    var delFolders = localFolders.Except(intersect).ToArray();

                    foreach (var item in newFolders)
                    {
                        var reqStr = $"INSERT INTO folders (user_id, folder_name) VALUES ('{userId}','{item}')";

                        using (var cmd = new SQLiteCommand(reqStr, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    foreach (var item in delFolders)
                    {
                        var reqStr = $"DELETE FROM folders WHERE user_id='{userId}' and folder_name='{item}'";

                        using (var cmd = new SQLiteCommand(reqStr, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return false;
        }
    }
}
