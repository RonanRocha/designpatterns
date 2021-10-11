using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
   public class Pis : TemplateImpostoCondicinal
    {
        public override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05M;
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08M;
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 300;
        }
    }
}
