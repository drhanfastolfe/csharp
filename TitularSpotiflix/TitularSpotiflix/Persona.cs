using System;
using System.Collections.Generic;
using System.Text;

namespace TitularSpotiflix
{
    class Persona
    {
        private string nombre;
        private App suscripcion;
        private bool titularPasado;
        private bool titular;
        public Persona(string nombre, App suscripcion, bool titularPasado, bool titular)
        {
            this.nombre = nombre;
            this.suscripcion = suscripcion;
            this.titularPasado = titularPasado;
            this.titular = titular;
        }

        public Persona()
        {

        }

        public enum App
        {
            Spotify, Netflix, Spotiflix
        }
    }
}
