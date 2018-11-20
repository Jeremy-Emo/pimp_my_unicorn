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
                  "`partieLibelle` varchar(255) NOT NULL"+
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

                string test = "INSERT INTO `t_parties` (`Id_partie`, `partieLibelle`) VALUES" +
                        "(1, 'Corne')," +
                        "(2, 'Queue')," +
                        "(3, 'Sabot')," +
                        "(4, 'Crinière')," +
                        "(5, 'Robe'); ";
                SQLiteCommand import3 = new SQLiteCommand(test, conn);
                import3.ExecuteNonQuery();

                conn.Close();
            }
            
            Console.WriteLine(Crud.getAllParties());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileProvider.MonitorDirectory();
            Application.Run(new FormAdmin());
        }
    }
}
