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
            string targetPath2 = @"C:\Users\rgvas\HOME\file3.txt";
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

                sr = File.OpenText(targetPath);

                while (!sr.EndOfStream)
                {
                    string lineRead = sr.ReadLine();
                    Console.WriteLine(lineRead);
                }

                using (StreamReader sr2 = File.OpenText(sourcePath))
                {
                    while (!sr2.EndOfStream)
                    {
                        string lineRead = sr2.ReadLine();
                        Console.WriteLine(lineRead);
                    }
                }

                string[] linesOfFileRead = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath2))
                {
                    foreach (string lin in linesOfFileRead)
                    {
                        sw.WriteLine(lin.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
