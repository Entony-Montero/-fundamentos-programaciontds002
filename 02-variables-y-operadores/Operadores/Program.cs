// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Ingrese el primer número entero: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número entero: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("\n--- Operaciones aritméticas ---");

Console.WriteLine($"Suma: {numero1 + numero2}");
Console.WriteLine($"Resta: {numero1 - numero2}");
Console.WriteLine($"Multiplicación: {numero1 * numero2}");
Console.WriteLine($"División entera: {numero1 / numero2}");

double divisionReal = (double)numero1 / numero2;
Console.WriteLine($"División real: {divisionReal}");

Console.WriteLine($"Módulo: {numero1 % numero2}");

Console.WriteLine("\n--- Comparaciones relacionales ---");

Console.WriteLine($"{numero1} > {numero2}: {numero1 > numero2}");
Console.WriteLine($"{numero1} == {numero2}: {numero1 == numero2}");
Console.WriteLine($"{numero1} != {numero2}: {numero1 != numero2}");

Console.WriteLine("\n--- Operaciones lógicas ---");

Console.WriteLine($"¿Ambos son positivos? {numero1 > 0 && numero2 > 0}");
Console.WriteLine($"¿Al menos uno es positivo? {numero1 > 0 || numero2 > 0}");
