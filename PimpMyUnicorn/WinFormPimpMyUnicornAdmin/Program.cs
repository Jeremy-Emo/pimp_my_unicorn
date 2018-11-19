using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;
using System.IO;

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
                var db = new SQLiteConnection("MyDatabase.db3", SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite);
                db.CreateTable<T_elements>();
                db.CreateTable<T_parties>();
                db.Close();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAdmin());
        }
    }
}
