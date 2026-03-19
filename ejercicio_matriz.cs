// desarrollar una matriz que cree la siguiente imagen (una x con ceros) en la x que se forma en la matriz se debe crear círculos rellenos de verde.
using System;
class Program
{
    static void Main()
    {
        int n;
        Console.Write("Ingrese el tamaño de la matriz: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j || i + j == n - 1)
                {
                   Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("0 ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("1 ");
                }
            }
            Console.WriteLine();
        }

        Console.ResetColor();
        Console.ReadKey();
    }
}


