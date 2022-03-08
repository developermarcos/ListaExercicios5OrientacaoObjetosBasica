using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioVendedor.ConsoleApp
{
    internal class Vendedor
    {
        public string nome;
        public decimal salarioBase;
        public decimal totalVendas;
        public decimal percentual;

        public decimal Comissao()
        {
            decimal comissao = salarioBase + (totalVendas * percentual / 100);
            return comissao;
        }
    }
}
