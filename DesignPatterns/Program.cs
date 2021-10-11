using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.Strategy;
using DesignPatterns.Template;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {


            var c = new Contrato();
            c.Cliente = "Ronan Rocha";
            c.Data = DateTime.Now;
            c.Status = StatusContrato.NOVO;

            var h = new Historico();

            h.AdicionaEstado(c.SalvaEstado());

            c.Avanca();
            h.AdicionaEstado(c.SalvaEstado());

            c.Avanca();
            h.AdicionaEstado(c.SalvaEstado());

            Console.WriteLine(c.Status);







        }
    }
}
