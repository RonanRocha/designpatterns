using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Sp : Frete
    {
        public decimal Calcula(Venda venda)
        {
            return venda.ValorTotal * 0.05M;
        }
    }
}
