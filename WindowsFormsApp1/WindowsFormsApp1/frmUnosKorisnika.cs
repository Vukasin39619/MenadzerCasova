using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmUnosKorisnika : Form
    {
        public Korisnik k;
        public frmUnosKorisnika()
        {
            InitializeComponent();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da unesete?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (string.IsNullOrEmpty(boxOpis.Text) && string.IsNullOrEmpty(boxIndeks.Text)) //ni opis ni indeks
                {
                    k = new Korisnik();
                    k.Imeprezime = boxIme.Text;
                    k.Brojtelefona = boxTelefon.Text;
                    k.Opis = "1";
                    k.Brindeksa = "1";

                }
                else if(string.IsNullOrEmpty(boxIndeks.Text))// bez indeksa
                {
                    k = new Korisnik();
                    k.Imeprezime = boxIme.Text;
                    k.Brojtelefona = boxTelefon.Text;
                    k.Opis = boxOpis.Text;
                    k.Brindeksa = "1";
                }
                else if (string.IsNullOrEmpty(boxOpis.Text))//bez opisa
                {
                    k = new Korisnik();
                    k.Imeprezime = boxIme.Text;
                    k.Brojtelefona = boxTelefon.Text;
                    k.Opis = "1";
                    k.Brindeksa = boxIndeks.Text;
                    
                }
                else if (!string.IsNullOrEmpty(boxIme.Text) && !string.IsNullOrEmpty(boxTelefon.Text)
                    && !string.IsNullOrEmpty(boxOpis.Text) && !string.IsNullOrEmpty(boxIndeks.Text))
                {
                    k = new Korisnik(boxIndeks.Text, boxIme.Text, boxTelefon.Text, boxOpis.Text);
                }
                
                this.Close();
            }
        }
    }
}
