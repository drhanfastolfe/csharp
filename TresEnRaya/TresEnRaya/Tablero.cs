using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TresEnRaya
{
    class Tablero
    {
        private int[] tab;

        public Tablero()
        {
            this.tab = new int[9];
        }

        public void mueveJugador1(int pos)
        {
            pos = corrigePosicion(pos);

            if(movimientoValido(pos))
            {

                this.tab[pos] = 1;
            }
            else
            {
                throw new Exception("Movimiento no válido.");
            }
        }

        public void mueveJugador2(int pos)
        {
            pos = corrigePosicion(pos);

            if (movimientoValido(pos))
            {
                this.tab[pos] = 2;
            }
            else
            {
                throw new Exception("Movimiento no válido.");
            }
        }

        private bool movimientoValido(int pos)
        {
            bool resultado;
            
            if(this.tab[pos] == 0)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        public void mueveOrdenador1()
        {
            Random r = new Random();

            int pos = r.Next(1, 10);

            while(!movimientoValido(pos))
            {
                pos = r.Next(1, 10);
            }

            this.tab[pos - 1] = 1;
        }

        public void mueveOrdenador2()
        {
            Random r = new Random();

            int pos = r.Next(1, 10);

            while(!movimientoValido(pos))
            {
                pos = r.Next(1, 10);
            }

            this.tab[pos - 1] = 2;
        }

        public void iniciar()
        {
            int i;

            for(i = 0; i < 9; i++)
            {
                this.tab[i] = 0;
            }
        }

        public bool quedanMovimientos()
        {
            bool resultado;

            int i = 0;

            while(i < 9 && this.tab[i] != 0)
            {
                i++;
            }
            if(i == 9)
            {
                resultado = false;
            }
            else
            {
                resultado = true;
            }

            return resultado;
        }

        public bool ganaJugador1()
        {
            bool resultado = false;

            int i, j, k, linea;

            linea = 0;

            i = 0;

            for(i = 0; i < 3; i++)
            {
                linea = 0;
                for(j = i; j < i+7; j += 3)
                {
                    if(this.tab[j] == 1)
                    {
                        linea++;
                    }
                    if(linea == 3)
                    {
                        resultado = true;
                        break;
                    }
                }
            }
           
            if(!resultado)
            {
                linea = 0;
                for (i = 0; i < 9; i = i + 3)
                {
                    linea = 0;
                    for (j = i; j < i + 3; j++)
                    {
                        if (this.tab[j] == 1)
                        {
                            linea++;
                        }
                        if (linea == 3)
                        {
                            resultado = true;
                            break;
                        }
                    }
                }
            }
            
            if(!resultado)
            {
                linea = 0;
                for(i = 0; i < 9; i = i + 4)
                {
                    if(this.tab[i] == 1)
                    {
                        linea++;
                    }
                    if(linea == 3)
                    {
                        resultado = true;
                        break;
                    }
                }
            }

            if(!resultado)
            {
                linea = 0;
                for(i = 2; i < 7; i = i + 2)
                {
                    if (this.tab[i] == 1)
                    {
                        linea++;
                    }
                    if (linea == 3)
                    {
                        resultado = true;
                        break;
                    }
                }
            }

            return resultado;
        }

        public bool ganaJugador2()
        {
            bool resultado = false;

            int i, j, k, linea;

            linea = 0;

            i = 0;

            for (i = 0; i < 3; i++)
            {
                linea = 0;
                for (j = i; j < i + 7; j = j + 3)
                {
                    if (this.tab[j] == 2)
                    {
                        linea++;
                    }
                    if (linea == 3)
                    {
                        resultado = true;
                        break;
                    }
                }
            }

            if (!resultado)
            {
                linea = 0;
                for (i = 0; i < 9; i = i + 3)
                {
                    linea = 0;
                    for (j = i; j < i + 3; j++)
                    {
                        if (this.tab[j] == 2)
                        {
                            linea++;
                        }
                        if (linea == 3)
                        {
                            resultado = true;
                            break;
                        }
                    }
                }
            }

            if (!resultado)
            {
                linea = 0;
                for (i = 0; i < 9; i = i + 4)
                {
                    if (this.tab[i] == 2)
                    {
                        linea++;
                    }
                    if (linea == 3)
                    {
                        resultado = true;
                        break;
                    }
                }
            }

            if (!resultado)
            {
                linea = 0;
                for (i = 2; i < 7; i = i + 2)
                {
                    if (this.tab[i] == 2)
                    {
                        linea++;
                    }
                    if (linea == 3)
                    {
                        resultado = true;
                        break;
                    }
                }
            }

            return resultado;
        }

        public void dibujaTablero()
        {
            Console.WriteLine(xUo(this.tab[0]) + "|" + xUo(this.tab[1]) + "|" + xUo(this.tab[2]));
            Console.WriteLine("-----------");
            Console.WriteLine(xUo(this.tab[3]) + "|" + xUo(this.tab[4]) + "|" + xUo(this.tab[5]));
            Console.WriteLine("-----------");
            Console.WriteLine(xUo(this.tab[6]) + "|" + xUo(this.tab[7]) + "|" + xUo(this.tab[8]));
        }

        private string xUo(int valor)
        {
            string sValor;

            if(valor == 0)
            {
                sValor = "   ";
            }
            else
            {
                if(valor == 1)
                {
                    sValor = " X ";
                }
                else
                {
                    sValor = " O ";
                }
            }

            return sValor;
        }

        public bool empate()
        {
            bool resultado;

            if(!ganaJugador1() && !ganaJugador2() && !quedanMovimientos())
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

        private int corrigePosicion(int pos)
        {
            pos = pos - 1;

            if(pos==0)
            {
                pos = 6;
            }
            else
            {
                if (pos == 1)
                {
                    pos = 7;
                }
                else
                {
                    if (pos == 2)
                    {
                        pos = 8;
                    }
                    else
                    {
                        if (pos == 6)
                        {
                            pos = 0;
                        }
                        else
                        {
                            if (pos == 7)
                            {
                                pos = 1;
                            }
                            else
                            {
                                if (pos == 8)
                                {
                                    pos = 2;
                                }
                            }
                        }
                    }
                }
            }

            return pos;
        }

        
    }
}
