using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦентральныйСклад
{
    static class sqlConn
    {
        static string server = "109.191.87.56";
        static string port = "33333";
        static string user = "UlyanovTV";
        static string database = "diplom";
        static string password = "OgIsEf0202!";

        static string connectionString = $"server={server};port={port};user={user};database={database};password={password}";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
    }
}
