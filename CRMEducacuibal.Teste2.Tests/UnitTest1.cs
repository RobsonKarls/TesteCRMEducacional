using CRMEducacuibal.Teste2.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRMEducacuibal.Teste2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void numero_de_reinicio_deve_ser_2_iterando_com_11_batatas()
        {
            var fibobatatas = new Fibobatatas();

            var reinicios1 = fibobatatas.CalculaReinicios(1);
            var reinicios11 = fibobatatas.CalculaReinicios(11);
            var reinicios3 = fibobatatas.CalculaReinicios(3);

            Assert.AreEqual(1, reinicios1.Count);
            Assert.AreEqual(2, reinicios3.Count);
            Assert.AreEqual(2, reinicios11.Count);
        }

        [TestMethod]
        public void deve_calcular_sequencia_fibonacci()
        {
            var fibobatatas = new Fibobatatas();

            Assert.AreEqual(1, fibobatatas.Fibonacci(2));
            Assert.AreEqual(5, fibobatatas.Fibonacci(5));
            Assert.AreEqual(8, fibobatatas.Fibonacci(6));
            Assert.AreEqual(13, fibobatatas.Fibonacci(7));
        }

        [TestMethod]
        public void testa_metodo_que_retorna_menor_numero_de_reinicio()
        {
            var pn = new CalculaMaiorNumero();

            var resultado = pn.PegaNumeroComMaisReinicios(500);

        }

    }
}
