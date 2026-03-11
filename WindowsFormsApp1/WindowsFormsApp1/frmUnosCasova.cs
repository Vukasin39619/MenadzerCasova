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
    public partial class frmUnosCasova : Form
    {
        public Casovi c;
        public frmUnosCasova()
        {
            InitializeComponent();
        }

        private void frmUnosCasova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);

        }
        public bool VratiUplaceno()
        {
            bool x = false;
            if (chboxUplaceno.Checked)
            {
                x = true;
            }
            return x;
        }
        public bool VratiOdradjeno()
        {
            bool x = false;
            if (chboxOdradjeno.Checked)
            {
                x = true;
            }
            return x;
        }
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(boxOpisCasa.Text) && !string.IsNullOrEmpty(boxPredmet.Text) && !string.IsNullOrEmpty(boxVreme.Text) )
            {
                if (MessageBox.Show("Potvrdi", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c = new Casovi(boxOpisCasa.Text, VratiUplaceno(), boxPredmet.Text, dateTimePicker1.Value, Convert.ToInt32(comboBox1.SelectedValue), boxVreme.Text, VratiOdradjeno());
                    this.Close();
                }
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
