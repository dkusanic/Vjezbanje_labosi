using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imenik
{
    public partial class Form1 : Form
    {
        List<Kontakt> listaKontakata = new List<Kontakt>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxIme.Enabled = false;
            textBoxPrezime.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxTelefon.Enabled = false;
            comboBoxGrupa.Enabled = false;
            buttonSpremi.Enabled = false;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            textBoxIme.Enabled = true;
            textBoxIme.Clear();
            textBoxPrezime.Enabled = true;
            textBoxPrezime.Clear();
            textBoxEmail.Enabled = true;
            textBoxEmail.Clear();
            textBoxTelefon.Enabled = true;
            textBoxTelefon.Clear();
            comboBoxGrupa.Enabled = true;
            buttonSpremi.Enabled = true;
            buttonDodaj.Enabled = false;
            List<string> popisGrupa = new List<string>();
            foreach (Kontakt k in listaKontakata)
            {
                string s = k.grupa.NazivGrupe;
                popisGrupa.Add(s);
            }
            comboBoxGrupa.DataSource = popisGrupa;
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            textBoxIme.Enabled = false;
            textBoxPrezime.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxTelefon.Enabled = false;
            comboBoxGrupa.Enabled = false;
            buttonSpremi.Enabled = false;
            buttonDodaj.Enabled = true;
            Kontakt noviKontakt = new Kontakt();
            noviKontakt.Ime = textBoxIme.Text.ToString();
            noviKontakt.Prezime = textBoxPrezime.Text.ToString();
            noviKontakt.Email = textBoxEmail.Text.ToString();
            noviKontakt.Telefon = textBoxTelefon.Text.ToString();
            noviKontakt.grupa = new Grupa(comboBoxGrupa.Text.ToString());
            listaKontakata.Add(noviKontakt);
            OsvjeziPrikaz();
        }
        private void OsvjeziPrikaz()
        {
            listBoxKontakti.Items.Clear();
            foreach (Kontakt k in listaKontakata)
            {
                string s = k.ToString();
                listBoxKontakti.Items.Add(s);
            }
        }

        private void PrikaziKontakt(int s)
        {
            for (int i=0; i < listaKontakata.Count(); i++)
            {
                if (s == i)
                {
                    textBoxIme.Text = listaKontakata[i].Ime;
                    textBoxPrezime.Text = listaKontakata[i].Prezime;
                    textBoxEmail.Text = listaKontakata[i].Email;
                    textBoxTelefon.Text = listaKontakata[i].Telefon;
                    comboBoxGrupa.Text = listaKontakata[i].grupa.NazivGrupe;
                }
            }
        }

        private void listBoxKontakti_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziKontakt(listBoxKontakti.SelectedIndex);
        }
    }
}
