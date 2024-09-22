using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DSOO_Grupo14
{
    internal class Socio
    {
         public long id;
         public string nombre;
         public List<Actividad> actividades;

        public Socio()
        {
            actividades = new List<Actividad>();
        }

        public Socio(long id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            actividades = new List<Actividad>();
        }
    }


}
