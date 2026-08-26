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

    static double LeerNota(string mensaje)
    {
        double nota;

        while (true)
        {
            Console.Write(mensaje);

            if (double.TryParse(Console.ReadLine(), out nota) &&
                nota >= 0 && nota <= 100)
            {
                return nota;
            }

            Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n===== REGISTRO DE ESTUDIANTES =====");
        Console.WriteLine("1. Agregar estudiante");
        Console.WriteLine("2. Buscar estudiante");
        Console.WriteLine("3. Ver promedio del grupo");
        Console.WriteLine("4. Mostrar aprobados");
        Console.WriteLine("0. Salir");
    }

    static void AgregarEstudiante(
        List<string> nombres,
        List<double> notas)
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        double nota = LeerNota("Ingrese la nota: ");

        nombres.Add(nombre);
        notas.Add(nota);

        Console.WriteLine("Estudiante agregado correctamente.");
    }

    static void BuscarEstudiante(
        List<string> nombres,
        List<double> notas)
    {
        Console.Write("Ingrese el nombre que desea buscar: ");
        string nombreBuscado = Console.ReadLine();

        for (int i = 0; i < nombres.Count; i++)
        {
            if (nombres[i].Equals(
                nombreBuscado,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Estudiante: {nombres[i]}");
                Console.WriteLine($"Nota: {notas[i]:F2}");
                return;
            }
        }

        Console.WriteLine("El estudiante no existe.");
    }

    static void MostrarPromedio(List<double> notas)
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
            return;
        }

        double suma = 0;

        for (int i = 0; i < notas.Count; i++)
        {
            suma += notas[i];
        }

        double promedio = suma / notas.Count;

        Console.WriteLine($"Promedio del grupo: {promedio:F2}");
    }

    static void MostrarAprobados(
        List<string> nombres,
        List<double> notas)
    {
        bool hayAprobados = false;

        Console.WriteLine("\n===== ESTUDIANTES APROBADOS =====");

        for (int i = 0; i < nombres.Count; i++)
        {
            if (notas[i] >= 70)
            {
                Console.WriteLine(
                    $"{nombres[i]} - {notas[i]:F2}");

                hayAprobados = true;
            }
        }

        if (!hayAprobados)
        {
            Console.WriteLine("No hay estudiantes aprobados.");
        }
    }

    static void Main()
    {
        List<string> nombres = new List<string>();
        List<double> notas = new List<double>();

        int opcion;

        do
        {
            MostrarMenu();

            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    AgregarEstudiante(nombres, notas);
                    break;

                case 2:
                    BuscarEstudiante(nombres, notas);
                    break;

                case 3:
                    MostrarPromedio(notas);
                    break;

                case 4:
                    MostrarAprobados(nombres, notas);
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}