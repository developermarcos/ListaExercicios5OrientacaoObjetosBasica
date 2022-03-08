using System;

namespace SalarioVendedor.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vendedor vendedor = new Vendedor();
            vendedor.nome = "Marcos Lima";
            vendedor.salarioBase = 1200.00m;
            vendedor.totalVendas = 10000;
            vendedor.percentual = 10;
            Console.WriteLine("O vendedor {0} teve o total de R$ {1} em vendas e recebera o salário de {2}", vendedor.nome, vendedor.totalVendas.ToString(), vendedor.Comissao().ToString("N2"));
            Console.ReadKey();
        }
    }
}
