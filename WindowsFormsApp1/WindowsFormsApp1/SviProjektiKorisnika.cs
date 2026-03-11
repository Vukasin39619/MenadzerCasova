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
    public partial class SviProjektiKorisnika : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        private int korisnikId;
        public void PuniGrid()
        {
            try
            {
                konekcija.Open();

                SqlCommand command = new SqlCommand("select c.*, k.ImePrezime, cp.Predmet,cp.Opis,cp.Cena\r\nfrom projekti c join korisnik k on c.Korisnik = k.BrojKorisnika\r\njoin CenovnikProjekti cp on c.IdCene = cp.IdCene\r\nwhere Korisnik=@Korisnik\r\n", konekcija);
                command.Parameters.AddWithValue("@Korisnik", korisnikId);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("greska" + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        public SviProjektiKorisnika(int id)
        {
            InitializeComponent();
            korisnikId = id;
            PuniGrid();
        }
    }
}
