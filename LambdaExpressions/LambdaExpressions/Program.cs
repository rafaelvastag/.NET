using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // PREDICATE

            list.RemoveAll(p => p.Price < 100);

            // OR - Using function reference
            list.RemoveAll(ProductRemoveIf);

            // ACTION
            Action <Product> action = ActionUpdatePrice;
            list.ForEach(action);

            // FUNC
            // OR - Creating a Func.
            Func<Product, string> func = p => { return p.Name.ToUpper();  } ;


            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductRemoveIf(Product p)
        {
            return p.Price < 100;
        }

        public static void ActionUpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
