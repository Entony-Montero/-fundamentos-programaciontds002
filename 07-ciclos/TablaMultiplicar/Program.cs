// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"\n--- Tabla del {numero} ---");

for (int i = 1; i <= 12; i++)
{
    int resultado = numero * i;

    Console.WriteLine($"{numero} x {i} = {resultado}");
}