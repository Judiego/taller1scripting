using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena: ");
        string cadena = Console.ReadLine();

        if (EsPalindroma(cadena))
        {
            Console.WriteLine("La cadena es palíndroma.");
        }
        else
        {
            Console.WriteLine("La cadena no es palíndroma.");
        }
    }

    static bool EsPalindroma(string cadena)
    {
        // Eliminar espacios y convertir todo a minúsculas para hacer la comparación
        cadena = cadena.Replace(" ", "").ToLower();

        int longitud = cadena.Length;

        // comparar caracteres desde ambos extremos hacia el centro
        for (int i = 0; i < longitud / 2; i++)
        {
            // Comparar el carácter actual con su correspondiente simétrico alrededor del centro
            if (cadena[i] != cadena[longitud - 1 - i])
            {
                return false; // La cadena no es palíndroma
            }
        }

        return true; // La cadena es palíndroma
    }
}
