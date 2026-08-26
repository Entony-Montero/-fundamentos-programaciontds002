// Nombre: Entony Montero
// Matrícula: 20251803

using System;

class Program
{
    static void MostrarMenu()
    {
        Console.WriteLine("\n===== MENÚ =====");
        Console.WriteLine("1. Contar del 1 al 10");
        Console.WriteLine("2. Mostrar números pares");
        Console.WriteLine("3. Mostrar números impares");
        Console.WriteLine("4. Tabla de multiplicar");
        Console.WriteLine("0. Salir");
    }

    static void Opcion1()
    {
        Console.WriteLine("\nNúmeros del 1 al 10:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void Opcion2()
    {
        Console.WriteLine("\nNúmeros pares del 1 al 20:");

        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void Opcion3()
    {
        Console.WriteLine("\nNúmeros impares del 1 al 20:");

        for (int i = 1; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void Opcion4()
    {
        int numero = LeerEntero("Ingrese un número: ");

        Console.WriteLine($"\nTabla del {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

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
        int opcion;

        do
        {
            MostrarMenu();
            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1: Opcion1(); break;
                case 2: Opcion2(); break;
                case 3: Opcion3(); break;
                case 4: Opcion4(); break;
                case 0: Console.WriteLine("Programa finalizado."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }

        } while (opcion != 0);
    }
}