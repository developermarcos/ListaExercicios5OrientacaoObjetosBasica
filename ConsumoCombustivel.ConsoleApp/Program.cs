using System;

namespace ConsumoCombustivel.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Consumo ConsumoDoKauan = new Consumo();

            ConsumoDoKauan.QuilometragemInicial = 500;
            ConsumoDoKauan.QuilometragemFinal = 1000;
            ConsumoDoKauan.CombustivelLitrosInicial = 50;
            ConsumoDoKauan.CombustivelLitrosFinal= 10;

            decimal resultado = ConsumoDoKauan.CalculaMedia();

            Console.WriteLine("Rodou {0} quilometros e utilizou {1} litros que resultou no consumo de {2}", (ConsumoDoKauan.QuilometragemFinal - ConsumoDoKauan.QuilometragemInicial).ToString(), (ConsumoDoKauan.CombustivelLitrosInicial - ConsumoDoKauan.CombustivelLitrosFinal).ToString(), ConsumoDoKauan.CalculaMedia().ToString("N2"));
            Console.ReadKey();
        }
    }
}
