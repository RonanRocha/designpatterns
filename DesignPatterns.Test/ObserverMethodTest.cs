using System;
using DesignPatterns.Observer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
    [TestClass]
    public class ObserverMethodTest
    {
        [TestMethod]
        public void TestMethod1()
        {

     
           var nfb = new NfBuilder().AdicionarCpf("38847789869").AdicionarValor(300);
           nfb.AddAcao(new NfEmail());
           nfb.AddAcao(new NfSms());
           nfb.AddAcao(new NfImpressao());

           

           var nf = nfb.Construir(); 
        }
    }
}
