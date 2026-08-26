// Nombre: Entony Montero
// Matrícula: 20251803

using System;
using System.Collections.Generic;

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

    static void ProgramaConArreglo()
    {
        int cantidad = LeerEntero("¿Cuántos nombres desea guardar? ");

        string[] nombres = new string[cantidad];

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Ingrese el nombre {i + 1}: ");
            nombres[i] = Console.ReadLine();
        }

        Console.WriteLine("\nNombres guardados con arreglo:");

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]}");
        }
    }

    static void ProgramaConLista()
    {
        int cantidad = LeerEntero("¿Cuántos nombres desea guardar? ");

        List<string> nombres = new List<string>();

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el nombre {i + 1}: ");
            nombres.Add(Console.ReadLine());
        }

        Console.WriteLine("\nNombres guardados con lista:");

        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]}");
        }
    }

    static void Main()
    {
        Console.WriteLine("===== ARREGLO VS LISTA =====");

        ProgramaConArreglo();

        Console.WriteLine("\n----------------------------\n");

        ProgramaConLista();
    }
}

/*
Diferencia:

En el arreglo se debe indicar su tamaño al momento de crearlo:
string[] nombres = new string[cantidad];

En la lista no es necesario establecer un tamaño fijo:
List<string> nombres = new List<string>();

La lista puede crecer dinámicamente cuando usamos Add(), por lo que
podemos agregar nuevos elementos sin tener que crear otra lista con
un tamaño diferente. El arreglo, en cambio, tiene un tamaño fijo
después de ser creado.
*/