using HashSetSortedSet.Entities;
using System;
using System.Collections.Generic;

namespace HashSetSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> SortedA = new SortedSet<int>() { 0, 2, 4, 5 };
            SortedSet<int> SortedB = new SortedSet<int>() { 0, 2, 4, 5, 6, 7, 8 };

            PrintCollection(SortedA);

            //union
            SortedSet<int> SortedC = new SortedSet<int>(SortedA);
            SortedC.UnionWith(SortedB);

            PrintCollection(SortedC);

            //intersection
            SortedSet<int> SortedD = new SortedSet<int>(SortedA);
            SortedD.IntersectWith(SortedB);

            PrintCollection(SortedD);

            //Difference
            SortedSet<int> SortedE = new SortedSet<int>(SortedA);
            SortedE.ExceptWith(SortedB);

            PrintCollection(SortedE);

            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("Rafael");
            set.Add("Jose");

            Console.WriteLine(set.Contains("Rafael"));

            HashSet<Product> setProduct = new HashSet<Product>();
            setProduct.Add(new Product("TV", 900.00));
            setProduct.Add(new Product("Notebook", 1200.00));

            HashSet<Point> setPoint = new HashSet<Point>();
            setPoint.Add(new Point(3, 4));
            setPoint.Add(new Point(5, 12));


            Product prod = new Product("TV", 900.00);
            Console.WriteLine(setProduct.Contains(prod));

            Point point = new Point(5, 12);
            Console.WriteLine(setPoint.Contains(point));

        }

        static void PrintCollection<T> (IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }
    }
}
