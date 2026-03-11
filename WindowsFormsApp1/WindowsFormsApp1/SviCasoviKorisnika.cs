using System;
using System.Collections;
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
    public partial class SviCasoviKorisnika : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        private int korisnikId;

        public void PuniGrid()
        {
            try
            {
                konekcija.Open();

                SqlCommand command = new SqlCommand("select c.*, k.ImePrezime\r\nfrom casovi c join korisnik k on c.Korisnik = k.BrojKorisnika\r\nwhere Korisnik=@korisnik", konekcija);
                command.Parameters.AddWithValue("@korisnik", korisnikId);

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
        public SviCasoviKorisnika(int id)
        {
            InitializeComponent();
            korisnikId = id;
            PuniGrid();
        }
    }
}
