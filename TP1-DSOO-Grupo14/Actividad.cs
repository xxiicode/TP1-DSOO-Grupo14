using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DSOO_Grupo14
{
    internal class Actividad
    {
        public int id;
        public string nombre;
        public int cupo;
        public List<Socio> participantes;

        public Actividad()
        {
            participantes = new List<Socio>();
        }

        public Actividad(int id, string nombre, int cupo)
        {
            this.id = id;
            this.nombre = nombre;
            this.cupo = cupo;
            participantes = new List<Socio>();
        }
    }
}
