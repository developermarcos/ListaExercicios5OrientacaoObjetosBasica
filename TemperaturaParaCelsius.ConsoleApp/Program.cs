using System;

namespace TemperaturaParaCelsius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Temperatura temperatura1 = new Temperatura();
            temperatura1.fahrenheit = 15;
            temperatura1.ConverterTemperatura();
            Console.WriteLine("{0} fahrenheit para celsius {1}", temperatura1.fahrenheit.ToString(), temperatura1.conversao.ToString("N2"));
            Console.ReadKey();
        }
    }
}
