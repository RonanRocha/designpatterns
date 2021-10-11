using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class CalculadorFrete
    {
        public decimal ExecutarCalculo(Venda venda, Frete frete)
        {
            return frete.Calcula(venda);
        }
    }
}
