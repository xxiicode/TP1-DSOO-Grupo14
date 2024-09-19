using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DSOO_Grupo14
{
    // Clase ClubDeportivo
    internal class ClubDeportivo
    {
        // La clase ClubDeportivo no tiene atributos ya que hay una sola instancia de la clase

        //lista de Actividades
        private List<Actividad> actividades = new List<Actividad>();

        //lista de Socios
        private List<Socio> socios = new List<Socio>();

        // Propiedad para obtener la lista de actividades
        public List<Actividad> Actividades
        {
            get { return actividades; }
            set { actividades = value; }
        }

        // Propiedad para obtener la lista de socios
        public List<Socio> Socios
        {
            get { return socios; }
            set { socios = value; }
        }

        // Constructor de la clase ClubDeportivo
        public ClubDeportivo()
        {
            Console.WriteLine("Club14 abre sus puertas!");
        }

        // Metodo para agregar una actividad a la lista de actividades
        public void AgregarActividad(string nombre, int actividadId, int cupo)
        {
            // Verifica que la actividad no exista ya en la lista de actividades
            if (actividades.Any(a => a.Nombre == nombre))
            {
                Console.WriteLine("La actividad ya existe");
                return;
            }
            Actividad nuevaActividad = new Actividad(nombre, actividadId, cupo);
            actividades.Add(nuevaActividad);
            Console.WriteLine($"Actividad {nuevaActividad.Nombre} agregada con exito");
        }

        // Metodo para agregar un socio a la lista de socios
        public void AgregarSocio(string nombre, string apellido, int socioId)
        {
            if (socios.Any(s => s.SocioId == socioId))
            {
                Console.WriteLine("El socio ya existe");
                return;
            }
            Socio nuevoSocio = new Socio(nombre, apellido, socioId);
            socios.Add(nuevoSocio);
            Console.WriteLine($"Socio {nuevoSocio.NombreCompleto()} agregado con exito");
        }

        // Metodo para inscribir un socio en una actividad
        public void InscribirSocioEnActividad(Socio socio, Actividad actividad)
        {
            if (actividad.HayCupoDisponible() && !actividad.SocioInscripto(socio) && socio.ActividadesInscriptas.Count < 3)
            {
                actividad.SociosInscriptos.Add(socio);
                socio.ActividadesInscriptas.Add(actividad);
            }
            else if (socio.ActividadesInscriptas.Count >= 3)
            {
                Console.WriteLine($"El socio {socio.Nombre} ya está inscripto en el máximo de actividades permitidas.");
            }
            else if (!actividad.HayCupoDisponible())
            {
                Console.WriteLine($"No hay cupo disponible en la actividad {actividad.Nombre}.");
            }
            else
            {
                Console.WriteLine($"El socio {socio.Nombre} ya está inscripto en la actividad {actividad.Nombre}.");
            }
        }

        // Metodo para ver todas cantidad y datos de las actividades
        public void VerActividades()
        {
            Console.WriteLine("Cantidad de actividades: " + actividades.Count);
            if (actividades.Count == 0)
            {
                Console.WriteLine("No hay actividades");
                return;
            }

            foreach (Actividad a in actividades)
            {
                Console.WriteLine($"Actividad: {a.Nombre} | Cupo disponibles: {a.CuposDisponibles()}");
            }
        }

    }
}
