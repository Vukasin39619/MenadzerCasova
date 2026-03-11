using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        
        public Form1()
        {
            InitializeComponent();
        }
        public void UkupnaZaradaSvega()
        {


        }
       
            public void UkupnaZaradaCasova()
        {
            int zarada = 0;

            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("SELECT    \r\n((SELECT COUNT(*)* 30    \r\nFROM Casovi\r\nWHERE opis = 'dvocas' AND UplacenoCelokupno = 0)\r\n+ (SELECT COUNT(*)* 15 \r\nFROM Casovi\r\nWHERE opis = 'jedancas' AND UplacenoCelokupno = 0)+\r\n((SELECT COUNT(*)* 30    \r\nFROM Casovi\r\nWHERE opis = 'dvocas' AND UplacenoCelokupno = 1)\r\n+ (SELECT COUNT(*)* 15 \r\nFROM Casovi\r\nWHERE opis = 'jedancas' AND UplacenoCelokupno = 1))\r\n\r\n)", konekcija);

                boxUkupnaZaradaCasova.Text = cmd.ExecuteScalar().ToString() + " €";

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
        public void OstvarenaZaradaProjekata()
        {
            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("select sum(Cena)\r\n" +
                    "from Projekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\n" +
                    "where UplacenoCelokupno = 0", konekcija);

                boxPotZarProjekat.Text = cmd.ExecuteScalar().ToString() + " RSD";
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
        public void UkupnaZaradaProjekata()
        {
            int zarada = 0;

            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("select (select sum(Cena)\r\nfrom Projekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\nwhere UplacenoCelokupno = 0)+(select sum(Cena)\r\nfrom Projekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\nwhere UplacenoCelokupno = 1)", konekcija);

                boxUkupnaZaradaProjekata.Text = cmd.ExecuteScalar().ToString() + " RSD";

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
        public void MogucaZaradaProjekata()
        {
            int zarada = 0;

            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("select sum(Cena)\r\nfrom Projekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\nwhere UplacenoCelokupno = 1", konekcija);

                boxTrenutnaZarProjekat.Text = cmd.ExecuteScalar().ToString() + " RSD";
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
        public void MogucaZaradaCasova()
        {
            int zarada = 0;

            try
            { 
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("SELECT    \r\n(SELECT COUNT(*) * 30    \r\nFROM Casovi     \r\nWHERE opis = 'dvocas' AND UplacenoCelokupno = 0)\r\n+ (SELECT COUNT(*) * 15 \r\nFROM Casovi    \r\nWHERE opis = 'jedancas' AND UplacenoCelokupno = 0)", konekcija);

                boxPotencijalnaZarada.Text =  cmd.ExecuteScalar().ToString() + " €";
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
        public void OstvarenaZaradaCasova()
        {
            int zarada = 0;

            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("SELECT    \r\n(SELECT COUNT(*) * 30    \r\nFROM Casovi     \r\nWHERE opis = 'dvocas' AND UplacenoCelokupno = 1)\r\n+ (SELECT COUNT(*) * 15 \r\nFROM Casovi    \r\nWHERE opis = 'jedancas' AND UplacenoCelokupno = 1)", konekcija);

                boxTrenutnaZarada.Text = cmd.ExecuteScalar().ToString() + " €"; ;
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
        public void MogucaCasoviIProjekti()
        {
            int zarada = 0;

            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("SELECT  (select sum(Cena)\r\nfrom Projekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\nwhere UplacenoCelokupno = 0)+((SELECT COUNT(*) * 30*118    \r\nFROM Casovi     \r\nWHERE opis = 'dvocas' AND UplacenoCelokupno = 0)\r\n+ (SELECT COUNT(*) * 15 *118\r\nFROM Casovi    \r\nWHERE opis = 'jedancas' AND UplacenoCelokupno = 0))", konekcija);

                boxMOGUCAUKUPNA.Text = cmd.ExecuteScalar().ToString() + " RSD"; ;
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
        public void OstvarenaCasoviIProjekti()
        {
            int zarada = 0;

            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("SELECT  (select sum(Cena)\r\nfrom Projekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\nwhere UplacenoCelokupno = 1)+((SELECT COUNT(*) * 30*118    \r\nFROM Casovi     \r\nWHERE opis = 'dvocas' AND UplacenoCelokupno = 1)\r\n+ (SELECT COUNT(*) * 15 *118\r\nFROM Casovi    \r\nWHERE opis = 'jedancas' AND UplacenoCelokupno = 1))", konekcija);

                boxUplacenaUKUPNA.Text = cmd.ExecuteScalar().ToString() + " RSD"; ;
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
        public void UkupnaUkupna()
        {
            int zarada = 0;

            try
            {
                konekcija.Open();
                SqlCommand cmd = new SqlCommand("select (select sum(Cena)\r\nfrom Projekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\nwhere UplacenoCelokupno = 0)+(select sum(Cena)\r\nfrom Projekti p join CenovnikProjekti c on p.IdCene = c.IdCene\r\nwhere UplacenoCelokupno = 1)\r\n+\r\n    \r\n((SELECT COUNT(*) * 30*118    \r\nFROM Casovi     \r\nWHERE opis = 'dvocas' AND UplacenoCelokupno = 0)\r\n+ (SELECT COUNT(*) * 15 *118 \r\nFROM Casovi    \r\nWHERE opis = 'jedancas' AND UplacenoCelokupno = 0)+\r\n((SELECT COUNT(*) * 30 *118    \r\nFROM Casovi     \r\nWHERE opis = 'dvocas' AND UplacenoCelokupno = 1)\r\n+ (SELECT COUNT(*) * 15 *118 \r\nFROM Casovi    \r\nWHERE opis = 'jedancas' AND UplacenoCelokupno = 1))\r\n\r\n)", konekcija);

                boxUKUPNAUKUPNA.Text = cmd.ExecuteScalar().ToString() + " RSD"; ;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet2.CenovnikProjekti' table. You can move, or remove it, as needed.
            this.cenovnikProjektiTableAdapter.Fill(this.menadzer_CasovaDataSet.CenovnikProjekti);
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet2.Projekti1' table. You can move, or remove it, as needed.
            this.projektiTableAdapter.Fill(this.menadzer_CasovaDataSet.Projekti);

            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);

            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Casovi' table. You can move, or remove it, as needed.
            this.casoviTableAdapter.Fill(this.menadzer_CasovaDataSet.Casovi);

            MogucaZaradaCasova();OstvarenaZaradaCasova();
            MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
            UkupnaZaradaCasova(); UkupnaZaradaProjekata();
            OstvarenaCasoviIProjekti();MogucaCasoviIProjekti();
            UkupnaUkupna();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Clear();
            // Provera da li je kliknuta određena ćelija, npr. ćelija u koloni sa indeksom 6
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                try
                {
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("select ImePrezime, BrojTelefona, COALESCE(Opis, 'Nema Opis') " +
                        "AS Opis, COALESCE(brindeksa, 0) AS BrIndeksa" +
                        "\r\nfrom Korisnik\r\nwhere BrojKorisnika = @id\r\n", konekcija);



                    cmd.Parameters.AddWithValue("id", DataGridProjekti.CurrentRow.Cells[4].Value.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        richTextBox1.Text += ("Ime i prezime: " + reader.GetString(0) + "\nBroj Telefona: " + reader.GetString(1) + "\nOpis: " + reader.GetString(2) + "\nBrojIndeksa:" + reader.GetSqlInt32(3));
                        break;
                    }


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
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknite na odredjeni projekat/cas da dobijete informacije o korisniku", "Uputsvo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void DataGridCasovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Clear();

           // Provera da li je kliknuta određena ćelija, npr.ćelija u koloni sa indeksom 6
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                try
                {
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("select ImePrezime, BrojTelefona, COALESCE(Opis, 'Nema Opis') " +
                        "AS Opis, COALESCE(brindeksa, 0) AS BrIndeksa" +
                        "\r\nfrom Korisnik\r\nwhere BrojKorisnika = @id\r\n", konekcija);



                    cmd.Parameters.AddWithValue("id", DataGridCasovi.CurrentRow.Cells[6].Value.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        richTextBox1.Text += ("Ime i prezime: " + reader.GetString(0) + "\nBroj Telefona: " + reader.GetString(1) + "\nOpis: " + reader.GetString(2) + "\nBrojIndeksa:" + reader.GetSqlInt32(3));
                        break;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("greska: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    MogucaZaradaCasova(); OstvarenaZaradaCasova();
                    MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                    UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                    OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                    UkupnaUkupna();
                }
            }
        }

        private void DataGridCasovi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0) // Prilagodite indeks kolone prema vašoj situaciji
            {
                try
                {


                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Casovi " +
                        "SET UplacenoCelokupno = @novaVrednost " +
                        "WHERE SifraPomoci = @sifraPomoci", konekcija);
                    cmd.Parameters.AddWithValue("@novaVrednost", DataGridCasovi.CurrentRow.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@sifraPomoci", DataGridCasovi.CurrentRow.Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste azurirali", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ažuriranju: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    MogucaZaradaCasova(); OstvarenaZaradaCasova();
                    MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                    UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                    OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                    UkupnaUkupna();
                }
            }
            if (e.ColumnIndex == 8 && e.RowIndex >= 0) // Prilagodite indeks kolone prema vašoj situaciji
            {
                try
                {


                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Casovi " +
                        "SET Odradjeno = @novaVrednost " +
                        "WHERE SifraPomoci = @sifraPomoci", konekcija);
                    cmd.Parameters.AddWithValue("@novaVrednost", DataGridCasovi.CurrentRow.Cells[8].Value.ToString());
                    cmd.Parameters.AddWithValue("@sifraPomoci", DataGridCasovi.CurrentRow.Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste azurirali", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ažuriranju: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    MogucaZaradaCasova(); OstvarenaZaradaCasova();
                    MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                    UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                    OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                    UkupnaUkupna();
                }
            }
        }

        private void DataGridCasovi_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataGridCasovi.IsCurrentCellDirty)
            {
                DataGridCasovi.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridProjekti_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) // Prilagodite indeks kolone prema vašoj situaciji
            {
                try
                {


                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Projekti " +
                        "SET UplacenAvans = @novaVrednost " +
                        "WHERE SifraPomoci = @sifraPomoci", konekcija);
                    cmd.Parameters.AddWithValue("@novaVrednost", DataGridProjekti.CurrentRow.Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@sifraPomoci", DataGridProjekti.CurrentRow.Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste azurirali", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ažuriranju: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    MogucaZaradaCasova(); OstvarenaZaradaCasova();
                    MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                    UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                    OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                    UkupnaUkupna();
                }
            }
            if (e.ColumnIndex == 3 && e.RowIndex >= 0) // Prilagodite indeks kolone prema vašoj situaciji
            {
                try
                {


                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Projekti " +
                        "SET UplacenoCelokupno = @novaVrednost " +
                        "WHERE SifraPomoci = @sifraPomoci", konekcija);
                    cmd.Parameters.AddWithValue("@novaVrednost", DataGridProjekti.CurrentRow.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@sifraPomoci", DataGridProjekti.CurrentRow.Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste azurirali", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ažuriranju: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    MogucaZaradaCasova(); OstvarenaZaradaCasova();
                    MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                    UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                    OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                    UkupnaUkupna();
                }
            }
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) // Prilagodite indeks kolone prema vašoj situaciji
            {
                try
                {


                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Projekti " +
                        "SET Odradjeno = @novaVrednost " +
                        "WHERE SifraPomoci = @sifraPomoci", konekcija);
                    cmd.Parameters.AddWithValue("@novaVrednost", DataGridProjekti.CurrentRow.Cells[5].Value.ToString());
                    cmd.Parameters.AddWithValue("@sifraPomoci", DataGridProjekti.CurrentRow.Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste azurirali","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ažuriranju: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    MogucaZaradaCasova(); OstvarenaZaradaCasova();
                    MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                    UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                    OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                    UkupnaUkupna();
                }
            }
            
        }

        private void DataGridProjekti_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataGridProjekti.IsCurrentCellDirty)
            {
                DataGridProjekti.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void cASOVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosCasova frmUnosCasova = new frmUnosCasova();
            frmUnosCasova.ShowDialog();
            if(frmUnosCasova.c !=null)
            {
                try
                {
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("insert into Casovi(Cena, Opis,UplacenoCelokupno,Predmet,Datum,Korisnik,Vreme,Odradjeno)" +
                        "\r\nvalues (@cena,@opis, @uplaceno,@predmet,@datum,@korisnik,@vreme,@odradjeno)", konekcija);



                    cmd.Parameters.AddWithValue("cena", frmUnosCasova.c.Cena);
                    cmd.Parameters.AddWithValue("opis", frmUnosCasova.c.Opis);
                    cmd.Parameters.AddWithValue("uplaceno", frmUnosCasova.c.Uplaceno);
                    cmd.Parameters.AddWithValue("predmet", frmUnosCasova.c.Predmet);

                    cmd.Parameters.AddWithValue("datum", frmUnosCasova.c.Datum);
                    cmd.Parameters.AddWithValue("korisnik", frmUnosCasova.c.Korisnik);
                    cmd.Parameters.AddWithValue("vreme", frmUnosCasova.c.Vreme);
                    cmd.Parameters.AddWithValue("odradjeno", frmUnosCasova.c.Odradjeno);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("greska: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    MogucaZaradaCasova(); OstvarenaZaradaCasova();
                    MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                    UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                    OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                    UkupnaUkupna();
                }
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Casovi' table. You can move, or remove it, as needed.
                this.casoviTableAdapter.Fill(this.menadzer_CasovaDataSet.Casovi);
            }
          
        }

        private void pROJEKTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosProjekata frmUnosProjekata = new frmUnosProjekata();
            frmUnosProjekata.ShowDialog();
            if(frmUnosProjekata.p != null)
            {
                try
                {
                    konekcija.Open();
                    SqlCommand cmd = new SqlCommand("insert into Projekti(Rok,UplacenAvans,UplacenoCelokupno, " +
                        "Korisnik, Odradjeno,IdCene)" +
                        "\r\nvalues (@rok,@avans,@celokupno,@korisnik,@odradjeno,@idcene)", konekcija);

                    cmd.Parameters.AddWithValue("rok", frmUnosProjekata.p.Datum);
                    cmd.Parameters.AddWithValue("avans", frmUnosProjekata.p.UplacenAvans);

                    cmd.Parameters.AddWithValue("celokupno", frmUnosProjekata.p.UplacenoSkroz);
                    cmd.Parameters.AddWithValue("korisnik", frmUnosProjekata.p.Korisnik);
                    cmd.Parameters.AddWithValue("odradjeno", frmUnosProjekata.p.Odradjeno);
                    cmd.Parameters.AddWithValue("idcene", frmUnosProjekata.p.Idcene);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uspesno ste uneli projekat");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("greska: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                    MogucaZaradaCasova(); OstvarenaZaradaCasova();
                    MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                    UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                    OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                    UkupnaUkupna();
                }
                this.cenovnikProjektiTableAdapter.Fill(this.menadzer_CasovaDataSet.CenovnikProjekti);
                this.projektiTableAdapter.Fill(this.menadzer_CasovaDataSet.Projekti);
            }
            

        }

        private void kORISNIKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosKorisnika frmUnosKorisnika = new frmUnosKorisnika();
            frmUnosKorisnika.ShowDialog();
            if (frmUnosKorisnika.k != null)
            {
                try
                {
                    konekcija.Open();
                    if (frmUnosKorisnika.k.Brindeksa == "1" && frmUnosKorisnika.k.Opis == "1")
                    {
                        SqlCommand cmd = new SqlCommand("insert into Korisnik(ImePrezime,BrojTelefona)" +
                        "\r\nvalues (@ime,@broj)", konekcija);

                        cmd.Parameters.AddWithValue("ime", frmUnosKorisnika.k.Imeprezime);
                        cmd.Parameters.AddWithValue("broj", frmUnosKorisnika.k.Brojtelefona);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Uspesno ste uneli korisnika");
                    }
                    else if (frmUnosKorisnika.k.Brindeksa == "1")
                    {
                        SqlCommand cmd = new SqlCommand("insert into Korisnik(ImePrezime,BrojTelefona,Opis)" +
                        "\r\nvalues (@ime,@broj,@opis)", konekcija);

                        cmd.Parameters.AddWithValue("ime", frmUnosKorisnika.k.Imeprezime);
                        cmd.Parameters.AddWithValue("broj", frmUnosKorisnika.k.Brojtelefona);
                        cmd.Parameters.AddWithValue("opis", frmUnosKorisnika.k.Opis);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Uspesno ste uneli korisnika");
                    }
                    else if (frmUnosKorisnika.k.Opis == "1")
                    {
                        SqlCommand cmd = new SqlCommand("insert into Korisnik(BrIndeksa,ImePrezime,BrojTelefona)" +
                        "\r\nvalues (@brindeks,@ime,@broj)", konekcija);

                        cmd.Parameters.AddWithValue("ime", frmUnosKorisnika.k.Imeprezime);
                        cmd.Parameters.AddWithValue("broj", frmUnosKorisnika.k.Brojtelefona);
                        cmd.Parameters.AddWithValue("brindeks", frmUnosKorisnika.k.Brindeksa);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Uspesno ste uneli korisnika");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into Korisnik(BrIndeksa,ImePrezime,BrojTelefona,Opis)" +
                       "\r\nvalues (@brindeksa,@ime,@broj,@opis)", konekcija);



                        cmd.Parameters.AddWithValue("brindeksa", frmUnosKorisnika.k.Brindeksa);
                        cmd.Parameters.AddWithValue("ime", frmUnosKorisnika.k.Imeprezime);
                        cmd.Parameters.AddWithValue("broj", frmUnosKorisnika.k.Brojtelefona);
                        cmd.Parameters.AddWithValue("opis", frmUnosKorisnika.k.Opis);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Uspesno ste uneli korisnika");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("greska: " + ex.Message);
                }
                finally
                {
                    konekcija.Close();

                }
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
                this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Projekti' table. You can move, or remove it, as needed.
                this.projektiTableAdapter.Fill(this.menadzer_CasovaDataSet.Projekti);
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Casovi' table. You can move, or remove it, as needed.
                this.casoviTableAdapter.Fill(this.menadzer_CasovaDataSet.Casovi);
            }
            
        }

        private void sviCasoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int korisnik = (int)DataGridCasovi.CurrentRow.Cells[6].Value;
            SviCasoviKorisnika sviCasoviKorisnika = new SviCasoviKorisnika(korisnik);
            sviCasoviKorisnika.ShowDialog();


        }

        private void sviProjektiKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int korisnik = (int)DataGridProjekti.CurrentRow.Cells[4].Value;
            SviProjektiKorisnika sviProjektiKorisnika = new SviProjektiKorisnika(korisnik);
            sviProjektiKorisnika.ShowDialog();
        }

        private void kORISNIKAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IzmenaKorisnika izmenaKorisnika = new IzmenaKorisnika();
            izmenaKorisnika.ShowDialog();
        }

        private void obrisiZavrseneCasoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();

                SqlCommand komanda = new SqlCommand("delete Casovi\r\nwhere SifraPomoci=@sifrapomoci", konekcija);
                komanda.Parameters.AddWithValue("sifrapomoci", DataGridCasovi.CurrentRow.Cells[0].Value);
                komanda.ExecuteNonQuery();

                MessageBox.Show("Uspesno obrisan cas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();

                MogucaZaradaCasova(); OstvarenaZaradaCasova();
                MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                UkupnaUkupna();
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
                this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);

                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Casovi' table. You can move, or remove it, as needed.
                this.casoviTableAdapter.Fill(this.menadzer_CasovaDataSet.Casovi);
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet2.CenovnikProjekti' table. You can move, or remove it, as needed.
                this.cenovnikProjektiTableAdapter.Fill(this.menadzer_CasovaDataSet.CenovnikProjekti);
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet2.Projekti1' table. You can move, or remove it, as needed.
                this.projektiTableAdapter.Fill(this.menadzer_CasovaDataSet.Projekti);
            }
        }

        private void casoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZavrseniCasoviFrmcs zavrseniCasoviFrmcs = new ZavrseniCasoviFrmcs();
            zavrseniCasoviFrmcs.ShowDialog();  

        }

        private void obrisiZavrseneProjekteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();

                SqlCommand komanda = new SqlCommand("delete Projekti\r\nwhere SifraPomoci=@sifrapomoci", konekcija);
                komanda.Parameters.AddWithValue("sifrapomoci", DataGridProjekti.CurrentRow.Cells[0].Value);
                komanda.ExecuteNonQuery();

                MessageBox.Show("Uspesno obrisan projekat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();

                MogucaZaradaCasova(); OstvarenaZaradaCasova();
                MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
                UkupnaZaradaCasova(); UkupnaZaradaProjekata();
                OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
                UkupnaUkupna();
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
                this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);

                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Casovi' table. You can move, or remove it, as needed.
                this.casoviTableAdapter.Fill(this.menadzer_CasovaDataSet.Casovi);
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet2.CenovnikProjekti' table. You can move, or remove it, as needed.
                this.cenovnikProjektiTableAdapter.Fill(this.menadzer_CasovaDataSet.CenovnikProjekti);
                // TODO: This line of code loads data into the 'menadzer_CasovaDataSet2.Projekti1' table. You can move, or remove it, as needed.
                this.projektiTableAdapter.Fill(this.menadzer_CasovaDataSet.Projekti);
            }
        }

        private void projektiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZavrseniProjekti zavrseniProjekti = new ZavrseniProjekti();
            zavrseniProjekti.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();

                SqlCommand komanda = new SqlCommand("BEGIN TRANSACTION;\r\n\r\nINSERT INTO OdradjeniCasovi (Cena, Opis, UplacenoCelokupno, Predmet, Datum, Korisnik, Vreme, Odradjeno)\r\nSELECT Cena, Opis, UplacenoCelokupno, Predmet, Datum, Korisnik, Vreme, Odradjeno\r\nFROM casovi\r\nWHERE Odradjeno = 1 AND UplacenoCelokupno = 1;\r\n\r\nDELETE FROM casovi\r\nWHERE Odradjeno = 1 AND UplacenoCelokupno = 1;\r\n\r\nCOMMIT TRANSACTION;", konekcija);
                komanda.ExecuteNonQuery();

                MessageBox.Show("Casovi koji su odradjeni su sada u OdradjenimCasovima");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();


            }
            try
            {
                konekcija.Open();

                SqlCommand komanda = new SqlCommand("BEGIN TRANSACTION;\r\n\r\n-- Step 1: Insert the records into the OdradjeniProjekti table\r\nINSERT INTO OdradjeniProjekti (Rok, UplacenAvans, UplacenoCelokupno, Korisnik, Odradjeno, IdCene)\r\nSELECT Rok, UplacenAvans, UplacenoCelokupno, Korisnik, Odradjeno, IdCene\r\nFROM Projekti\r\nWHERE Odradjeno = 1 AND UplacenoCelokupno = 1;\r\n\r\n-- Step 2: Delete the records from the Projekti table\r\nDELETE FROM Projekti\r\nWHERE Odradjeno = 1 AND UplacenoCelokupno = 1;\r\n\r\nCOMMIT TRANSACTION;\r\n", konekcija);
                komanda.ExecuteNonQuery();

                MessageBox.Show("Projekti koji su odradjeni su sada u OdradjenimProjektima");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();



            }
            MogucaZaradaCasova(); OstvarenaZaradaCasova();
            MogucaZaradaProjekata(); OstvarenaZaradaProjekata();
            UkupnaZaradaCasova(); UkupnaZaradaProjekata();
            OstvarenaCasoviIProjekti(); MogucaCasoviIProjekti();
            UkupnaUkupna();
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.menadzer_CasovaDataSet.Korisnik);

            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet.Casovi' table. You can move, or remove it, as needed.
            this.casoviTableAdapter.Fill(this.menadzer_CasovaDataSet.Casovi);
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet2.CenovnikProjekti' table. You can move, or remove it, as needed.
            this.cenovnikProjektiTableAdapter.Fill(this.menadzer_CasovaDataSet.CenovnikProjekti);
            // TODO: This line of code loads data into the 'menadzer_CasovaDataSet2.Projekti1' table. You can move, or remove it, as needed.
            this.projektiTableAdapter.Fill(this.menadzer_CasovaDataSet.Projekti);
        }

        private void btnAktivan_Click(object sender, EventArgs e)
        {
            try
            {
                string pythonPath = @"C:\Users\Vukisha\AppData\Local\Programs\Python\Python312\python.exe";
                string scriptPath = @"C:\Users\Vukisha\Desktop\slanje\slanjeporuke.py";

                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = pythonPath,
                    Arguments = scriptPath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true, // Dodato za greške
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(start))
                {
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        MessageBox.Show(result);
                    }

                    using (var errorReader = process.StandardError)
                    {
                        string errorResult = errorReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(errorResult))
                        {
                            MessageBox.Show($"Greška iz Pythona: {errorResult}");
                            
                        }
                    }

                    process.WaitForExit(); // Čekaj da se Python proces završi
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
               
            }
        }



    }
}
