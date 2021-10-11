using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class NfBuilder
    {
        public decimal Valor { get; set; }
        public string Cpf { get; set; }

        private List<AcaoASerExecutada> acoes;

        public NfBuilder()
        {
            acoes = new List<AcaoASerExecutada>();
        }

        public void AddAcao(AcaoASerExecutada acao)
        {
            this.acoes.Add(acao);
        }

        public void RemoveAcao(AcaoASerExecutada acao)
        {
            this.acoes.Remove(acao);
        }



        public NfBuilder AdicionarValor(decimal valor)
        {
            this.Valor = valor;
            return this;
        }

        public NfBuilder AdicionarCpf(string cpf)
        {
            this.Cpf = cpf;
            return this;
        }

        public NotaFiscal Construir()
        {
           var nf = new NotaFiscal();
           nf.Cpf = this.Cpf;
           nf.ValorTotal = this.Valor;


           foreach (var acao in acoes)
           {
               acao.Execute(nf);
           }

           return nf;
        }



    }
}
