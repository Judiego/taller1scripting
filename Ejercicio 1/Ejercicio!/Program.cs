using System;

class Program
{
    static void Main()
    {
        float sumaPositivos = 0;
        int cantidadPositivos = 0;
        float promedioPositivos=0;

        Console.Write("Ingrese la longitud del array: ");
        if (int.TryParse(Console.ReadLine(), out int longitud) && longitud > 0)
        {
            float[] numeros = new float[longitud];

            // Pedir al usuario que ingrese los números
            for (int i = 0; i < longitud; i++)
            {
                Console.Write($"Ingrese el número en la posición {i + 1}: ");
                if (float.TryParse(Console.ReadLine(), out float numero))
                {
                    numeros[i] = numero;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    i--; // Disminuir i para repetir la misma posición del array
                }
            }  // Calcular el promedio de los números positivos
            for (int i = 0; i < longitud; i++)
            {
                if (numeros[i] > 0)
                {
                    sumaPositivos += numeros[i];
                    cantidadPositivos++;
                }
            }

            // Mostrar el resultado
            if (cantidadPositivos > 0)
            {
                promedioPositivos = sumaPositivos / cantidadPositivos;
                Console.WriteLine($"El promedio de los números positivos es: {promedioPositivos}");
            }
            else
            {
                Console.WriteLine("No hay números positivos en el array.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese una longitud válida para el array.");
        }
    }
}
