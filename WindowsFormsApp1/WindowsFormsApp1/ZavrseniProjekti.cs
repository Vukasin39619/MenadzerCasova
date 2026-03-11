using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ZavrseniProjekti : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        public void OstvarenaZaradaProjekata()
        {
            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("select sum(Cena)\r\n" +
                    "from OdradjeniProjekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\n" +
                    "where UplacenoCelokupno = 1", konekcija);

                boxTrenutnaZarada.Text = cmd.ExecuteScalar().ToString() + " RSD";
            }
            catch (Exception ex)
            {
                MessageBox.Show("greska: " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        public ZavrseniProjekti()
        {
            InitializeComponent();
        }

        private void ZavrseniProjekti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.OdradjeniProjekti' table. You can move, or remove it, as needed.
            this.odradjeniProjektiTableAdapter.Fill(this.menadzer_CasovaDataSet.OdradjeniProjekti);
            OstvarenaZaradaProjekata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            saveFileDialog1.Filter = "Tekstualni fajl (.txt) | .txt | Word Document (.docx) | .docx";
            saveFileDialog1.FileName = "ZavrseniProjekti.txt";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {

                        sw.Write("Ukupna zarada: " + boxTrenutnaZarada.Text);

                        sw.WriteLine();

                        // Write the rows
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                string header = column.HeaderText;
                                string value = row.Cells[column.Index].Value?.ToString() ?? "N/A";
                                sw.WriteLine($"{header}: {value}");
                            }
                            sw.WriteLine();
                        }

                        MessageBox.Show("Uspesno snimljeno u fajlu " + saveFileDialog1.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
            }
        }
    }
}
