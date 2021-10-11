using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class NfImpressao : AcaoASerExecutada
    {
        public void Execute(NotaFiscal nota)
        {
            Console.WriteLine("imprimiu a nota");
        }
    }
}
