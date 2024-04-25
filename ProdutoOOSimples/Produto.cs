using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoOOSimples
{
    internal class Produto
    {
        public string Name;
        public double Preco;
        public int Quantidade;


        public double ValorTotal()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return $"{Name}, $ {Preco.ToString("F2")}, {Quantidade} unidades, Total: {ValorTotal().ToString("F2")}";
        }
    }
}
