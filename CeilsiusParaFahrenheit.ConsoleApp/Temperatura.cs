using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeilsiusParaFahrenheit.ConsoleApp
{
    internal class Temperatura
    {
        public double celsius;
        private double fatorConversao1;
        private double fatorConversao2;

        public Temperatura()
        {
            fatorConversao1 = 30;
            fatorConversao2 = 1.8;
        }

        public double CelsiusParaFahrenheit()
        {
            double valorConvertido = fatorConversao2 * celsius + fatorConversao1;
            return valorConvertido;
        }
    }
}
