using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite un número entre el 1 y el 15.");
            Double num;
            num = Double.Parse(Console.ReadLine());
            
            while (num!=0)
            {
                Console.Write("*");
                
                if (num < 0 || num > 15)
                {
                    Console.WriteLine("Valor introducido no valido...");
                    break;
                }
                num = num - 1;
            }
            Console.ReadKey();
        }
    }
}
