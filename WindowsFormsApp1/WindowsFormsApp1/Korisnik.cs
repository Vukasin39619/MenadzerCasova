using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Korisnik
    {
        private string brindeksa;
        private string imeprezime;
        private string brojtelefona;
        private string opis;

        public Korisnik(string brindeksa, string imeprezime, string brojtelefona, string opis)
        {
            this.Brindeksa = brindeksa;
            this.Imeprezime = imeprezime;
            this.Brojtelefona = brojtelefona;
            this.Opis = opis;
        }
        public Korisnik()
        {
            
        }

        public string Brindeksa { get => brindeksa; set => brindeksa = value; }
        public string Imeprezime { get => imeprezime; set => imeprezime = value; }
        public string Brojtelefona { get => brojtelefona; set => brojtelefona = value; }
        public string Opis { get => opis; set => opis = value; }
    }
}
