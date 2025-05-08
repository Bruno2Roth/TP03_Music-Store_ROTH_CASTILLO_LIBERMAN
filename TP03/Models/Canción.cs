using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP03.Models
{
    public class Canción
    {
        public string título { get; private set; }
        public string duración { get; private set; }
        public string link { get; private set; }

        public Canción(string pTítulo, string pDuración, string pLink)
        {
            título = pTítulo;
            duración = pDuración;
            link = pLink;
        }

    }

}