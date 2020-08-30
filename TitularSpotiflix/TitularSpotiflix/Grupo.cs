using System;
using System.Collections.Generic;
using System.Text;

namespace TitularSpotiflix
{
    class Grupo
    {
        private List<Persona> listaPersonas;

        public Grupo()
        {
            this.listaPersonas = new List<Persona>();
        }

        public void insertaPersonaLista(string nombre, Persona.App suscripcion, bool titularPasado, bool titular)
        {
            Persona p = new Persona(nombre, suscripcion, titularPasado, titular);

            this.listaPersonas.Add(p);
        }
    }
}
