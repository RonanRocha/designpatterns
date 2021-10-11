using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public  class Historico
    {

        public ArrayList Estados { get; set; }

        public Historico()
        {
            Estados = new ArrayList();
        }

        public void AdicionaEstado(Estado estado)
        {
            this.Estados.Add(estado);
        }

        public Estado PegaEstado(int index)
        {
            return (Estado) Estados[index];
        }
    }
}
