using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int sumaImpares = 0;
        int numeroActual = 1; // primer número impar
        Console.Write("Ingrese un número entero para n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            // Calcular la suma 
            do
            {
                sumaImpares += numeroActual;
                numeroActual += 2; // Pasar al siguiente número impar
                contador++;
            } while (contador < n);

            Console.WriteLine($"La suma de los primeros {n} números impares es: {sumaImpares}");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo válido para n.");//mensaje de error para n 
        }
    }
}
