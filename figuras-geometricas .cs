using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU DE EJERCICIOS =====");
            Console.WriteLine("1. Cuadrado hueco");
            Console.WriteLine("2. Triangulo invertido");
            Console.WriteLine("3. Piramide centrada");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion) { 

            }
                Console.WriteLine(" cuadrado hueco");

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

            Console.WriteLine("Triangulo invertido");

        for (int fila = 5; fila >= 1; fila--)
        {
            for (int columna = 0; columna < fila; columna++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

               Console.WriteLine("Piramide centrada");
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
