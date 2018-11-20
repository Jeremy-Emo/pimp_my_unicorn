using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormPimpMyUnicorn
{
    public static class FileProvider
    {
        public static void MonitorDirectory()
        {
            
            if (!Directory.Exists(Settings1.Default.path_to_folder)) Directory.CreateDirectory(Settings1.Default.path_to_folder);
            FileSystemWatcher fsw = new FileSystemWatcher(Settings1.Default.path_to_folder, "*.sql");
            fsw.EnableRaisingEvents = true;
            fsw.Changed += Fsw_Changed;
            
        }

        private static void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            string path = e.FullPath;

            try
            {
                StreamReader sr = new StreamReader(path, Encoding.Default);

                List<string> contenu = new List<string>();
                while (!sr.EndOfStream)
                {
                    contenu.Add(sr.ReadLine());
                }
                sr.Close();

                WCFPimpMyUnicorn.Service1Client serviceClient = new WCFPimpMyUnicorn.Service1Client();
                bool success = serviceClient.UpdateDatabase(contenu.ToArray());

                if (success) File.Delete(path);

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
