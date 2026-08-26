// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Ingrese las horas trabajadas: ");
double horasTrabajadas = double.Parse(Console.ReadLine());

Console.Write("Ingrese la tarifa por hora: ");
double tarifaHora = double.Parse(Console.ReadLine());

// Cálculo del salario bruto
double salarioBruto = horasTrabajadas * tarifaHora;

// Cálculo de descuentos
double afp = salarioBruto * 0.0287;
double sfs = salarioBruto * 0.0304;

// Cálculo del salario neto
double salarioNeto = salarioBruto - afp - sfs;

Console.WriteLine("\n================================");
Console.WriteLine("          NÓMINA SIMPLE");
Console.WriteLine("================================");

Console.WriteLine($"{"Horas trabajadas:",-25}{horasTrabajadas,10:F2}");
Console.WriteLine($"{"Tarifa por hora:",-25}{tarifaHora,10:C}");
Console.WriteLine("--------------------------------");

Console.WriteLine($"{"Salario bruto:",-25}{salarioBruto,10:C}");
Console.WriteLine($"{"AFP (2.87%):",-25}{afp,10:C}");
Console.WriteLine($"{"SFS (3.04%):",-25}{sfs,10:C}");
Console.WriteLine("--------------------------------");
Console.WriteLine($"{"Salario neto:",-25}{salarioNeto,10:C}");

Console.WriteLine("================================");
