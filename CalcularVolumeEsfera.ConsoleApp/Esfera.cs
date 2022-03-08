using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularVolumeEsfera.ConsoleApp
{
    internal class Esfera
    {
        //raio, valorpi 
        public double raio;
        private double valorPI;

        public Esfera()
        {
            valorPI = 3.14159265359;
        }

        public double CalcularVolume()
        {
            //Volume = 4.p.r³/ 3
            double volume = (4 * valorPI * (raio * raio * raio)) / 3;
            return volume;
        }
    }
}
