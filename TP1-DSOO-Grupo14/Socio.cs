using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DSOO_Grupo14
{
    // Clase Socio
    internal class Socio
    {
        // Atributos de la clase Socio
        string nombre;
        string apellido;
        int socioId;

        // lista de actividades inscriptas por el socio
        private List<Actividad> actividadesInscriptas = new List<Actividad>();

        // Constructor de la clase Socio
        public Socio(string nombre, string apellido, int socioId)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.socioId = socioId;

        }

        // propiedades para obtener los atributos de la clase Socio
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int SocioId
        {
            get { return socioId; }
            set { socioId = value; }
        }
        public List<Actividad> ActividadesInscriptas
        {
            get { return actividadesInscriptas; }
            set { actividadesInscriptas = value; }
        }

        // metodo para mostrar los datos del socio
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("SocioId: " + socioId);
        }

        // metodo para mostrar nombre y apellido del socio concatenados
        public string NombreCompleto()
        {
            return nombre + " " + apellido;
        }
    }

}
