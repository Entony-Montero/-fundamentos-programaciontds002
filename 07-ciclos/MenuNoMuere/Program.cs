// Nombre: Entony Montero
// Matrícula: 20251803

int opcion;

do
{
    Console.WriteLine("\n==============================");
    Console.WriteLine("       MENÚ PRINCIPAL");
    Console.WriteLine("==============================");
    Console.WriteLine("1. Sumar dos números");
    Console.WriteLine("2. Ver si un número es primo");
    Console.WriteLine("3. Salir");
    Console.WriteLine("==============================");

    Console.Write("Seleccione una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;

            Console.WriteLine($"Resultado: {suma}");
            break;

        case 2:
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 2)
            {
                Console.WriteLine($"{numero} no es primo.");
            }
            else
            {
                bool esPrimo = true;
                int divisor = 2;

                while (divisor <= Math.Sqrt(numero))
                {
                    if (numero % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                    divisor++;
                }

                if (esPrimo)
                {
                    Console.WriteLine($"{numero} es primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} no es primo.");
                }
            }

            break;

        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 3);