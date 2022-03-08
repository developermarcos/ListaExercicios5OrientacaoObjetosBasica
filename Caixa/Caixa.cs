using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa
{
    internal class Caixa
    {
        public int largura;
        public int altura;
        public int comprimento;
        public int area;

        public void CalcularVolume()
        {
            area = largura * altura * comprimento;
        }
    }
}
