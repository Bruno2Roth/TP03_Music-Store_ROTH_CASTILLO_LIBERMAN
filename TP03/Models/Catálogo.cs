using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP03.Models
{
    public static class Catálogo
    {
        //HACER QUE LOS LINKS FUNCIONEN ES RESPONSABILIDAD DE BRUNO
        public static Dictionary<int, Album> Discografía { get; private set; } = new Dictionary<int, Album>();
        private static bool inicializado = false;

        public static void InicializarCatálogo()
        {
            if(inicializado){
                return;
            }

            List<Canción> temas = new List<Canción>
{
    new Canción("El anillo del Capitán Beto", "4:51", "https://www.youtube.com/watch?v=pIdmALgs4fg"),
    new Canción("Yo vivo en esta ciudad", "3:50", "https://www.youtube.com/watch?v=Z4KkzFz8qjY"),
    new Canción("Amanece en la ruta", "3:14", "https://www.youtube.com/watch?v=VxQb0J0bR2A"),
    new Canción("Donde manda marinero", "3:11", "https://www.youtube.com/watch?v=Qy7V1xvD3eU"),
    new Canción("La Bestia Pop", "3:30", "https://www.youtube.com/watch?v=G3yY9wXk1Z4"),
    new Canción("Eiti Leda", "4:35", "https://www.youtube.com/watch?v=H8k9Vv1M8zY"),
    new Canción("Fue amor", "3:12", "https://www.youtube.com/watch?v=J9k9Y9Zk2bE"),
    new Canción("Murguita del sur", "4:11", "https://www.youtube.com/watch?v=K2yY9wXk3cF"),
    new Canción("Un loco en la calesita", "4:57", "https://www.youtube.com/watch?v=L3zZ0a1b4dG"),
    new Canción("Me arde", "3:19", "https://www.youtube.com/watch?v=M4aA1b2c5eH"),
    new Canción("Spaghetti del rock", "3:33", "https://www.youtube.com/watch?v=N5bB2c3d6fI"),
    new Canción("Canción de Alicia en el país", "4:24", "https://www.youtube.com/watch?v=O6cC3d4e7gJ"),
    new Canción("Prófugos", "4:36", "https://www.youtube.com/watch?v=P7dD4e5f8hK"),
    new Canción("Nada es para siempre", "4:31", "https://www.youtube.com/watch?v=Q8eE5f6g9iL"),
    new Canción("Mary Poppins y el deshollinador", "3:52", "https://www.youtube.com/watch?v=R9fF6g7h0jM"),
    new Canción("Ya fue", "3:32", "https://www.youtube.com/watch?v=S0gG7h8i1kN"),
    new Canción("Cleopatra, la reina del twist", "3:29", "https://www.youtube.com/watch?v=T1hH8i9j2lO")
};
            Album inconscienteColectivo = new Album(
                "Inconsciente Colectivo", temas, "Rock Nacional", "Fabiana Cantilo", "Fito Páez", 1
                );
            Discografía.Add(1, inconscienteColectivo);

            temas = new List<Canción>
{
    new Canción("Apertura", "1:30", ""),
    new Canción("A Tu Lado", "4:20", ""),
    new Canción("Tripa y Corazón", "5:10", ""),
    new Canción("Las Cosas Que Hace", "4:00", ""),
    new Canción("En El Baldío", "4:30", ""),
    new Canción("Detonador de Sueños", "5:00", ""),
    new Canción("Estalla", "4:15", ""),
    new Canción("Miralos", "3:50", ""),
    new Canción("A la Carga Mi Rocanrol", "4:05", ""),
    new Canción("La Trifásica", "6:00", ""),
    new Canción("Intervalo", "2:00", ""),
    new Canción("Oportunidad Oportuna", "4:10", ""),
    new Canción("El Ojo Del Huracán", "5:20", ""),
    new Canción("El Viento Que Todo Lo Empuja", "4:40", ""),
    new Canción("Triste Canción de Amor", "5:00", ""),
    new Canción("Voy A Bailar A la Nave Del Olvido", "4:30", ""),
    new Canción("La Balada Del Diablo y la Muerte", "5:50", ""),
    new Canción("Hielasangre", "4:20", ""),
    new Canción("El Final Es En Donde Partí", "5:10", ""),
    new Canción("La Razón Que Te Demora", "4:45", ""),
    new Canción("Popurock", "3:30", ""),
    new Canción("Hey Hey My My", "4:00", ""),
    new Canción("El Rey De La Triste Felicidad", "4:15", ""),
    new Canción("Hablando De La Libertad", "5:00", "")
};
            Album enElOjoDelHuracán = new Album(
                "En el Ojo del Huracán",
                temas,
                "Rock Nacional",
                "La Renga",
                "La Renga",
                2
            );
            Discografía.Add(2, enElOjoDelHuracán);

            temas = new List<Canción>
{
    new Canción("Arco", "4:00", ""),
    new Canción("Babilonia", "3:50", ""),
    new Canción("Muy Despacito", "4:10", ""),
    new Canción("Angelito", "3:45", ""),
    new Canción("Ay Ay Ay", "4:00", ""),
    new Canción("Ando Ganas (Llora Llora)", "4:20", ""),
    new Canción("Pistolas", "3:30", ""),
    new Canción("Chac Tu Chac", "3:55", ""),
    new Canción("Esquina Libertad", "4:05", ""),
    new Canción("Cruel", "4:15", ""),
    new Canción("Maradó", "3:40", ""),
    new Canción("Yira", "3:50", ""),
    new Canción("Finale", "2:30", "")
};
            Album ayAyAy = new Album(
                "Ay Ay Ay",
                temas,
                "Rock Nacional",
                "Los Piojos",
                "Alfredo Toth y Adrián Bilbao",
                3
            );
            Discografía.Add(3, ayAyAy);

            temas = new List<Canción>
{
    new Canción("Casi Estatua", "3:42", ""),
    new Canción("Par Mil", "3:17", ""),
    new Canción("Tanto Anteojo", "3:04", ""),
    new Canción("Que Tal?", "3:30", ""),
    new Canción("La Gente Se Divierte", "3:50", ""),
    new Canción("Narigón del Siglo", "4:10", ""),
    new Canción("Vida de Topo", "3:45", ""),
    new Canción("Sábado", "4:00", ""),
    new Canción("Elefantes en Europa", "3:55", ""),
    new Canción("La Ñapi de Mamá", "3:35", ""),
    new Canción("Despiértate Nena", "4:20", ""),
    new Canción("Alma de Budín", "3:40", "")
};
            Album narigonDelSiglo = new Album(
                "Narigón del Siglo",
                temas,
                "Rock",
                "Divididos",
                "Afo Verde y Divididos",
                4
            );
            Discografía.Add(4, narigonDelSiglo);

            inicializado = true;
        }
    }
}