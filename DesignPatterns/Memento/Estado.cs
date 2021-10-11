using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Estado
    {
        public Contrato contrato { get; private set; }

        public Estado(Contrato contrato)
        {
            this.contrato = contrato;
        }

        

    }
}
