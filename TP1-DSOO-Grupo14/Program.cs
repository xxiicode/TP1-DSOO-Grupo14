namespace TP1_DSOO_Grupo14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crear club
            ClubDeportivo club = new ClubDeportivo(); 


            //crear actividades
            club.actividades.Add(new Actividad(1, "natacion", 2));
            club.actividades.Add(new Actividad(2, "futbol", 10));
            club.actividades.Add(new Actividad(3, "boxeo", 4));
            club.actividades.Add(new Actividad(4, "danza", 5));
  
            //crear socios
            Console.WriteLine(club.altaSocio(1, "pepe"));
            Console.WriteLine(club.altaSocio(2, "juancito"));
            Console.WriteLine(club.altaSocio(3, "marta"));
            Console.WriteLine(club.altaSocio(1, "pepe")); // repetido


            //test
            Console.WriteLine(club.inscribirActividad("karate", 1)); // No actividad
            Console.WriteLine(club.inscribirActividad("futbol", 4)); // No socio
            Console.WriteLine(club.inscribirActividad("natacion", 1)); 
            Console.WriteLine(club.inscribirActividad("futbol", 1)); 
            Console.WriteLine(club.inscribirActividad("boxeo", 1)); 
            Console.WriteLine(club.inscribirActividad("danza", 1)); // Tope socio
            Console.WriteLine(club.inscribirActividad("natacion", 2)); 
            Console.WriteLine(club.inscribirActividad("natacion", 3)); // Tope actividad

            

        }
    }
}
