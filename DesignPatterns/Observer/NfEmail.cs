using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
   public  class NfEmail : AcaoASerExecutada
    {
        public void Execute(NotaFiscal nota)
        {
            Console.WriteLine("Enviou por e-mail");
        }
    }
}
