using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IzmenaKorisnika : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        public IzmenaKorisnika()
        {
            InitializeComponent();
        }

        private void IzmenaKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            boxSifra.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            boxIme.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); ;
            boxIndeks.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boxOpis.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            boxTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();

                SqlCommand komanda = new SqlCommand("update korisnik\r\n" +
                    "   set BrIndeksa = @brindeksa, " +
                    "ImePrezime=@imeprezime, " +
                    "\r\nBrojTelefona=@brtelefona," +
                    "Opis=@opis\r\n" +
                    "where BrojKorisnika=@brojkorisnika", konekcija);

                komanda.Parameters.AddWithValue("@brindeksa", Convert.ToInt32(boxIndeks.Text));
                komanda.Parameters.AddWithValue("@imeprezime", boxIme.Text);
                komanda.Parameters.AddWithValue("@brtelefona", boxTelefon.Text);
                komanda.Parameters.AddWithValue("@opis", boxOpis.Text);
                komanda.Parameters.AddWithValue("@brojkorisnika", Convert.ToInt32(boxSifra.Text));

                komanda.ExecuteNonQuery();

                MessageBox.Show("Uspesno ste azurirali: " + boxIme.Text);
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
                this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("greska" + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
