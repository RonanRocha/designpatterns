using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Contrato
    {
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public StatusContrato Status { get; set; }


        public void Avanca()
        {
            if(Status == StatusContrato.NOVO)
            {
                Status = StatusContrato.EM_ANDAMENTO;
            }else if (Status == StatusContrato.EM_ANDAMENTO)
            {
                Status = StatusContrato.ACERTADO;
            }
            else if (Status == StatusContrato.ACERTADO)
            {
                Status = StatusContrato.CONCLUIDO;
            }
        }

        public Estado SalvaEstado()
        {
            var c = new Contrato();
            c.Status = this.Status;
            c.Data = this.Data;
            c.Cliente = this.Cliente;
            return  new Estado(c);
            
        }
    }
}
