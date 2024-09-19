namespace TP1_DSOO_Grupo14
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // Crear la única instancia de ClubDeportivo
            ClubDeportivo club14 = new ClubDeportivo();


            // Agregar actividades al club
            club14.AgregarActividad("Futbol", 1, 10);
            club14.AgregarActividad("Natacion", 2, 15);
            club14.AgregarActividad("Tenis", 3, 5);

            // Agregar socios al club
            club14.AgregarSocio("Lean", "Bilokapic", 1);
            club14.AgregarSocio("Martin", "Ferroviario", 2);
            club14.AgregarSocio("Guido", "Alimenticio", 3);

            // Inscribir socios en actividades
            club14.InscribirSocioEnActividad() //... Me clave aca.No se como seguir.

        }
    }
}
