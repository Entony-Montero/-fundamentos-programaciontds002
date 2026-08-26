// Nombre: Entony Montero
// Matrícula: 20251803
// Proyecto Final: Inventario de Colmado

using System;
using System.Collections.Generic;

class Program
{
    static int LeerEntero(string mensaje)
    {
        int numero;

        while (true)
        {
            Console.Write(mensaje);

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }

            Console.WriteLine("Entrada inválida. Introduzca un número entero.");
        }
    }

    static string LeerTexto(string mensaje)
    {
        string texto;

        do
        {
            Console.Write(mensaje);
            texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("El texto no puede estar vacío.");
            }

        } while (string.IsNullOrWhiteSpace(texto));

        return texto;
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n================================");
        Console.WriteLine("       INVENTARIO DEL COLMADO");
        Console.WriteLine("================================");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Mostrar productos");
        Console.WriteLine("3. Buscar producto");
        Console.WriteLine("4. Vender producto");
        Console.WriteLine("5. Reponer producto");
        Console.WriteLine("6. Productos con poco stock");
        Console.WriteLine("0. Salir");
    }

    static void AgregarProducto(
        List<string> productos,
        List<int> cantidades,
        List<double> precios)
    {
        string nombre = LeerTexto("Nombre del producto: ");

        int cantidad = LeerEntero("Cantidad inicial: ");

        while (cantidad < 0)
        {
            Console.WriteLine("La cantidad no puede ser negativa.");
            cantidad = LeerEntero("Cantidad inicial: ");
        }

        double precio;

        while (true)
        {
            Console.Write("Precio del producto: ");

            if (double.TryParse(Console.ReadLine(), out precio) &&
                precio > 0)
            {
                break;
            }

            Console.WriteLine("El precio debe ser mayor que 0.");
        }

        productos.Add(nombre);
        cantidades.Add(cantidad);
        precios.Add(precio);

        Console.WriteLine("Producto agregado correctamente.");
    }

    static void MostrarProductos(
        List<string> productos,
        List<int> cantidades,
        List<double> precios)
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            return;
        }

        Console.WriteLine("\n========== INVENTARIO ==========");

        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {productos[i]} | " +
                $"Cantidad: {cantidades[i]} | " +
                $"Precio: RD$ {precios[i]:F2}");
        }
    }

    static int BuscarProducto(List<string> productos)
    {
        string nombre = LeerTexto("Nombre del producto a buscar: ");

        for (int i = 0; i < productos.Count; i++)
        {
            if (productos[i].Equals(
                nombre,
                StringComparison.OrdinalIgnoreCase))
            {
                return i;
            }
        }

        return -1;
    }

    static void MostrarProducto(
        List<string> productos,
        List<int> cantidades,
        List<double> precios)
    {
        int posicion = BuscarProducto(productos);

        if (posicion == -1)
        {
            Console.WriteLine("El producto no existe.");
            return;
        }

        Console.WriteLine("\nProducto encontrado:");
        Console.WriteLine($"Nombre: {productos[posicion]}");
        Console.WriteLine($"Cantidad: {cantidades[posicion]}");
        Console.WriteLine($"Precio: RD$ {precios[posicion]:F2}");
    }

    static void VenderProducto(
        List<string> productos,
        List<int> cantidades,
        List<double> precios)
    {
        int posicion = BuscarProducto(productos);

        if (posicion == -1)
        {
            Console.WriteLine("El producto no existe.");
            return;
        }

        int cantidad = LeerEntero("Cantidad a vender: ");

        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad debe ser mayor que 0.");
            return;
        }

        if (cantidad > cantidades[posicion])
        {
            Console.WriteLine("No hay suficiente inventario.");
            return;
        }

        cantidades[posicion] -= cantidad;

        double total = cantidad * precios[posicion];

        Console.WriteLine("Venta realizada correctamente.");
        Console.WriteLine($"Total de la venta: RD$ {total:F2}");
        Console.WriteLine(
            $"Stock restante: {cantidades[posicion]}");
    }

    static void ReponerProducto(
        List<string> productos,
        List<int> cantidades)
    {
        int posicion = BuscarProducto(productos);

        if (posicion == -1)
        {
            Console.WriteLine("El producto no existe.");
            return;
        }

        int cantidad = LeerEntero("Cantidad a agregar: ");

        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad debe ser mayor que 0.");
            return;
        }

        cantidades[posicion] += cantidad;

        Console.WriteLine("Inventario actualizado.");
        Console.WriteLine(
            $"Nuevo stock: {cantidades[posicion]}");
    }

    static void MostrarPocoStock(
        List<string> productos,
        List<int> cantidades)
    {
        int[] limites = { 5, 10, 15 };

        Console.WriteLine("\n===== PRODUCTOS CON POCO STOCK =====");

        bool encontrado = false;

        for (int i = 0; i < productos.Count; i++)
        {
            if (cantidades[i] <= limites[0])
            {
                Console.WriteLine(
                    $"{productos[i]} - Stock: {cantidades[i]}");

                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No hay productos con poco stock.");
        }
    }

    static void Main()
    {
        List<string> productos = new List<string>();
        List<int> cantidades = new List<int>();
        List<double> precios = new List<double>();

        int opcion;

        do
        {
            MostrarMenu();

            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    AgregarProducto(
                        productos,
                        cantidades,
                        precios);
                    break;

                case 2:
                    MostrarProductos(
                        productos,
                        cantidades,
                        precios);
                    break;

                case 3:
                    MostrarProducto(
                        productos,
                        cantidades,
                        precios);
                    break;

                case 4:
                    VenderProducto(
                        productos,
                        cantidades,
                        precios);
                    break;

                case 5:
                    ReponerProducto(
                        productos,
                        cantidades);
                    break;

                case 6:
                    MostrarPocoStock(
                        productos,
                        cantidades);
                    break;

                case 0:
                    Console.WriteLine(
                        "Gracias por utilizar el sistema.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}