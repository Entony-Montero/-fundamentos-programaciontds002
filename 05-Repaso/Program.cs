// Nombre: Entony Montero
// Matrícula: 20251803

Console.Write("Ingrese la distancia del viaje en kilómetros: ");
double distanciaKm = double.Parse(Console.ReadLine());

Console.Write("Ingrese el consumo del vehículo (km por galón): ");
double consumoKmGalon = double.Parse(Console.ReadLine());

Console.Write("Ingrese el precio del galón: ");
double precioGalon = double.Parse(Console.ReadLine());

Console.Write("Ingrese el número de pasajeros: ");
int pasajeros = int.Parse(Console.ReadLine());

// Cálculo de galones necesarios
double galonesNecesarios = distanciaKm / consumoKmGalon;

// Cálculo del costo total
double costoTotal = galonesNecesarios * precioGalon;

// Cálculo de cuánto paga cada pasajero
double costoPorPasajero = costoTotal / pasajeros;

Console.WriteLine("\n=================================");
Console.WriteLine("       CALCULADORA DE VIAJE");
Console.WriteLine("=================================");

Console.WriteLine($"Distancia: {distanciaKm:F2} km");
Console.WriteLine($"Consumo: {consumoKmGalon:F2} km/galón");
Console.WriteLine($"Precio del galón: {precioGalon:C}");
Console.WriteLine($"Pasajeros: {pasajeros}");
Console.WriteLine($"Galones necesarios: {galonesNecesarios:F2}");
Console.WriteLine("---------------------------------");
Console.WriteLine($"Costo total: {costoTotal:C}");
Console.WriteLine($"Pago por pasajero: {costoPorPasajero:C}");
Console.WriteLine("=================================");
