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
        
        public static List<T_parties> getAllParties()
        {
            SQLiteConnection conn = new SQLiteConnection(_db);
            conn.Open();

            string sql = "SELECT Id_partie, partieLibelle from t_parties";
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
            string sql = "SELECT Id_element, elementLibelle, elementsImg, partie_id from t_elements";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            List<T_elements> elements = new List<T_elements>();
            while (reader.Read())
            {
                T_elements e = new T_elements();
                e.Id_element = Convert.ToInt32(reader.GetValue(0));
                e.elementLibelle = reader.GetValue(1).ToString();
                e.elementsImg = reader.GetValue(2).ToString();
                e.partie_id = Convert.ToInt32(reader.GetValue(3));
                elements.Add(e);
            }
            conn.Close();
            return elements;
        }

        public static void insertElement(string nomElement, string image, int partieID)
        {
            SQLiteConnection conn = new SQLiteConnection(_db);
            conn.Open();

            string sql = "INSERT INTO t_elements (elementLibelle, elementsImg, partie_id) VALUES('"+
                nomElement + "','" + image + "', " + partieID + ")";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            Crud.registerSQL(sql);

            conn.Close();
        }

        public static void registerSQL(string command)
        {
            StreamWriter Sw = new StreamWriter(@Settings1.Default.path_to_folder + @"\" + DateTime.Now.Ticks + "." + @Settings1.Default.file_extension, true, Encoding.Default);
            lock (Sw)
            {
                Sw.WriteLine(command);
                Sw.Close();
            }
        }
    }
}
