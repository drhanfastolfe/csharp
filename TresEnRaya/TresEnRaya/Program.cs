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
            int mueve1, mueve2;

            Console.WriteLine("Las Tres en Raya: Jugador vs Jugador\n");
            
            Console.Write("Jugador 1, introduce tu nombre: ");
            nombre1 = Console.ReadLine();

            Console.Write("\nJugador 2, introduce tu nombre: ");
            nombre2 = Console.ReadLine();

            Console.WriteLine();

            t.dibujaTablero();

            while (t.quedanMovimientos() && !t.ganaJugador1() && !t.ganaJugador2())
            {
                Console.Write("\nMueve " + nombre1 + ": \n");
                mueve1 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                t.mueveJugador1(mueve1);
                t.dibujaTablero();

                if (t.ganaJugador1())
                {
                    Console.WriteLine("\nFin de la partida: GANA " + nombre1);
                }
                else
                { 
                    if (t.empate())
                    {
                        Console.WriteLine("\nFin de la partida: EMPATE");
                    }
                    else
                    {
                        Console.Write("\nMueve " + nombre2 + ": \n");
                        mueve2 = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        t.mueveJugador2(mueve2);
                        t.dibujaTablero();

                        if (t.ganaJugador2())
                        {
                            Console.WriteLine("\nFin de la partida: GANA " + nombre2);
                        }
                    }
                }
            }









        }
    }
}
