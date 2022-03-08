using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaHarmonica.ConsoleApp
{
    internal class Aluno
    {
        public string nome;
        public decimal nota1;
        public decimal nota2;
        public decimal nota3;
        public decimal nota4;

        public decimal CalcularMediaHarmonica()
        {
            decimal result = 4 / ((1/nota1) + (1/nota2) + (1/nota3) + (1/nota4));
            return result;
        }
    }
}
