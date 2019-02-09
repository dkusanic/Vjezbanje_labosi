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
        public FormRegistracija()
        {
            InitializeComponent();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if (Data.Korisnik.AutorizirajKorisnika(textBoxKorime.Text, textBoxLozinka.Text))
                MessageBox.Show("radi");
        }


    }
}
