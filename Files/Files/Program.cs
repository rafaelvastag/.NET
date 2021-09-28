using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\rgvas\HOME\file1.txt";
            string targetPath = @"C:\Users\rgvas\HOME\file2.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                // fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                fs = new FileStream(targetPath, FileMode.Open);
                sr = new StreamReader(fs);

                string lineRead = sr.ReadLine();
                Console.WriteLine(lineRead);

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
