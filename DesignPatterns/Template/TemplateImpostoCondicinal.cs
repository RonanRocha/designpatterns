using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public abstract class TemplateImpostoCondicinal : Imposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }

        public abstract decimal MinimaTaxacao(Orcamento orcamento);
        public abstract decimal MaximaTaxacao(Orcamento orcamento);
        public abstract bool  DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
