// Nombre: Entony
// Matrícula: 20251803

using System;

class Program
{
    static void ImprimirLinea(char c, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(c);
        }

        Console.WriteLine();
    }

    static void ImprimirTitulo(string t)
    {
        int longitud = t.Length + 4;

        ImprimirLinea('=', longitud);
        Console.WriteLine("= " + t + " =");
        ImprimirLinea('=', longitud);
    }

    static void Main()
    {
        ImprimirTitulo("METODOS EN C#");
    }
}