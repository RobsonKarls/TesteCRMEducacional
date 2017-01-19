using CRMEducacuibal.Teste1.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRMEducacuibal.Teste1.Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Assume que o vetor de entrada esteja sempre de forma ordenada crescente
        /// </summary>234567890-
        [TestMethod]
        public void deve_retornar_indice_2_procurando_pela_entrada_3()
        {
            int[] vetor = { 1, 2, 3, 4, 5 };

            var binarySearch = new BinarySearch();

            Assert.AreEqual(2, binarySearch.Metodo(3, vetor));
        }

        /// <summary>
        /// Assume que o vetor de entrada esteja sempre de forma ordenada crescente
        /// </summary>
        [TestMethod]
        public void deve_retornar_indice_14_procurando_pela_entrada_1000()
        {
            int[] vetor = { 1, 2, 3, 4, 5,6,10,11,12,25,85,100,200,555,1000,9999,99998,100000078 };

            var binarySearch = new BinarySearch();

            Assert.AreEqual(14, binarySearch.Metodo(1000, vetor));
        }

        /// <summary>
        /// Assume que o vetor de entrada esteja sempre de forma ordenada crescente
        /// </summary>
        [TestMethod]
        public void deve_retornar_um_negativo_para_valor_que_nao_consta_no_array()
        {
            int[] vetor = { 1, 2, 3, 4, 5, 6, 10, 11, 12, 25, 85, 100, 200, 555, 1000, 9999, 99998, 100000078 };

            var binarySearch = new BinarySearch();

            Assert.AreEqual(-1, binarySearch.Metodo(9, vetor));
        }
    }
}
