using System;
using DesignPatterns.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
    [TestClass]
    public class TemplateMethodTest
    {
        [TestMethod]
        public void Calcular_IcmsQuandoOrcamentoForMaiorOuIgual500_DeveRetornar10Porcento()
        {
           
            var orc = new Orcamento();
            orc.Valor = 500;
            var icms = new Icms();
            var taxa =  icms.Calcular(orc);
            Assert.AreEqual(orc.Valor *  0.010M,taxa);
            
        }

        [TestMethod]
        public void Calcular_IcmsQuandoOrcamentoForMenor500_DeveRetornar06Porcento()
        {
            var orc = new Orcamento();
            orc.Valor = 400;
            var icms = new Icms();
            var taxa = icms.Calcular(orc);
            Assert.AreEqual(orc.Valor * 0.06M, taxa);

        }

        [TestMethod]
        public void Calcular_PisQuandoOrcamentoForMenor300_DeveRetornar05Porcento()
        {
            var orc = new Orcamento();
            orc.Valor = 200;
            var pis = new Pis();
            var taxa = pis.Calcular(orc);
            Assert.AreEqual(orc.Valor * 0.05M, taxa);
        }

        [TestMethod]
        public void Calcular_PisQuandoOrcamentoForMaiorOuIgual300_DeveRetornar08Porcento()
        {

            var orc = new Orcamento();
            orc.Valor = 500;
            var pis = new Pis();
            var taxa = pis.Calcular(orc);
            Assert.AreEqual(orc.Valor * 0.08M, taxa);

        }

        [TestMethod]
        public void Calcular_IcmsQuandoOrcamentoFor0_DeveRetornar0()
        {

            var orc = new Orcamento();
            orc.Valor = 0;

            var icms = new Icms();
            var taxa = icms.Calcular(orc);
            Assert.AreEqual(0, taxa);

        }

        [TestMethod]
        public void Calcular_PisQuandoOrcamentoFor0_DeveRetornar0()
        {

            var orc = new Orcamento();
            orc.Valor = 0;

            var pis = new Pis();
            var taxa = pis.Calcular(orc);
            Assert.AreEqual(0, taxa);

        }

        [TestMethod]
        public void Calcular_PisQuandoValorOrcamentoForNulo_DeveRetornar0()
        {

            var orc = new Orcamento();

            var pis = new Pis();
            var taxa = pis.Calcular(orc);
            Assert.AreEqual(0, taxa);

        }

        [TestMethod]
        public void Calcular_IcmsQuandoValorOrcamentoForNulo_DeveRetornar0()
        {

            var orc = new Orcamento();

            var icms = new Icms();
            var taxa = icms.Calcular(orc);
            Assert.AreEqual(0, taxa);

        }


    }
}
