using System;

namespace Cilindro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cilindro cilindro = new Cilindro();
            cilindro.raio = 15.00;
            cilindro.altura = 15.00;
            cilindro.CalcularValor();
            Console.WriteLine("o volume de um cilindro com raio {0} e altura de {1} é de {2}", cilindro.raio.ToString(), cilindro.altura.ToString(), cilindro.volume.ToString("N2"));
            Console.ReadKey();
        }
    }
}
