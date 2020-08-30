using System;

namespace TresEnRaya
{
    class Program
    {
        static void Main(string[] args)
        {
            int modo;

            Console.WriteLine
            (
                "Selecciona el modo de juego: \n" +
                "\n" +
                "1- Jugador (X) vs Jugador (O)\n" +
                "2- Jugador (X) vs IA (O)\n" +
                "3- IA (X) vs Jugador (O)\n"
            );
            modo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (modo)
            {
                case 1: jugadorVsJugador(); break;
                //case 2: jugadorVsIA(); break;
                //case 3: IAvsJugador();  break;
            }

            Console.ReadKey();
        }

        public static void jugadorVsJugador()
        {
            Tablero t = new Tablero();
            string nombre1, nombre2;

            Console.WriteLine("Las Tres en Raya: Jugador vs Jugador\n");
            
            Console.Write("Jugador 1, introduce tu nombre: ");
            nombre1 = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Jugador 2, introduce tu nombre: ");
            nombre2 = Console.ReadLine();

            Console.WriteLine();

            t.dibujaTablero();

            while (t.quedanMovimientos() && !t.ganaJugador1() && !t.ganaJugador2())
            {
                Console.Write("Mueve " + nombre1 + ": \n");

                t.dibujaTablero();
            }









        }
    }
}
