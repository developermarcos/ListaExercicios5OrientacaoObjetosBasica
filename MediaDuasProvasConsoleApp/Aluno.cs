using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDuasProvasConsoleApp
{
    internal class Aluno
    {
        public string nome;
        public decimal prova1;
        public decimal prova2;

        public decimal CalculaMedia()
        {
            decimal result = (prova1 + prova2) / 2;
            return result;
        }
    }
}
