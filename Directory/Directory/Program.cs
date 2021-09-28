using System;
using System.IO;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rgvas\HOME";

            try
            {
                DirectoryInfo direc = new DirectoryInfo(path);
                var folders = direc.EnumerateDirectories();

                Console.WriteLine("FOLDERS: ");

                foreach (var s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = direc.EnumerateFiles();

                Console.WriteLine("FILES: ");

                foreach (var s in files)
                {
                    Console.WriteLine(s);
                }

                direc.CreateSubdirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
