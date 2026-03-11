using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class Projekti
    {
        private DateTime datum;
        private int korisnik;
        private int idcene;
        private bool odradjeno;
        private bool uplacenoSkroz;
        private bool uplacenAvans;

        public Projekti(DateTime datum, int korisnik, int idcene, bool odradjeno, bool uplacenoSkroz, bool uplacenAvans)
        {
            this.Datum = datum;
            this.Korisnik = korisnik;
            this.Idcene = idcene;
            this.Odradjeno = odradjeno;
            this.UplacenoSkroz = uplacenoSkroz;
            this.UplacenAvans = uplacenAvans;
        }
        public Projekti()
        {
           
        }

        public DateTime Datum { get => datum; set => datum = value; }
        public int Korisnik { get => korisnik; set => korisnik = value; }
        public int Idcene { get => idcene; set => idcene = value; }
        public bool Odradjeno { get => odradjeno; set => odradjeno = value; }
        public bool UplacenoSkroz { get => uplacenoSkroz; set => uplacenoSkroz = value; }
        public bool UplacenAvans { get => uplacenAvans; set => uplacenAvans = value; }
    }
}
