using System;

public class Palindromo
{
    public static bool EhPalindromo(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
            return false;

        int esquerda = 0;
        int direita = texto.Length - 1;

        while (esquerda < direita)
        {
            while (esquerda < direita && !char.IsLetterOrDigit(texto[esquerda]))
                esquerda++;

            while (esquerda < direita && !char.IsLetterOrDigit(texto[direita]))
                direita--;

            char c1 = char.ToLower(texto[esquerda]);
            char c2 = char.ToLower(texto[direita]);

            if (c1 != c2)
                return false;

            esquerda++;
            direita--;
        }

        return true;
    }
}
