using System;

namespace CeilsiusParaFahrenheit.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Temperatura temp = new Temperatura();
            temp.celsius= 0;
            Console.WriteLine("A temperatura de {0}º celsius convertida para fahrenheit resulta em {1}º", temp.celsius.ToString(), temp.CelsiusParaFahrenheit().ToString("N0"));
            Console.ReadKey();
        }
    }
}
