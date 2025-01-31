using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una frase de al menos 3 palabras:");
        string frase = Console.ReadLine();

        // Verificar que la frase tiene al menos 3 palabras
        string[] palabras = frase.Split(' ');
        if (palabras.Length < 3)
        {
            Console.WriteLine("La frase debe contener al menos 3 palabras.");
            return;
        }

        // Convertir cada palabra a minúscula con mayúscula inicial
        for (int i = 0; i < palabras.Length; i++)
        {
            palabras[i] = ConvertirPalabra(palabras[i]);
        }

        // Unir las palabras para formar la nueva frase
        string nuevaFrase = string.Join(" ", palabras);

        // Mostrar el resultado
        Console.WriteLine($"Frase original: {frase}");
        Console.WriteLine($"Frase modificada: {nuevaFrase}");
    }

    static string ConvertirPalabra(string palabra)
    {
        if (string.IsNullOrEmpty(palabra))
        {
            return palabra;
        }

        // Convertir la primera letra a mayúscula y el resto a minúscula
        return char.ToUpper(palabra[0]) + palabra.Substring(1).ToLower();
    }
}
