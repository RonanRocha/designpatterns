using System;
using DesignPatterns.Strategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
    [TestClass]
    public class StrategyMethodTest
    {
        [TestMethod]
        public void CalcularFrete_VendaParaSaoPaulo_DeveRetornar05Porcento()
        {

            var v = new Venda();
            v.ValorTotal = 250;

            var sp = new Sp();

            var c = new CalculadorFrete();
            var frete  = c.ExecutarCalculo(v, sp);

            Assert.AreEqual(v.ValorTotal * 0.05M, frete);
        }

        [TestMethod]
        public void CalcularFrete_VendaZeradaParaSaoPaulo_DeveRetornar0()
        {

            var v = new Venda();

            var sp = new Sp();

            var c = new CalculadorFrete();
            var frete = c.ExecutarCalculo(v, sp);

            Assert.AreEqual(0, frete);
        }

        [TestMethod]
        public void CalcularFrete_VendaParaRioDeJaneiro_DeveRetornar07Porcento()
        {

            var v = new Venda();
            v.ValorTotal = 250;

            var rj = new Rj();

            var c = new CalculadorFrete();
            var frete = c.ExecutarCalculo(v, rj);

            Assert.AreEqual(v.ValorTotal * 0.07M, frete);
        }

        [TestMethod]
        public void CalcularFrete_VendaZeradaParaRioDeJaneiro_DeveRetornar0()
        {

            var v = new Venda();

            var rj = new Rj();

            var c = new CalculadorFrete();
            var frete = c.ExecutarCalculo(v, rj);

            Assert.AreEqual(0, frete);
        }

    }
}
