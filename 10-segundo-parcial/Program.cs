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

    static void ConsultarSaldo(decimal saldo)
    {
        Console.WriteLine($"Saldo disponible: RD$ {saldo:N2}");
    }

    static decimal Depositar(decimal saldo)
    {
        int monto = LeerEntero("Ingrese el monto a depositar: ");

        if (monto <= 0)
        {
            Console.WriteLine("El monto debe ser mayor que 0.");
            return saldo;
        }

        saldo += monto;

        Console.WriteLine($"Depósito realizado. Nuevo saldo: RD$ {saldo:N2}");

        return saldo;
    }

    static decimal Retirar(decimal saldo)
    {
        int monto = LeerEntero("Ingrese el monto a retirar: ");

        if (monto <= 0 || monto % 100 != 0)
        {
            Console.WriteLine("El retiro debe ser un múltiplo de 100.");
            return saldo;
        }

        if (monto > saldo)
        {
            Console.WriteLine("Fondos insuficientes.");
            return saldo;
        }

        saldo -= monto;

        Console.WriteLine($"Retiro realizado. Nuevo saldo: RD$ {saldo:N2}");

        return saldo;
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n===== CAJERO AUTOMÁTICO =====");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Depositar");
        Console.WriteLine("3. Retirar");
        Console.WriteLine("0. Salir");
    }

    static bool ValidarPin()
    {
        const int pinCorrecto = 1234;
        int intentos = 0;

        while (intentos < 3)
        {
            int pin = LeerEntero("Ingrese su PIN: ");

            if (pin == pinCorrecto)
            {
                Console.WriteLine("PIN correcto.");
                return true;
            }

            intentos++;
            Console.WriteLine($"PIN incorrecto. Intentos restantes: {3 - intentos}");
        }

        Console.WriteLine("Ha superado el máximo de intentos.");
        return false;
    }

    static void Main()
    {
        decimal saldo = 10000;

        if (!ValidarPin())
        {
            return;
        }

        int opcion;

        do
        {
            MostrarMenu();
            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    ConsultarSaldo(saldo);
                    break;

                case 2:
                    saldo = Depositar(saldo);
                    break;

                case 3:
                    saldo = Retirar(saldo);
                    break;

                case 0:
                    Console.WriteLine("Gracias por utilizar el cajero.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}