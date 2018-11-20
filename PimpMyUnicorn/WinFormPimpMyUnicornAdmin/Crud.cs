using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormPimpMyUnicornAdmin;

namespace WinFormPimpMyUnicorn
{
    public class Crud
    {
        private static string _db = "Data Source=MyDatabase.db3;Version=3;";
        private static string _path = Settings1.Default.path_to_folder + DateTime.Now + "." + Settings1.Default.file_extension;
        
        public static List<T_parties> getAllParties()
        {
            SQLiteConnection conn = new SQLiteConnection(_db);
            conn.Open();

            string sql = "SELECT * from t_parties";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            List<T_parties> parties = new List<T_parties>();
            while (reader.Read())
            {
                T_parties p = new T_parties();
                p.Id_partie = Convert.ToInt32(reader.GetValue(0));
                p.partieLibelle = reader.GetValue(1).ToString();
                parties.Add(p);
            }
            conn.Close();
            return parties;
        }

        public static List<T_elements> getAllElements()
        {
            SQLiteConnection conn = new SQLiteConnection(_db);
            conn.Open();
            string sql = "SELECT * from t_elements";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            List<T_elements> elements = new List<T_elements>();
            foreach (DataRow row in reader)
            {
                T_elements e = new T_elements();
                e.Id_element = Convert.ToInt32(row["Id_element"]);
                e.elementLibelle = row["elementLibelle"].ToString();
                e.elementsImg = row["elementsImg"].ToString();
                e.partie_id = Convert.ToInt32(row["partie_id"]);
                elements.Add(e);
            }
            conn.Close();
            return elements;
        }

        public static void registerSQL(string command)
        {
            if (!File.Exists(_path))
            {

            }
        }
    }
}
