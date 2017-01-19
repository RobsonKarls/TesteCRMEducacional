using CRMEducacuibal.Teste1.Interfaces;

namespace CRMEducacuibal.Teste1.Core
{
    public class BinarySearch : IBinarySearch
    {
        public int Metodo(int entrada, int[] vetor)
        {
            var direita = 0;
            var esquerda = vetor.Length;

            return ExecuteBinarySearch(entrada, vetor, direita, esquerda);            
        }

        private int ExecuteBinarySearch(int entrada, int[] vetor, int esquerda, int direita)
        {
            while(esquerda <= direita)
            {
                int meio = (esquerda + direita) / 2;

                if (vetor[meio] == entrada)
                    return meio;
                else if (vetor[meio] > entrada)
                    direita = meio - 1;
                else if (vetor[meio] < entrada)
                    esquerda = meio + 1;
            }

            return -1;   
        }

    }
}
