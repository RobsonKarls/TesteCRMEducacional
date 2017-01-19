using System.Linq;
using System.Collections.Generic;

using CRMEducacuibal.Teste2.Models;

namespace CRMEducacuibal.Teste2.Core
{
    public class CalculaMaiorNumero
    {
        public Resultado PegaNumeroComMaisReinicios(int n)
        {
            var fb = new Fibobatatas();
            var resultado = new List<Resultado>();

            for (int i = 0; n > i; i++)
            {
                var r = fb.CalculaReinicios(i);
                resultado.Add(new Resultado
                {
                    NumeroBatatas = i,
                    NumeroReinicios = r.Count
                });
            }

            var orderedList = resultado.OrderByDescending(x => x.NumeroReinicios);

            return orderedList.FirstOrDefault();
        }
    }
}
