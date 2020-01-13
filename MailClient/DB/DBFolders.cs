using MailClient.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient.DB
{
    public class DBFolders
    {
        public static List<LetterInfo> GetLettersFromFolder(SQLiteConnection connection, int folderId)
        {
            return DBLetters.GetLetters(connection, folderId);
        }

        public static List<string> GetNames(SQLiteConnection connection)
        {
            return null;
        }

        public static FolderInfo GetFolder(SQLiteConnection connection)
        {
            return null;
        }
    }
}
