using System;
using System.Globalization;

namespace Estoque {
    class Produto {

        private String _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() { }

        public Produto(String nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

        public Produto(String nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }

        public String Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int q) {
            Quantidade += q;
        }

        public void RemoverProdutos(int q) {
            Quantidade -= q;
        }

        public override string ToString() {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
