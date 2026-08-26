// Nombre: Entony Montero
// Matrícula: 20251803

using System;

class Program
{
    static int LeerEntero(string mensaje)
    {
        int numero;

        while (true)
        {
            Console.Write(mensaje);

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }

            Console.WriteLine("Entrada inválida. Debe escribir un número entero.");
        }
    }

    static void Main()
    {
        double[] notas = new double[10];

        for (int i = 0; i < notas.Length; i++)
        {
            while (true)
            {
                Console.Write($"Ingrese la nota {i + 1}: ");

                if (double.TryParse(Console.ReadLine(), out notas[i]) &&
                    notas[i] >= 0 && notas[i] <= 100)
                {
                    break;
                }

                Console.WriteLine("Nota inválida. Introduzca un valor entre 0 y 100.");
            }
        }

        double suma = 0;
        double mayor = notas[0];
        double menor = notas[0];

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];

            if (notas[i] > mayor)
            {
                mayor = notas[i];
            }

            if (notas[i] < menor)
            {
                menor = notas[i];
            }
        }

        double promedio = suma / notas.Length;

        int porEncima = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > promedio)
            {
                porEncima++;
            }
        }

        Console.WriteLine("\n===== ESTADÍSTICAS =====");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Mayor: {mayor:F2}");
        Console.WriteLine($"Menor: {menor:F2}");
        Console.WriteLine($"Notas por encima del promedio: {porEncima}");
    }
}