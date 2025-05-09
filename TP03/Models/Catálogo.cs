using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace TP03.Models
{
    public static class Catálogo
    {
        public static Dictionary<int, Album> Discografía { get; private set; } = new Dictionary<int, Album>();
        private static bool inicializado = false;


        public static void InicializarCatálogo()
        {
            if (inicializado)
            {
                return;
            }
            List<Canción> temas = new List<Canción>
{
    new Canción("El anillo del Capitán Beto", "4:51", "https://www.youtube.com/watch?v=Fq-0sAOIU5w&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=1"),
    new Canción("Yo vivo en esta ciudad", "3:50", "https://www.youtube.com/watch?v=CQ3TvLZ5JjA&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=2"),
    new Canción("Amanece en la ruta", "3:14", "https://www.youtube.com/watch?v=g8-IgReC-nE&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=3"),
    new Canción("Donde manda marinero", "3:11", "https://www.youtube.com/watch?v=JJ18DK-I1hE&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=4"),
    new Canción("La Bestia Pop", "3:30", "https://www.youtube.com/watch?v=-z8ZKDv-Z5w&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=5"),
    new Canción("Eiti Leda", "4:35", "https://www.youtube.com/watch?v=g3NzTr1NIm8&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=6"),
    new Canción("Fue amor", "3:12", "https://www.youtube.com/watch?v=m8u5EQhc1jQ&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=7&pp=8AUB"),
    new Canción("Murguita del sur", "4:11", "https://www.youtube.com/watch?v=RNvb3rL15oM&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=8&pp=8AUB"),
    new Canción("Un loco en la calesita", "4:57", "https://www.youtube.com/watch?v=pNWXSxoZGMk&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=9&pp=8AUB"),
    new Canción("Me arde", "3:19", "https://www.youtube.com/watch?v=ZOR_mrqMsZ0&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=10&pp=8AUB"),
    new Canción("Spaghetti del rock", "3:33", "https://www.youtube.com/watch?v=PqLn8ZuGivI&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=11&pp=8AUB"),
    new Canción("Canción de Alicia en el país", "4:24", "https://www.youtube.com/watch?v=y6Sied5BL0E&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=12&pp=8AUB"),
    new Canción("Prófugos", "4:36", "https://www.youtube.com/watch?v=h4n7Aeuy8m4&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=13&pp=8AUB"),
    new Canción("Nada es para siempre", "4:31", "https://www.youtube.com/watch?v=CrxoSlJLgUo&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=14&pp=8AUB"),
    new Canción("Mary Poppins y el deshollinador", "3:52", "https://www.youtube.com/watch?v=v3tAfDr0mzA&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=15&pp=8AUB"),
    new Canción("Ya fue", "3:32", "https://www.youtube.com/watch?v=wX2LNAEilWk&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=16&pp=8AUB"),
    new Canción("Cleopatra, la reina del twist", "3:29", "https://www.youtube.com/watch?v=DEIzpndbhbo&list=OLAK5uy_kSAVIz149q-ACqdZbvHVaO_W6UCMSf2Cs&index=17&pp=8AUB")
};
            Album inconscienteColectivo = new Album(
                "Inconsciente Colectivo", temas, "Rock Nacional", "Fabiana Cantilo", "Fito Páez", 1
                );
            Discografía.Add(1, inconscienteColectivo);


            temas = new List<Canción>
{
    new Canción("A Tu Lado", "3:15", "https://www.youtube.com/watch?v=TGdLSa4DZtM&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=1&pp=iAQB8AUB"),
    new Canción("Tripa y Corazón", "3:16", "https://www.youtube.com/watch?v=ZQCsAjlMhUQ&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=2&pp=iAQB8AUB0gcJCYUJAYcqIYzv"),
    new Canción("Las Cosas Que Hace", "4:36", "https://www.youtube.com/watch?v=YP6Qgt7Tocg&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=3&pp=iAQB8AUB0gcJCYUJAYcqIYzv"),
    new Canción("En El Baldío", "4:51", "https://www.youtube.com/watch?v=ynXY_ewHkXE&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=4&pp=iAQB8AUB"),
    new Canción("Detonador de Sueños", "2:18", "https://www.youtube.com/watch?v=ugTAGbmDzvs&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=5&pp=iAQB8AUB"),
    new Canción("Estalla", "8:10", "https://www.youtube.com/watch?v=MUsmHaARSDw&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=6&pp=iAQB8AUB"),
    new Canción("Miralos", "5:25", "https://www.youtube.com/watch?v=fJagShaPA0c&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=7&pp=iAQB8AUB"),
    new Canción("A la Carga Mi Rocanrol", "3:55", "https://www.youtube.com/watch?v=zH6cmrtG548&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=8&pp=iAQB8AUB"),
    new Canción("La Trifásica", "6:03", "https://www.youtube.com/watch?v=g-Qiood48T0&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=9&pp=iAQB8AUB"),
    new Canción("Oportunidad Oportuna", "2:12", "https://www.youtube.com/watch?v=upBplqOxpVA&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=10&pp=iAQB8AUB"),
    new Canción("El Ojo Del Huracán", "3:57", "https://www.youtube.com/watch?v=ngsgpooB7z8&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=11&pp=iAQB8AUB"),
    new Canción("El Viento Que Todo Lo Empuja", "6:24", "https://www.youtube.com/watch?v=_H0A58qmNkw&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=12&pp=iAQB8AUB"),
    new Canción("Triste Canción de Amor", "4:48", "https://www.youtube.com/watch?v=RS5cEvNz3qQ&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=13&pp=iAQB8AUB"),
    new Canción("Voy A Bailar A la Nave Del Olvido", "9:15", "https://www.youtube.com/watch?v=WjszuXHb8Ew&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=14&pp=iAQB8AUB"),
    new Canción("La Balada Del Diablo y la Muerte", "9:43", "https://www.youtube.com/watch?v=erBOasxh9mg&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=15&pp=iAQB8AUB"),
    new Canción("Hielasangre", "4:48", "https://www.youtube.com/watch?v=wxjAO7fbSR8&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=16&pp=iAQB8AUB"),
    new Canción("El Final Es En Donde Partí", "4:49", "https://www.youtube.com/watch?v=33ub4nLxUC4&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=17&pp=iAQB8AUB"),
    new Canción("La Razón Que Te Demora", "4:50", "https://www.youtube.com/watch?v=FjB5Z8n0RS4&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=19&pp=iAQB8AUB"),
    new Canción("Popurock", "11:46", "https://www.youtube.com/watch?v=FjB5Z8n0RS4&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=19&pp=iAQB8AUB"),
    new Canción("Hey Hey My My", "8:44", "https://www.youtube.com/watch?v=w3SwJfN2bZ4&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=20&pp=iAQB8AUB"),
    new Canción("El Rey De La Triste Felicidad", "4:15", "https://www.youtube.com/watch?v=8uEj96HYAf4&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=21&pp=iAQB8AUB"),
    new Canción("Hablando De La Libertad", "8:57", "https://www.youtube.com/watch?v=Q5xwex4p4h0&list=PLcQKCq8QUvqcNSJQqRqfHw9TO7PH3asti&index=22&pp=iAQB8AUB")
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
    new Canción("Arco", "4:11", "https://www.youtube.com/watch?v=0JIJyb7CQFw&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=1&pp=iAQB8AUB"),
    new Canción("Babilonia", "2:27", "https://www.youtube.com/watch?v=Lb3ygmK9_uQ&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=2&pp=iAQB8AUB"),
    new Canción("Ay Ay Ay", "5:19", "https://www.youtube.com/watch?v=_5jpVGU0IHs&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=3&pp=iAQB8AUB"),
    new Canción("Pistolas", "4:56", "https://www.youtube.com/watch?v=5RFSeF7Qamo&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=4&pp=iAQB8AUB"),
    new Canción("Angelito", "5:30", "https://www.youtube.com/watch?v=ZBbn9fCWD7g&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=5&pp=iAQB8AUB"),
    new Canción("Manise", "3:54", "https://www.youtube.com/watch?v=SEM7d17uq2A&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=6&pp=iAQB8AUB"),
    new Canción("Ximenita", "1:52", "https://www.youtube.com/watch?v=sLZ6VYwocuY&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=7&pp=iAQB8AUB"),
    new Canción("Ando Ganas (Llora Llora)", "5:31", "https://www.youtube.com/watch?v=YJ3rJ5M32Ko&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=8&pp=iAQB8AUB"),
    new Canción("Funmigator", "4:32", "https://www.youtube.com/watch?v=MPJnBeW01EE&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=9&pp=iAQB8AUB"),
    new Canción("Muy Despacito", "6:03", "https://www.youtube.com/watch?v=9cB_i6U8Ojw&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=10&pp=iAQB8AUB"),
    new Canción("Es Sentir", "4:29", "https://www.youtube.com/watch?v=AvQHjCZlARA&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=11&pp=iAQB8AUB"),
    new Canción("Te Diría", "5:17", "https://www.youtube.com/watch?v=pNK7qRzO8jU&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=12&pp=iAQB8AUB"),
    new Canción("Arco II", "2:25", "https://www.youtube.com/watch?v=FXoqnCH1F-k&list=PLCK-lYa8JaeZwLtTbjevSUSWBTXKxosxz&index=13&pp=iAQB8AUB")
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
    new Canción("Casi Estatua", "3:42", "https://www.youtube.com/watch?v=V4HtljBASPk&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=2&pp=iAQB8AUB"),
    new Canción("Par Mil", "3:19", "https://www.youtube.com/watch?v=FirN0SmVYu4&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=3&pp=iAQB8AUB"),
    new Canción("Tanto Anteojo", "3:05", "https://www.youtube.com/watch?v=F4KSWSNXwq0&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=4&pp=iAQB8AUB"),
    new Canción("Que Pasa Conmigo?", "4:05", "https://www.youtube.com/watch?v=54QgmodHIZ4&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=5&pp=iAQB8AUB0gcJCYUJAYcqIYzv"),
    new Canción("Spaghetti del Rock", "3:33", "https://www.youtube.com/watch?v=K8kxKd-TQLM&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=6&pp=iAQB8AUB"),
    new Canción("Elefantes en Europa", "3:25", "https://www.youtube.com/watch?v=84BL3PKJfPo&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=7&pp=iAQB8AUB"),
    new Canción("Vida de Topos", "5:04", "https://www.youtube.com/watch?v=CXYTC15Xgd8&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=8&pp=iAQB8AUB"),
    new Canción("La Ñapi de Mamá", "5:22", "https://www.youtube.com/watch?v=0_CO6fRoizM&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=9&pp=iAQB8AUB"),
    new Canción("Como un Cuento", "4:47", "https://www.youtube.com/watch?v=2hcbrxkBXGs&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=10&pp=iAQB8AUB"),
    new Canción("Sopa de Tortuga", "3:35", "https://www.youtube.com/watch?v=_KAtjLIAbwU&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=11&pp=iAQB8AUB"),
    new Canción("Pasiones Zurdas Derechas", "3:44", "https://www.youtube.com/watch?v=b4hUxyK_jjo&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=12&pp=iAQB8AUB"),
    new Canción("La Gente Se Divierte", "4:46", "https://www.youtube.com/watch?v=3yfXzpSsW6U&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=13&pp=iAQB8AUB"),
    new Canción("La Firma del Opa", "1:56", "https://www.youtube.com/watch?v=pyRAQ7tx7vg&list=PLQjqJ7yoMDJ6yNcvHWbJp11TAFKwfZRsR&index=14&pp=iAQB8AUB")
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

