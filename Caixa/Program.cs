using System;

namespace Caixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Caixa caixa1 = new Caixa();
            caixa1.altura = 3;
            caixa1.largura = 4;
            caixa1.comprimento = 4;
            caixa1.CalcularVolume();
            Console.WriteLine("Volume do retangulo é {0}", caixa1.area);
            Console.ReadKey();
        }
    }
}
