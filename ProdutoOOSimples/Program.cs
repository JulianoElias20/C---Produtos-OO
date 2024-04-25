using ProdutoOOSimples;
using System;
using System.Net.Http.Headers;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");

            Produto prod = new Produto();

            Console.Write("Nome: ");
            prod.Name = Console.ReadLine();
            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: "+prod.ToString());

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            prod.AdicionarProduto(quantidade);
            Console.WriteLine("Dados atualizado "+prod.ToString());

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            prod.RemoverProduto(quantidade);
            Console.WriteLine("Dados atualizado " + prod.ToString());






        }
    }
}