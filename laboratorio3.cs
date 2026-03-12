// 3 Menú de Servicios
using System;

class Program
{
    static void Main()
    {
        int opcion;
        Console.WriteLine("1. Consulta");
        Console.WriteLine("2. Laboratorio");
        Console.WriteLine("3. Rayos X");
        Console.WriteLine("4. Farmacia");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opcion: ");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Consulta");
                Console.WriteLine("Precio: 50000");
                Console.WriteLine("Tiempo de espera: 20 minutos");
                break;
            case 2:
                Console.WriteLine("Laboratorio");
                Console.WriteLine("Precio: 80000");
                Console.WriteLine("Tiempo de espera: 30 minutos");
                break;
            case 3:
                Console.WriteLine("Rayos X");
                Console.WriteLine("Precio: 120000");
                Console.WriteLine("Tiempo de espera: 40 minutos");
                break;
            case 4:
                Console.WriteLine("Farmacia");
                Console.WriteLine("Tiempo de espera: 10 minutos");
                break;
            case 5:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        Console.ReadLine();
    }
}
