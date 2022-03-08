using System;

namespace VolumeLata.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Lata latinha = new Lata();
            latinha.raio = 3.00;
            latinha.altura = 3.00;
            latinha.CalcularVolume();
            Console.WriteLine("o volume de um cilindro com raio {0} e altura de {1} é de {2}", latinha.raio.ToString(), latinha.altura.ToString(), latinha.volume.ToString("N2"));
            Console.ReadKey();
        }
    }
}
