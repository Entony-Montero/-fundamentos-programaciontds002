// Nombre: Entony Montero
// Matrícula: 20251803

static int Factorial(int numero)
{
    int resultado = 1;

    for (int i = 1; i <= numero; i++)
    {
        resultado *= i;
    }

    return resultado;
}

static bool EsPrimo(int numero)
{
    if (numero < 2)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
        {
            return false;
        }
    }

    return true;
}

static int Mcd(int a, int b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);

    while (b != 0)
    {
        int residuo = a % b;
        a = b;
        b = residuo;
    }

    return a;
}

static double Potencia(double baseNumero, int exponente)
{
    double resultado = 1;

    for (int i = 0; i < Math.Abs(exponente); i++)
    {
        resultado *= baseNumero;
    }

    if (exponente < 0)
    {
        resultado = 1 / resultado;
    }

    return resultado;
}

int opcion;

do
{
    Console.WriteLine("\n==============================");
    Console.WriteLine("    BIBLIOTECA MATEMÁTICA");
    Console.WriteLine("==============================");
    Console.WriteLine("1. Factorial");
    Console.WriteLine("2. Saber si es primo");
    Console.WriteLine("3. Máximo común divisor");
    Console.WriteLine("4. Potencia");
    Console.WriteLine("5. Salir");
    Console.WriteLine("==============================");

    Console.Write("Seleccione una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese un número entero: ");
            int numeroFactorial = int.Parse(Console.ReadLine());

            if (numeroFactorial < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
            }
            else
            {
                Console.WriteLine(
                    $"Factorial de {numeroFactorial}: {Factorial(numeroFactorial)}"
                );
            }

            break;

        case 2:
            Console.Write("Ingrese un número entero: ");
            int numeroPrimo = int.Parse(Console.ReadLine());

            if (EsPrimo(numeroPrimo))
            {
                Console.WriteLine($"{numeroPrimo} es primo.");
            }
            else
            {
                Console.WriteLine($"{numeroPrimo} no es primo.");
            }

            break;

        case 3:
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"MCD: {Mcd(numero1, numero2)}");

            break;

        case 4:
            Console.Write("Ingrese la base: ");
            double baseNumero = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el exponente entero: ");
            int exponente = int.Parse(Console.ReadLine());

            Console.WriteLine(
                $"Resultado: {Potencia(baseNumero, exponente):F2}"
            );

            break;

        case 5:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 5);
