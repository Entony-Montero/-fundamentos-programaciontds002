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

    static void MostrarMenu()
    {
        Console.WriteLine("\n===== LISTA DE TAREAS =====");
        Console.WriteLine("1. Agregar tarea");
        Console.WriteLine("2. Eliminar tarea");
        Console.WriteLine("3. Marcar tarea como hecha");
        Console.WriteLine("4. Listar tareas");
        Console.WriteLine("0. Salir");
    }

    static void AgregarTarea(List<string> tareas)
    {
        Console.Write("Escriba la tarea: ");
        string tarea = Console.ReadLine();

        tareas.Add("[ ] " + tarea);

        Console.WriteLine("Tarea agregada.");
    }

    static void EliminarTarea(List<string> tareas)
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
            return;
        }

        ListarTareas(tareas);

        int numero = LeerEntero("Ingrese el número de la tarea a eliminar: ");

        if (numero >= 1 && numero <= tareas.Count)
        {
            tareas.RemoveAt(numero - 1);
            Console.WriteLine("Tarea eliminada.");
        }
        else
        {
            Console.WriteLine("Número de tarea inválido.");
        }
    }

    static void MarcarComoHecha(List<string> tareas)
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas.");
            return;
        }

        ListarTareas(tareas);

        int numero = LeerEntero("Ingrese el número de la tarea realizada: ");

        if (numero >= 1 && numero <= tareas.Count)
        {
            if (tareas[numero - 1].StartsWith("[ ] "))
            {
                tareas[numero - 1] =
                    "[x] " + tareas[numero - 1].Substring(4);

                Console.WriteLine("Tarea marcada como hecha.");
            }
            else
            {
                Console.WriteLine("La tarea ya está marcada como hecha.");
            }
        }
        else
        {
            Console.WriteLine("Número de tarea inválido.");
        }
    }

    static void ListarTareas(List<string> tareas)
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas.");
            return;
        }

        Console.WriteLine("\n===== TAREAS =====");

        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }

    static void Main()
    {
        List<string> tareas = new List<string>();

        int opcion;

        do
        {
            MostrarMenu();
            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    AgregarTarea(tareas);
                    break;

                case 2:
                    EliminarTarea(tareas);
                    break;

                case 3:
                    MarcarComoHecha(tareas);
                    break;

                case 4:
                    ListarTareas(tareas);
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