using System;
using System.Collections.Generic;
using System.Text;

namespace Intro
{
    class Coche
    {
        private string matricula;
        private string marca;
        private string modelo;
        private bool nuevo;
        private int plazas;
        private double precio;

        public Coche(string matricula, string marca, string modelo, bool nuevo, int plazas, double precio)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.nuevo = nuevo;
            this.plazas = plazas;
            this.precio = precio;
        }

        public string Matricula
        {
            get // devuelve un valor de tipo string
            {
                return this.matricula;
            }

            set // recibe un paramtero oculto que se llama "value", es void
            {
                if(value.Length == 7)
                {
                    this.matricula = value;
                }
                else
                {
                    throw new Exception("Matrícula no válida.");
                }
            }
        }

        public override string ToString()
        {
            return marca + " " + modelo + " (" + matricula + ")";
        }
    }
}
