using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DSOO_Grupo14
{
    // Clase Actividad
    internal class Actividad
    {
        // Atributos de la clase Actividad
        string nombre;
        int actividadId;
        int cupo;

        // Lista de socios inscriptos en la actividad
        private List<Socio> sociosInscriptos = new List<Socio>();

        // Constructor de la clase Actividad
        public Actividad(string nombre, int activididId, int cupo)
        {
            this.nombre = nombre;
            this.actividadId = activididId;
            this.cupo = cupo;
        }

        // Propiedades para obtener los atributos de la clase Actividad
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int ActividadId
        {
            get { return actividadId; }
            set { actividadId = value; }
        }
        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }

        public List<Socio> SociosInscriptos
        {
            get { return sociosInscriptos; }
            set { sociosInscriptos = value; }
        }

        // Metodos para saber si hay cupos disponibles
        public bool HayCupoDisponible()
        {
            return sociosInscriptos.Count < cupo;
        }

        // Metodo para saber si un socio esta inscripto en una actividad
        public bool SocioInscripto(Socio socio)
        {
            return sociosInscriptos.Contains(socio);
        }

        // Metodo para saber si hay cupos disponibles
        public int CuposDisponibles()
        {
            return cupo - sociosInscriptos.Count;
        }

        // Metodo para ver los socios inscriptos en una actividad
        public void VerSociosInscriptos()
        {
            // Primero te dice cuantos socios hay inscriptos
            Console.WriteLine("Cantidad de socios inscriptos: " + sociosInscriptos.Count);
            // Luego te muestra los nombres y apellidos de los socios inscriptos
            if (sociosInscriptos.Count == 0)
            {
                Console.WriteLine("No hay socios inscriptos");
                return;
            }

            foreach (Socio s in sociosInscriptos)
            {
                Console.WriteLine("Nombre: " + s.Nombre + " Apellido: " + s.Apellido);
            }
        }
    }
}
