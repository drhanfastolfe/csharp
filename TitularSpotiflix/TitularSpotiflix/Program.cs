using System;

namespace TitularSpotiflix
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPersonas, i;
            string nombre;
            bool titularPasado, titular;
            

            Grupo g = new Grupo();

            Console.WriteLine("-- TITULAR SPOTIFLIX --");
            Console.WriteLine();
            Console.WriteLine("-- Programa para a elegir el titular para Spotify " +
                "y Netflix. --");
            Console.WriteLine();
            Console.WriteLine("-Normas-");
            Console.WriteLine();
            Console.WriteLine("1- Puede haber un titular de suscrito a las dos apps o " +
                "dos titulares cada uno suscrito a una app.");
            Console.WriteLine();
            Console.WriteLine("2- Se eligirá al azar a una persona entre todas las suscritas. " +
                "Si está suscrito a ambas apps se convertirá en el nuevo titular. En el " +
                "caso de que sólo esté suscrito a una se procederá a elegir a una persona " +
                "más que esté suscrito a la otra app");
            Console.WriteLine();
            Console.WriteLine("3- En el caso de que sólo esté suscrito a una se procederá " +
                "a elegir a una persona más que esté suscrito a la otra app.");
            Console.WriteLine();
            Console.WriteLine("4- La segunda persona eleida podrá estar suscrito a ambas apps.");
            Console.WriteLine();
            Console.WriteLine("Presiona alguna tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Vamos a añadir a las personas pertenecientes al grupo ¿Cuántas " +
                "personas hay en el grupo?");
            nPersonas = int.Parse(Console.ReadLine());

            for(i = 0; i < nPersonas; i++)
            {
                Persona p = new Persona();
                nombre = stri


                g.insertaPersonaLista()
            }


            Console.ReadKey();
        }
    }
}
