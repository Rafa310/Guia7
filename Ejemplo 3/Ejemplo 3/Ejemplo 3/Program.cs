using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            Double X, Y, sen, cos, tan, r4, pot, ver;
            do
            {
                Console.WriteLine("\t\t\t\t\tMenú\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t\t\tElija que desea hacer: ");
                Console.WriteLine("\t\t\t[S] Seno de x\t");
                Console.WriteLine("\t\t\t[C] Coseno de X \t");
                Console.WriteLine("\t\t\t[T] Tangente de X\t");
                Console.WriteLine("\t\t\t[R] Raiz cuadrada de X\t");
                Console.WriteLine("\t\t\t[P] Potencia de Y^x\t");
                Console.WriteLine("\t\t\t[I] Verificar si un número es par o impar\t");
                Console.WriteLine("\t\t\t[Esc] Salir del programa");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\tSeleccione una opción...");
                op = Console.ReadKey(true);
                Console.Clear();
                switch (op.Key)
                {
                    case ConsoleKey.S:
                        Console.WriteLine("Usted seleccionó obtener el Seno de X [[Presione Enter]]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese X");
                        X = Double.Parse(Console.ReadLine());
                        sen = Math.Sin(X);
                        Console.WriteLine("El seno del número " + X + " es: " + sen);
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("Usted seleccionó obtener el Coseno de X [[Presione Enter]]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese X");
                        X = Double.Parse(Console.ReadLine());
                        cos = Math.Cos(X);
                        Console.WriteLine("El coseno del número " + X + " es: " + cos);
                        break;
                    case ConsoleKey.T:
                        Console.WriteLine("Usted seleccionó obtener la Tangente de X [[Presione Enter]]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Por favor digite X");
                        X = Double.Parse(Console.ReadLine());
                        tan = Math.Tan(X);
                        Console.WriteLine("La tangente de " + X + " es: " + tan);
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("Usted decidió buscar la raíz cuadrada de X [[Presione Enter]]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese X");
                        X = Double.Parse(Console.ReadLine());
                        r4 = Math.Sqrt(X);
                        Console.WriteLine("La raíz cuadrada de " + X + " es: " + r4);
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("Usted seleccionó saber el valor de Y elevado a X [[Presione Enter]]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese la base (Y)");
                        Y = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Por favor ingrese el exponente (X)");
                        X = Double.Parse(Console.ReadLine());
                        pot = Math.Pow(Y, X);
                        Console.WriteLine("El valor de " + Y + " elevado en " + X + " es de: " + pot);
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine("Usted decidió averiguar si el número X es par o impar [[Presione Enter]]");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese X");
                        X = Double.Parse(Console.ReadLine());
                        if (X % 2 == 0)
                            Console.WriteLine("El número " + X + " es par.");
                        else
                            Console.WriteLine("El número " + X + " es impar.");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Au revoir!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (op.Key != ConsoleKey.Escape);
        }
    }
}
