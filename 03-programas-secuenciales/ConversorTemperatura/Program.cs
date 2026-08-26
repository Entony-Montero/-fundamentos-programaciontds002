// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Ingrese la temperatura en grados Celsius: ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;
double kelvin = celsius + 273.15;

Console.WriteLine("\n--- Conversión de temperatura ---");

Console.WriteLine($"Celsius: {celsius:F2} °C");
Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
Console.WriteLine($"Kelvin: {kelvin:F2} K");
