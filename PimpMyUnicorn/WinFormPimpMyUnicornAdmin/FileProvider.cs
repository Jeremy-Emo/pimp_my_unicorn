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

        private static string path = Settings1.Default.path_to_folder;
        private static int timer = Settings1.Default.wcf_timer;
        private static string file_extension = Settings1.Default.file_extension;
        private static Task task;

        public static void MonitorDirectory()
        {
            DirectoryInfo directory_info = new DirectoryInfo(path);
            if (!directory_info.Exists) directory_info.Create();
            task = WCF_Loop();
            FileSystemWatcher fsw = new FileSystemWatcher(path, "*." + file_extension);
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

        private static async Task WCF_Loop()
        {
            while (true)
            {
                DirectoryInfo d = new DirectoryInfo(path);
                if (d.Exists)
                {
                    FileInfo[] files = d.GetFiles("*." + file_extension);
                    foreach (FileInfo file_info in files)
                    {
                        List<String> queries = new List<string>();
                        StreamReader sr = new StreamReader(file_info.FullName);
                        lock (sr)
                        {
                            while (!sr.EndOfStream)
                            {
                                queries.Add(sr.ReadLine());
                            }
                        }
                        sr.Close();
                        WCFPimpMyUnicorn.Service1Client serviceClient = new WCFPimpMyUnicorn.Service1Client();
                        bool success = serviceClient.UpdateDatabase(queries.ToArray());
                        if (success) file_info.Delete();
                    }
                }
                await Task.Delay(timer * 1000);
            }
        }
    }
}
