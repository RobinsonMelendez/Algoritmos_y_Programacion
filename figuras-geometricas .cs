using System;

class Program
{
    static void Main()
    { 

        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                if (fila == 0 || fila == 4 ||
                    columna == 0 || columna == 4)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();

      

        for (int fila = 5; fila >= 1; fila--)
        {
            for (int columna = 0; columna < fila; columna++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();


        for (int fila = 1; fila <= 5; fila++)
        {
            for (int espacio = 0; espacio < 5 - fila; espacio++)
            {
                Console.Write(" ");
            }

            for (int estrella = 0; estrella < 2 * fila - 1; estrella++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
