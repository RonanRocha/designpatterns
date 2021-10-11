using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
   public class Icms : TemplateImpostoCondicinal
    {
        public override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.010M;
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
           return  orcamento.Valor >= 500;
        }
    }
}
