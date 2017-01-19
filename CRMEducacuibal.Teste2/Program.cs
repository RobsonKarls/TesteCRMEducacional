using System;
using CRMEducacuibal.Teste2.Core;

namespace CRMEducacuibal.Teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            MostraNumeroDeReinicios();
            LerFibobatatas();
        }

        private static void LerFibobatatas()
        {
            Console.WriteLine("Olá, entre com o número inteiro de Batatas: ");

            int n = PegaNumeroBatatas(Console.ReadLine());

            var fb = new Fibobatatas();

            var results = fb.CalculaReinicios(n);

            int numeroReinicializacoes = results.Count;

            Console.WriteLine("Resultado do Calculo: ...");
            Console.WriteLine("O total de reinicios é de " + numeroReinicializacoes);

            int reinicios = 1;

            foreach (var result in results)
            {
                Console.WriteLine("Reinicio #" + reinicios);

                result.ForEach(Console.WriteLine);
                Console.WriteLine("\b");

                reinicios++;
            }
            Console.ReadLine();
        }
        private static int PegaNumeroBatatas(string numero)
        {
            int numeroBatatas = 0;
            try
            {
                numeroBatatas = int.Parse(numero);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Eu disse um número inteiro...");
                Console.WriteLine("Por favor, tente novamente, insira um número inteiro: ");

                numeroBatatas = int.Parse(Console.ReadLine());
            }

            return numeroBatatas;
        }
        private static void MostraNumeroDeReinicios()
        {
            var cn = new CalculaMaiorNumero();

            var maiorNumeroReinicio = cn.PegaNumeroComMaisReinicios(500);

            Console.WriteLine("O número que requer maior quantidade de reinicios é " + maiorNumeroReinicio.NumeroBatatas);
            Console.WriteLine("E a quantidade de reinicios é de " + maiorNumeroReinicio.NumeroReinicios);
            Console.WriteLine("\b");
        }
    }
}
