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
            novoVozilo.DodajVozilo(textBoxImeVlasnika.Text, textBoxPrezimeVlasnika.Text, int.Parse(textBoxGodisteVozila.Text), textBoxBrojSasije.Text, int.Parse(textBoxSnagaVozila.Text), int.Parse(textBoxZapremnina.Text), comboBoxTipGoriva.Text, float.Parse(textBoxCO2.Text), DateTime.Today);
            UcitajPodatke();
        }

        private void buttonObnoviReg_Click(object sender, EventArgs e)
        {
            Data.Vozilo oznacenoVozilo = dataGridView1.CurrentRow.DataBoundItem as Data.Vozilo;
            oznacenoVozilo.VrijemeRegistracije = DateTime.Today;
            UcitajPodatke();
        }

        private void comboBoxPrikaziVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPrikaziVozila.SelectedIndex)
            {
                case 0:
                    UcitajPodatke();
                    break;
                case 1:
                    UcitajPodatke(1);
                    break;
                case 2:
                    UcitajPodatke(3);
                    break;
                case 3:
                    UcitajPodatke(6);
                    break;
                case 4:
                    UcitajPodatke(12);
                    break;
            }
        }
        private void UcitajPodatke(int mjesec)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = novoVozilo.DohvatiVozilaUZadnjih(mjesec);
            dataGridView1.DataSource = bs;
        }
    }
}
