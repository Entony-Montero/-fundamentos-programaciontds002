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

    static int Sumar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    static void Main()
    {
        Console.WriteLine("===== ENTRADA BLINDADA =====");

        int numero1 = LeerEntero("Ingrese el primer número: ");
        int numero2 = LeerEntero("Ingrese el segundo número: ");

        int resultado = Sumar(numero1, numero2);

        Console.WriteLine($"La suma es: {resultado}");
    }
}