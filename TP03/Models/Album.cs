using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP03.Models
{
    public class Album
    {
        public string título { get; private set; }
        public List<Canción> canciones { get; private set; }
        public string género { get; private set; }
        public string autor { get; private set; }
        public string productor { get; private set; }
        public int id { get; private set; }


        public Album(string pTítulo, List<Canción> pCanciones, string pGénero, string pAutor, string pProductor, int pID)
        {
            título = pTítulo;
            canciones = pCanciones;
            género = pGénero;
            autor = pAutor;
            productor = pProductor;
            id = pID;
        }
    }


}
