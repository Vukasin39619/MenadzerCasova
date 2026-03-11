using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Casovi
    {
        private int cena;
        private string opis;
        private bool uplaceno;
        private string predmet;
        private DateTime datum;
        private int korisnik;
        private string vreme;
        private bool odradjeno;

        public Casovi(string opis, bool uplaceno, string predmet, DateTime datum, int korisnik, string vreme, bool odradjeno)
        {
            this.Cena = 15;
            this.Opis = opis;
            this.Uplaceno = uplaceno;
            this.Predmet = predmet;
            this.Datum = datum;
            this.Korisnik = korisnik;
            this.Vreme = vreme;
            this.Odradjeno = odradjeno;
        }

        public int Cena { get => cena; set => cena = value; }
        public string Opis { get => opis; set => opis = value; }
        public bool Uplaceno { get => uplaceno; set => uplaceno = value; }
        public string Predmet { get => predmet; set => predmet = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int Korisnik { get => korisnik; set => korisnik = value; }
        public string Vreme { get => vreme; set => vreme = value; }
        public bool Odradjeno { get => odradjeno; set => odradjeno = value; }
    }
}
