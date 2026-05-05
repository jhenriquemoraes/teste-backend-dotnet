using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static List<int> Gerar(int x)
        {
            var resultado = new List<int>();

            int primeiro = 0, segundo = 1;

            for (int i = 0; i < x; i++)
            {
                resultado.Add(primeiro);
                int proximo = primeiro + segundo;
                primeiro = segundo;
                segundo = proximo;
            }

            return resultado;
        }
    }
}
