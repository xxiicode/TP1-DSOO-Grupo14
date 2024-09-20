namespace TP1_DSOO_Grupo14
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // Crear la única instancia de ClubDeportivo
            ClubDeportivo club14 = new ClubDeportivo();

            EspacioSeparador();

            // Agregar actividades al club
            Console.WriteLine("Se agregan actividades:");
            club14.AgregarActividad("Futbol", 1, 10);
            club14.AgregarActividad("Natacion", 2, 15);
            club14.AgregarActividad("Tenis", 3, 5);

            EspacioSeparador();

            // Agregar socios al club
            Console.WriteLine("Se agregan socios:");
            club14.AltaSocio("Lean", "Bilokapic", 32444856);
            club14.AltaSocio("Martin", "Ferroviario", 365584123);
            club14.AltaSocio("Guido", "Alimenticio", 39547852);
            club14.AltaSocio("Yoel", "Administrativo", 38254152);


            // variables de testeo
            // Tomo un socio
            Socio? socio1 = club14.Socios[0];
            // Tomo una actividad
            Actividad? actividad1 = club14.Actividades[0];

            EspacioSeparador();

            // Muestro datos del usuario
            Console.WriteLine("Se muestran datos de un socio:");
            socio1.MostrarDatos();

            EspacioSeparador();

            // Muestra los socios inscriptos en una actividad
            Console.WriteLine("Se muestran los socios inscriptos en una actividad:");
            Console.WriteLine(actividad1.Nombre);
            actividad1.VerSociosInscriptos();

            EspacioSeparador();

            // Inscribir socios en actividades
            Console.WriteLine("Se inscriben socios en actividades:");
            club14.InscribirSocioEnActividad("Natacion", 32444856);
            club14.InscribirSocioEnActividad("Tenis", 365584123);

            EspacioSeparador();

            // Ver todas las actividades para confirmar que fueron agregadas
            Console.WriteLine("Se muestran todas las actividades:");
            club14.VerActividades();



            static void EspacioSeparador()
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine();
            }
        }
    }
}
