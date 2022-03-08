using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro.ConsoleApp
{
    internal class Cilindro
    {
        public double raio;
        public double altura;
        public double volume;
        public double pi;

        public Cilindro()
        {
            pi = 3.14159265359;
        }
        public void CalcularValor()
        {
            //V = Ab.h ou V = π.r2.h
            volume = pi * (raio * raio) * altura;
        }
    }
}
