using System;

class Program
{
    static void Main()
    {
        int turno;
        string continuar = "S";

        while (continuar == "S" || continuar == "s")
        {
            Console.Write("Ingrese el número de turno: ");
            turno = int.Parse(Console.ReadLine());

            while (turno <= 0)
            {
                Console.Write("Error, ingrese un número mayor a 0: ");
                turno = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Turno registrado: " + turno);

            Console.Write("¿Desea continuar? (S/N): ");
            continuar = Console.ReadLine();
        }

        Console.WriteLine("Fin del programa");
        Console.ReadKey();
    }
}
