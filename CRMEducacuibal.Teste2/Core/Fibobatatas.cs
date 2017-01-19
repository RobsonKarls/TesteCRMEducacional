using System.Collections.Generic;

namespace CRMEducacuibal.Teste2.Core
{
    public class Fibobatatas
    {
        public List<List<int>> CalculaReinicios(int batatas)
        {
            int numeroReinicios = 0;
            int somaFibonacci = 0;
            List<List<int>> reinicios = new List<List<int>>();
            int numeroFibonacci = 0;

            reinicios.Add(new List<int>());

            for (int i = 1; batatas >= somaFibonacci; i++)
            {
                numeroFibonacci = Fibonacci(i);
                somaFibonacci = somaFibonacci + numeroFibonacci;
                reinicios[numeroReinicios].Add(numeroFibonacci);
                batatas = batatas - numeroFibonacci;

                if (batatas == 0)
                {
                    break;
                }

                //reinicia
                if (batatas < somaFibonacci)
                {
                    reinicios.Add(new List<int>());
                    somaFibonacci = 0;
                    i = 0;
                    numeroReinicios++;
                }
            }

            return reinicios;
        }

        /// <summary>
        /// retorna o numero da posicao na sequencia fibonacci
        /// </summary>
        /// <param name="i">posição da sequencia fibonacci</param>
        /// <returns>retorna numero de uma posicao na sequencia fibonacci </returns>
        public int Fibonacci(int i)
        {
            if (i == 0)
                return 0;
            if (i <= 2)
                return 1;

           return Fibonacci(i - 1) + Fibonacci(i - 2);
        }
    }
}
