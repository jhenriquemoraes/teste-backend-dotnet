using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Normalizar
{
    public class Normalizar
    {
        public static string Normalizar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            var resultado = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == '!' || texto[i] == '?')
                {
                    bool temExclamacao = false;
                    bool temInterrogacao = false;

                    int j = i;

                    for (; j < texto.Length && (texto[j] == '!' || texto[j] == '?'); j++)
                    {
                        if (texto[j] == '!') temExclamacao = true;
                        if (texto[j] == '?') temInterrogacao = true;
                    }

                    if (temExclamacao && temInterrogacao)
                        resultado.Append("?!");
                    else if (temInterrogacao)
                        resultado.Append("?");
                    else
                        resultado.Append("!");

                    i = j - 1;
                }
                else
                {
                    resultado.Append(texto[i]);
                }
            }

            return resultado.ToString();
        }

    }
}