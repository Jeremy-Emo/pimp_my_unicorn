using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormPimpMyUnicorn;
using System.Data.SQLite;

namespace WinFormPimpMyUnicornAdmin
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("MyDatabase.db3"))
            {
                SQLiteConnection.CreateFile("MyDatabase.db3");
                SQLiteConnection conn = new SQLiteConnection("Data Source = MyDatabase.db3; Version = 3;");
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS `t_parties` ("+
                  "`Id_partie` INTEGER PRIMARY KEY NOT NULL," +
                  "`partieLibelle` varchar(255) NOT NULL," +
                  "`ordre` int(11) NOT NULL" +
                ");";
                SQLiteCommand import = new SQLiteCommand(sql, conn);
                import.ExecuteNonQuery();


                string sql2 = "CREATE TABLE IF NOT EXISTS `t_elements` ("+
                  "`Id_element` INTEGER PRIMARY KEY NOT NULL," +
                  "`partie_id` int(11) NOT NULL,"+
                  "`elementLibelle` varchar(255) NOT NULL,"+
                  "`elementsImg` text NOT NULL"+
                ");";
                SQLiteCommand import2 = new SQLiteCommand(sql2, conn);
                import2.ExecuteNonQuery();
                
                WinFormPimpMyUnicorn.WCFPimpMyUnicorn.Service1Client svc = new WinFormPimpMyUnicorn.WCFPimpMyUnicorn.Service1Client();
                List<WinFormPimpMyUnicorn.WCFPimpMyUnicorn.PartiesDTO> data = svc.GetParties().ToList();

                foreach(WinFormPimpMyUnicorn.WCFPimpMyUnicorn.PartiesDTO da in data)
                {
                    string test = "INSERT INTO `t_parties` (`Id_partie`, `partieLibelle`, `ordre`) VALUES" +
                            "(" + da.ID + ",'" + da.Libelle + "' " + da.ordre + ");";
                    SQLiteCommand import3 = new SQLiteCommand(test, conn);
                    import3.ExecuteNonQuery();
                }

                List<WinFormPimpMyUnicorn.WCFPimpMyUnicorn.ElementsDTO> data2 = svc.GetElements().ToList();

                foreach(WinFormPimpMyUnicorn.WCFPimpMyUnicorn.ElementsDTO da in data2)
                {
                    string test = "INSERT INTO `t_elements` (`Id_element`, `elementLibelle`, `elementsImg`, `partie_id`) VALUES" +
                            "(" + da.ID + ",'" + da.Libelle + "','" + da.Image + "'," + da.PartieID + ");";
                    SQLiteCommand import4 = new SQLiteCommand(test, conn);
                    import4.ExecuteNonQuery();
                }


                conn.Close();
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileProvider.MonitorDirectory();
            Application.Run(new FormAdmin());
        }
    }
}
