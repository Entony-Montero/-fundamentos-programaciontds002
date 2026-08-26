// Nombre: Entony Montero
// Matrícula: 20251803

Console.WriteLine("=================================");
Console.WriteLine("       MENÚ DE CAFETERÍA");
Console.WriteLine("=================================");

Console.WriteLine("1. Café          - $100");
Console.WriteLine("2. Sándwich      - $250");
Console.WriteLine("3. Jugo natural  - $150");
Console.WriteLine("4. Empanada      - $100");
Console.WriteLine("5. Refresco      - $100");
Console.WriteLine("=================================");

Console.Write("Seleccione una opción (1-5): ");
int opcion = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad: ");
int cantidad = int.Parse(Console.ReadLine());

double precio = 0;
string producto = "";

switch (opcion)
{
    case 1:
        producto = "Café";
        precio = 100;
        break;

    case 2:
        producto = "Sándwich";
        precio = 250;
        break;

    case 3:
        producto = "Jugo natural";
        precio = 150;
        break;

    case 4:
        producto = "Empanada";
        precio = 100;
        break;

    case 5:
        producto = "Refresco";
        precio = 100;
        break;

    default:
        Console.WriteLine("Error: opción inválida.");
        return;
}

double total = precio * cantidad;

Console.WriteLine("\n--- Compra ---");
Console.WriteLine($"Producto: {producto}");
Console.WriteLine($"Precio: {precio:C}");
Console.WriteLine($"Cantidad: {cantidad}");
Console.WriteLine($"Total: {total:C}");
