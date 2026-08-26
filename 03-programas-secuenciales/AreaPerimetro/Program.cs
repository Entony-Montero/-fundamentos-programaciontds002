// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Ingrese el radio del círculo: ");
double radio = double.Parse(Console.ReadLine());

Console.Write("Ingrese el largo del rectángulo: ");
double largo = double.Parse(Console.ReadLine());

Console.Write("Ingrese el ancho del rectángulo: ");
double ancho = double.Parse(Console.ReadLine());

// Cálculos del círculo
double areaCirculo = Math.PI * Math.Pow(radio, 2);
double perimetroCirculo = 2 * Math.PI * radio;

// Cálculos del rectángulo
double areaRectangulo = largo * ancho;
double perimetroRectangulo = 2 * (largo + ancho);

Console.WriteLine("\n--- Círculo ---");
Console.WriteLine($"Área: {areaCirculo:F2}");
Console.WriteLine($"Perímetro: {perimetroCirculo:F2}");

Console.WriteLine("\n--- Rectángulo ---");
Console.WriteLine($"Área: {areaRectangulo:F2}");
Console.WriteLine($"Perímetro: {perimetroRectangulo:F2}");
