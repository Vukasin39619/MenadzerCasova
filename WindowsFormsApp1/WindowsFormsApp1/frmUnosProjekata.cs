using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class frmUnosProjekata : Form
    {
       public Projekti p;
        public frmUnosProjekata()
        {
            InitializeComponent();
        }

        private void frmUnosProjekata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.CenovnikProjekti' table. You can move, or remove it, as needed.
            this.cenovnikProjektiTableAdapter.Fill(this.menadzer_CasovaDataSet.CenovnikProjekti);
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boxIDCene.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public bool VratiUplacenoAvans()
        {
            bool x = false;
            if (chboxAvans.Checked)
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
        public bool VratiUplacenoSkroz()
        {
            bool x = false;
            if (chboxUplacenoSkroz.Checked)
            {
                x = true;
            }
            return x;
        }
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(boxIDCene.Text))
            {
                if (MessageBox.Show("Potvrdi", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                    == DialogResult.Yes)
                {
                    p = new Projekti(dateTimePicker1.Value,
                        Convert.ToInt32(boxKorisnik.SelectedValue),
                        Convert.ToInt32(boxIDCene.Text),
                        VratiOdradjeno(),
                        VratiUplacenoSkroz(),
                        VratiUplacenoAvans());

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Kliknite na datagrid da izaberete projekat.");
            }
        }
    }
}
