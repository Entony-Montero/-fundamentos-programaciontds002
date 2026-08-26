// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Ingrese su estatura: ");
double estatura = double.Parse(Console.ReadLine());

Console.Write("Ingrese un número decimal (float): ");
float numeroFloat = float.Parse(Console.ReadLine());

Console.Write("Ingrese la inicial de su apellido: ");
char inicialApellido = char.Parse(Console.ReadLine());

Console.Write("¿Es estudiante activo? (true/false): ");
bool estudianteActivo = bool.Parse(Console.ReadLine());

Console.WriteLine("\n--- Datos registrados ---");

Console.WriteLine(
    $"Nombre: {nombre} | Edad: {edad} | Estatura: {estatura} | Float: {numeroFloat} | Inicial: {inicialApellido} | Estudiante activo: {estudianteActivo}"
);
