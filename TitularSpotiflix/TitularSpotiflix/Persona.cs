using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitularSpotiflix
{
    class Persona
    {
        private string nombre;
        private App suscripcion;
        private bool titularPasado;

        public Persona(string nombre, App suscripcion, bool titularPasado)
        {
            this.nombre = nombre;
            this.suscripcion = suscripcion;
            this.titularPasado = titularPasado;
        }

        public Persona()
        {

        }

        public enum App
        {
            Spotify, Netflix, Spotiflix
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public App Suscripcion
        {
            get
            {
                return this.suscripcion;
            }

            set
            {
                this.suscripcion = value;
            }
        }

        public bool TitularPasado
        {
            get
            {
                return this.titularPasado;
            }

            set
            {
                this.titularPasado = value;
            }

        }

        public override string ToString()
        {
            string fichaPersona;

            fichaPersona = this.nombre + " | " + this.suscripcion + " | Titular en el pasado: " + titularPasado;

            return fichaPersona;
        }
    }
}
