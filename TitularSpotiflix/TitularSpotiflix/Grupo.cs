using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitularSpotiflix
{
    class Grupo
    {
        private List<Persona> listaPersonas;

        public Grupo()
        {
            this.listaPersonas = new List<Persona>();
        }

        public void insertaPersonaLista(string nombre, Persona.App suscripcion, bool titularPasado)
        {
            Persona p = new Persona(nombre, suscripcion, titularPasado);

            this.listaPersonas.Add(p);
        }

        public void leeFicheroTexto(String fichero)
        {
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                Persona p = new Persona();

                p.Nombre = sr.ReadLine();
                p.Suscripcion = (Persona.App)Enum.Parse(typeof(Persona.App), sr.ReadLine());
                p.TitularPasado = bool.Parse(sr.ReadLine());

                this.listaPersonas.Add(p);
            }

            sr.Close();
        }

        public List<Persona> ListaPersonas
        {
            get
            {
                return this.listaPersonas;
            }
        }

        public override string ToString()
        {
            string fichaGrupo = "";

            for (int i = 0; i < this.listaPersonas.Count; i++)
            {
                fichaGrupo = fichaGrupo + this.listaPersonas[i].ToString() + "\n";
            }

            return fichaGrupo;
        }
    }
}
