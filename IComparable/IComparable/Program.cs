using Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace IComparableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\rgvas\HOME\file1.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    List <Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();

                    foreach (Employee item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
        }
    }
}
