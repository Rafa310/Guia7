using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2, numpar = 0, porc, i;
            
            Console.WriteLine("Ingrese dos números diferentes, le diremos cuantos números pares hay del primero al segundo.");
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Double.Parse(Console.ReadLine());
            if (num1 > num2) 
            {
                Console.WriteLine("El primer valor debe ser menor.");
            }
            if(num1==num2)
            {
                Console.WriteLine("Los números deben ser diferentes.");
            }
            while (num2>num1)
            {
                Console.WriteLine("Los números par son los siguientes: ");
                for (i=num1;i-num2!=0;i=i+1)
                {
                    if (i%2==0)
                    {
                        
                        Console.WriteLine(i);
                    }
                }
                num1 = num1 + 1;
                break;
            }
            
            
        }
    }
}
