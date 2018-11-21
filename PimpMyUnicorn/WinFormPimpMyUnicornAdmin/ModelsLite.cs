using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WinFormPimpMyUnicornAdmin
{
    public class T_elements
    {
        public int Id_element { get; set; }
        public string elementLibelle { get; set; }
        public string elementsImg { get; set; }
        public int partie_id { get; set; }

        public string getPart()
        {
            string db = "Data Source=MyDatabase.db3;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            string sql = "SELECT partieLibelle from t_parties WHERE Id_partie = " + partie_id;
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = (SQLiteDataReader)command.ExecuteScalar();
            string fer = reader.GetValue(0).ToString();

            conn.Close();

            return fer;
        }
    }
    
    public class T_parties 
    {
        public int Id_partie { get; set; }
        public string partieLibelle { get; set; }
    }
}
