using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RegistracijaVozila
{
    public partial class FormRegistracija : Form
    {
        Data.Vozila novoVozilo = Data.Vozila.dohvatiObjektVozila();
        public FormRegistracija()
        {
            InitializeComponent();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if (Data.Korisnik.AutorizirajKorisnika(textBoxKorime.Text, textBoxLozinka.Text))
            {
                groupBoxDodajVozilo.Enabled = true;
                groupBoxPregledVozila.Enabled = true;
                UcitajPodatke();
            }
            else
                MessageBox.Show("Krivo korisničko ime i/ili lozinka!\nPokušajte ponovno!");
        }

        private void FormRegistracija_Load(object sender, EventArgs e)
        {
            groupBoxDodajVozilo.Enabled = false;
            groupBoxPregledVozila.Enabled = false;
        }
        private void UcitajPodatke()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = novoVozilo.DohvatiSvaVozila();
            dataGridView1.DataSource = bs;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            //public void DodajVozilo(string ImeVlasnika, string PrezimeVlasnika, int GodisteVozila, string BrojSasije, int SnagaVozila, int Zapremnina, string TipGoriva, float CO2Emisije, DateTime VrijemeRegistracije)
            novoVozilo.DodajVozilo(textBoxImeVlasnika.Text, textBoxPrezimeVlasnika.Text, int.Parse(textBoxGodisteVozila.Text), textBoxBrojSasije.Text, int.Parse(textBoxSnagaVozila.Text), int.Parse(textBoxZapremnina.Text), comboBoxTipGoriva.Text, float.Parse(textBoxCO2.Text), DateTime.Today);
            UcitajPodatke();
        }
    }
}
