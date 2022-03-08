using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoCombustivel.ConsoleApp
{
    internal class Consumo
    {
        //atributo
        public decimal QuilometragemInicial;
        public decimal QuilometragemFinal;
        public decimal CombustivelLitrosInicial;
        public decimal CombustivelLitrosFinal;
        

        public decimal CalculaMedia()
        {
            decimal quilometragemPercorrida = QuilometragemFinal - QuilometragemInicial;
            decimal litrosUtilizados = CombustivelLitrosInicial - CombustivelLitrosFinal;

            return quilometragemPercorrida / litrosUtilizados;
        }

    }
}
