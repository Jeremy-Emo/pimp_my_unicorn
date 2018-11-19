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
            FileSystemWatcher fsw = new FileSystemWatcher(@"C:\TEMP\PIMPMYUNICORN", "*.sql");
            fsw.EnableRaisingEvents = true;
            fsw.Changed += Fsw_Changed;
            //fsw.WaitForChanged(WatcherChangeTypes.All, 3000);
        }

        private static void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            string path = e.FullPath;

            StreamReader sr = new StreamReader(path, Encoding.Default);

            List<string> contenu = new List<string>();
            while (!sr.EndOfStream)
            {
                contenu.Add(sr.ReadLine());
            }
            sr.Close();

            WCFPimpMyUnicorn.Service1Client serviceClient = new WCFPimpMyUnicorn.Service1Client();
            bool success = serviceClient.UpdateDatabase(contenu.ToArray());
        }
    }
}
