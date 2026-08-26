// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Ingrese la nota del estudiante (0-100): ");
double nota = double.Parse(Console.ReadLine());

if (nota < 0 || nota > 100)
{
    Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
}
else
{
    char letra;

    if (nota >= 90)
    {
        letra = 'A';
    }
    else if (nota >= 80)
    {
        letra = 'B';
    }
    else if (nota >= 70)
    {
        letra = 'C';
    }
    else
    {
        letra = 'F';
    }

    string resultado = nota >= 70 ? "Aprobó" : "No aprobó";

    Console.WriteLine("\n--- Resultado ---");
    Console.WriteLine($"Nota: {nota:F2}");
    Console.WriteLine($"Calificación: {letra}");
    Console.WriteLine($"Estado: {resultado}");
}
