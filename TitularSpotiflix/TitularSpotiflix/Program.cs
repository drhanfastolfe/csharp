using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitularSpotiflix
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPersonas;
            string sIntroducirFichero, rutaFichero;

            Grupo g = new Grupo();

            Console.WriteLine("-- TITULAR SPOTIFLIX --\n");

            Console.WriteLine("-- Programa para a elegir el titular para Spotify " +
                "y Netflix. --\n");

            Console.WriteLine("- Normas -\n");

            Console.WriteLine("1- Puede haber un titular suscrito a las dos apps o " +
                "dos titulares cada uno suscrito a una app.\n");

            Console.WriteLine("2- Se eligirá al azar a una persona entre todas las suscritas. " +
                "Si está suscrito a ambas apps se convertirá en el nuevo titular.\n");

            Console.WriteLine("3- En el caso de que sólo esté suscrito a una se procederá " +
                "a elegir a una persona más que esté suscrito a la otra app.\n");

            Console.WriteLine("4- La segunda persona elegida podrá estar suscrito a ambas apps.\n");

            Console.WriteLine("5- No podrán ser titulares personas que ya lo hayan sido en el " +
                "pasado en el mismo ciclo (empiza un nuevo ciclo cuando todos han sido titulares).\n");

            Console.WriteLine("Presiona alguna tecla para continuar...\n");
            Console.ReadKey();

            Console.WriteLine("Vamos a añadir a las personas pertenecientes al grupo ¿" +
                "Quieres añadirlas mediante un fichero de texto? Responde: si/no.");
            sIntroducirFichero = Console.ReadLine();

            if (sIntroducirFichero.Equals("si"))
            {
                Console.WriteLine("\nIntroduce la ruta exacta de tu fichero de texto:");
                rutaFichero = Console.ReadLine();
                g.leeFicheroTexto(rutaFichero);
            }
            else
            {
                Console.WriteLine("\nHas elegido añadir manualmente ¿Cuántas personas hay " +
                    "en el grupo?");
                nPersonas = int.Parse(Console.ReadLine());

                AgregaPersonas(nPersonas, g);
            }

            Console.WriteLine("\n" + "- Lista de personas -\n\n" + g.ToString());

            Console.WriteLine("Presiona alguna tecla para empezar el sorteo...\n");
            Console.ReadKey();

            Console.WriteLine("- Sorteo - \n");

            Sorteo(g);

            Console.ReadKey();
        }

        public static void AgregaPersonas(int nPersonas, Grupo g)
        {
            int nSuscripcion;
            string nombre, sTitularPasado;
            Persona.App suscripcion;
            bool titularPasado;

            for (int i = 0; i < nPersonas; i++)
            {
                Console.WriteLine("\nIntroduce el nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("\nElige la suscripción, intruduce un númeri: 1. Spotify - 2. Netflix - 3. Ambas");
                nSuscripcion = int.Parse(Console.ReadLine());

                while (!(0 < nSuscripcion && nSuscripcion < 4))
                {
                    Console.WriteLine("\nERROR. Elige la suscripción, introduce un número: 1. Spotify - 2. Netflix - 3. Ambas");
                    nSuscripcion = int.Parse(Console.ReadLine());
                }

                if (nSuscripcion == 1)
                {
                    suscripcion = Persona.App.Spotify;
                }
                else
                {
                    if (nSuscripcion == 2)
                    {
                        suscripcion = Persona.App.Netflix;
                    }
                    else
                    {
                        suscripcion = Persona.App.Spotiflix;
                    }
                }

                Console.WriteLine("\n¿Esta persona ha sido titular alguna vez? Responde: si/no: ");
                sTitularPasado = Console.ReadLine();

                while (!sTitularPasado.Equals("si") && !sTitularPasado.Equals("no"))
                {
                    Console.WriteLine("\nERROR ¿Esta persona ha sido titular alguna vez? Responde: si/no: ");
                    sTitularPasado = Console.ReadLine();
                }

                if (sTitularPasado.Equals("si"))
                {
                    titularPasado = true;
                }
                else
                {
                    titularPasado = false;
                }

                g.insertaPersonaLista(nombre, suscripcion, titularPasado);
            }
        }

        public static void Sorteo(Grupo g)
        {
            Random r = new Random();

            int n1, n2;

            n1 = r.Next(0, g.ListaPersonas.Count);

            while (g.ListaPersonas[n1].TitularPasado)
            {
                n1 = r.Next(0, g.ListaPersonas.Count);
            }

            if (g.ListaPersonas[n1].Suscripcion == Persona.App.Spotiflix)
            {
                Console.WriteLine("El nuevo titular es: " + g.ListaPersonas[n1].Nombre + " para Spotify y Netflix");
            }
            else
            {
                n2 = r.Next(0, g.ListaPersonas.Count);
                while (g.ListaPersonas[n2].TitularPasado || g.ListaPersonas[n2].Suscripcion == g.ListaPersonas[n1].Suscripcion || n2 == n1)
                {
                    n2 = r.Next(0, g.ListaPersonas.Count);
                }

                Console.WriteLine("El nuevo titular para " + g.ListaPersonas[n1].Suscripcion + " es: " + g.ListaPersonas[n1].Nombre + "\n");

                if (g.ListaPersonas[n1].Suscripcion == Persona.App.Spotify)
                {
                    Console.WriteLine("El nuevo titular para Netflix es: " + g.ListaPersonas[n2].Nombre + "\n");
                }
                else
                {
                    Console.WriteLine("El nuevo titular para Spotify es: " + g.ListaPersonas[n2].Nombre + "\n");
                }
            }
        }
    }
}
