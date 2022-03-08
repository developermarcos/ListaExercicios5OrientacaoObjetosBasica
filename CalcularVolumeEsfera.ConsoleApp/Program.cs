using System;

namespace CalcularVolumeEsfera.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Esfera esfera= new Esfera();
            esfera.raio = 3;
            Console.WriteLine("o volume de uma esfera com raio {0} é de {1}", esfera.raio.ToString(), esfera.CalcularVolume().ToString("N2"));
            Console.ReadKey();
        }
    }
}
