using System;
using System.IO;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rgvas\HOME";
            string filePath = @"C:\Users\rgvas\HOME\file1.txt";

            try
            {

                Console.WriteLine("Path.DirectorySeparatorChar " + Path.DirectorySeparatorChar);
                Console.WriteLine("Path.PathSeparator " + Path.PathSeparator);
                Console.WriteLine("Path.GetDirectoryName " + Path.GetDirectoryName(filePath));
                Console.WriteLine("Path.GetFileName " + Path.GetFileName(filePath));
                Console.WriteLine("Path.GetExtension " + Path.GetExtension(filePath));
                Console.WriteLine("Path.GetFileNameWithoutExtension " + Path.GetFileNameWithoutExtension(filePath));
                Console.WriteLine("Path.GetFullPath " + Path.GetFullPath(filePath));
                Console.WriteLine("Path.GetTempPath " + Path.GetTempPath());


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

                // direc.CreateSubdirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
