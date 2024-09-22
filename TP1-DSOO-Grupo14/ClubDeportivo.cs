using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DSOO_Grupo14
{
    internal class ClubDeportivo
    {
        public List<Socio> socios;
        public List<Actividad> actividades;

        public ClubDeportivo()
        {
            socios = new List<Socio>();
            actividades = new List<Actividad>();
        }



        public string altaSocio(long id, string nombre) {
            Socio socio = socios.Find(s => s.id == id);

            if (socio == null) { 
                socios.Add(new Socio(id,nombre));
                return "Socio cargado con exito";
            }

            return "El socio ya esta registrado";
        }

        public string inscribirActividad(string nombreActividad,long idSocio) {
            Socio socio = socios.Find(s => s.id == idSocio);
            Actividad actividad = actividades.Find(a => a.nombre == nombreActividad);

            if (actividad == null) {
                return "ACTIVIDAD INEXISTENTE";
            }

            if (socio == null) {
                return "SOCIO INEXISTENTE";
            }

            if (socio.actividades.Count >= 3 || actividad.cupo <= 0) {
                return "TOPE ALCANZADO";
            }

            actividad.cupo--;
            actividad.participantes.Add(socio);
            socio.actividades.Add(actividad);

            return "INSCRIPCIÓN EXITOSA";
        }
    }
}
