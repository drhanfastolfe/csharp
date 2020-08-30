using System;

namespace Probando
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, tam;

            Console.WriteLine("Introduce el tamaño del triangulo: ");
            tam = int.Parse(Console.ReadLine());

            while (tam % 2 != 1)
            {
                Console.WriteLine("El tamaño tiene que ser impar: ");
                tam = int.Parse(Console.ReadLine());
            }
            k = 1;

            for (i = 0; i < tam/2+1; i++)
            {   
                for (j = 0; j < tam/2-i; j++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j < k; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
                
                k = k + 2;
            }

            Console.ReadKey();
        }
    }
}

