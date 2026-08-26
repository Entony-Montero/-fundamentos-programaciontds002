// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Nombre del cliente: ");
string cliente = Console.ReadLine();

Console.WriteLine("\n--- Producto 1 ---");
Console.Write("Nombre: ");
string producto1 = Console.ReadLine();

Console.Write("Precio: ");
double precio1 = double.Parse(Console.ReadLine());

Console.Write("Cantidad: ");
int cantidad1 = int.Parse(Console.ReadLine());

Console.WriteLine("\n--- Producto 2 ---");
Console.Write("Nombre: ");
string producto2 = Console.ReadLine();

Console.Write("Precio: ");
double precio2 = double.Parse(Console.ReadLine());

Console.Write("Cantidad: ");
int cantidad2 = int.Parse(Console.ReadLine());

Console.WriteLine("\n--- Producto 3 ---");
Console.Write("Nombre: ");
string producto3 = Console.ReadLine();

Console.Write("Precio: ");
double precio3 = double.Parse(Console.ReadLine());

Console.Write("Cantidad: ");
int cantidad3 = int.Parse(Console.ReadLine());

// Cálculo del subtotal de cada producto
double totalProducto1 = precio1 * cantidad1;
double totalProducto2 = precio2 * cantidad2;
double totalProducto3 = precio3 * cantidad3;

// Cálculos de la factura
double subtotal = totalProducto1 + totalProducto2 + totalProducto3;
double itbis = subtotal * 0.18;
double total = subtotal + itbis;

// Factura
Console.WriteLine("\n==============================================");
Console.WriteLine("              FACTURA DE COLMADO");
Console.WriteLine("==============================================");
Console.WriteLine($"Cliente: {cliente}");
Console.WriteLine("----------------------------------------------");

Console.WriteLine(
    $"{"Producto",-20}{"Precio",10}{"Cant.",8}{"Total",12}"
);

Console.WriteLine(
    $"{producto1,-20}{precio1,10:C}{cantidad1,8}{totalProducto1,12:C}"
);

Console.WriteLine(
    $"{producto2,-20}{precio2,10:C}{cantidad2,8}{totalProducto2,12:C}"
);

Console.WriteLine(
    $"{producto3,-20}{precio3,10:C}{cantidad3,8}{totalProducto3,12:C}"
);

Console.WriteLine("----------------------------------------------");
Console.WriteLine($"{"Subtotal:",-30}{subtotal,12:C}");
Console.WriteLine($"{"ITBIS (18%):",-30}{itbis,12:C}");
Console.WriteLine($"{"TOTAL:",-30}{total,12:C}");
Console.WriteLine("==============================================");
