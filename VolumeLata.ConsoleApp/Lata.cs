using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeLata.ConsoleApp
{
    internal class Lata
    {
        public double raio;
        public double altura;
        public double volume;
        public double pi;

        public Lata()
        {
            pi = 3.14159265359;
        }
        public void CalcularVolume()
        {
            //V = Ab.h ou V = π.r2.h
            volume = pi * (raio * raio) * altura;
        }
    }
}
