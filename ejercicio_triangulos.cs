using System;


class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Programa para identificar el tipo de triángulo");

        Console.Write("Ingrese el lado 1: ");

        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el lado 2: ");

        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el lado 3: ");

        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {

            Console.WriteLine("El triángulo es Equilátero");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)

        {
            Console.WriteLine("El triángulo es Isósceles");
        }
        else

        {
            Console.WriteLine("El triángulo es Escaleno");

        }
        Console.ReadKey();

    }

}
