using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaParaCelsius.ConsoleApp
{
    internal class Temperatura
    {
        public double fahrenheit;
        private double fatorConversao;
        public double conversao;

        public Temperatura()
        {
            fatorConversao = 30;
        }
        public void ConverterTemperatura()
        {
            conversao = (fahrenheit - 32) / 1.8000;
        }
    }
}
