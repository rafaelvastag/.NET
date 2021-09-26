using System;
using System.Collections.Generic;
using System.Globalization;

namespace Estoque {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 900.00, 100);
            Console.WriteLine(p.Nome);
            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            Point point;
            point.X = 10;
            point.Y = 20;
            Console.WriteLine(point);

            int s1 = Calculator.Sum(12, 30, 10);
            Console.WriteLine(s1);

            int t1 = 10;
            Calculator.Triple(ref t1);
            Console.WriteLine(t1);

            int t2 = 10;
            int result;
            Calculator.TripleOut(t2, out result);
            Console.WriteLine(result);

            string[] vect = new string[] { "a", "b", "c", "d" };
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }

            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Joao");
            list.Add("Rafael");
            list.Add("Anna");
            list.Insert(2, "Pos 2 element");

            foreach(string element in list) {
                Console.WriteLine(element);
            }
            Console.WriteLine("List count: " + list.Count);

            string f1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(f1);

            string f2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(f2);

            int p1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(p1);

            int p2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(p2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string element in list2) {
                Console.WriteLine(element);
            }

            list.Remove("Rafael");
            foreach (string element in list) {
                Console.WriteLine(element);
            }

            list.RemoveAll(x => x[0] == 'A');
            foreach (string element in list) {
                Console.WriteLine(element);
            }


            /*
            Produto p2 = new Produto("TV2", 700.00);
            Console.WriteLine(p2);

            Produto p3 = new Produto {
                Nome = "TV3",
                Preco = 300.00,
                Quantidade = 2
            };
            Console.WriteLine(p3);
            /*
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + p);
            */
        }
    }
}
