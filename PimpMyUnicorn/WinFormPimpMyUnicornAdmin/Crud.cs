using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormPimpMyUnicornAdmin;

namespace WinFormPimpMyUnicorn
{
    public class Crud
    {
        private static string _db = "Data Source=MyDatabase.db3;Version=3;";
        
        public List<T_parties> getAllParties()
        {
            SQLiteConnection conn = new SQLiteConnection(_db);
            string sql = "SELECT * from t_parties";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            List<T_parties> parties = new List<T_parties>();
            foreach (DataRow row in reader)
            {
                T_parties p = new T_parties();
                p.Id_partie = Convert.ToInt32(row["Id_partie"]);
                p.partieLibelle = row["partieLibelle"].ToString();
                parties.Add(p);
            }
            return parties;
        }

        public List<T_elements> getAllElements()
        {
            SQLiteConnection conn = new SQLiteConnection(_db);
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
            return elements;
        }
    }
}
