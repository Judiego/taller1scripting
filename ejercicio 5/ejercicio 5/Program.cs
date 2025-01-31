using System;

class Program
{
    static void Main()
    {
        int numero;
        int resultado; 

        Console.Write("Ingrese un número de máximo 8 cifras: ");
        if (int.TryParse(Console.ReadLine(), out numero) && numero >= 0 && numero <= 99999999)
        {
            resultado = ObtenerValorUnico(numero);
            Console.WriteLine($"El valor obtenido es: {resultado}");
        }
        else
        {
            Console.WriteLine("Ingrese un número válido de máximo 8 cifras.");
        }
    }

    static int ObtenerValorUnico(int numero)
    {
        int sumaDigitos;
        while (numero >= 10)
        {
            sumaDigitos = 0;

            // Extraer cada dígito y sumarlos
            while (numero > 0)
            {
                sumaDigitos += numero % 10;
                numero /= 10;
            }

            numero = sumaDigitos;
        }

        return numero;
    }
}
