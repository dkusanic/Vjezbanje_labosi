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
            textBoxPrezime.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxTelefon.Enabled = true;
            comboBoxGrupa.Enabled = true;
            buttonSpremi.Enabled = true;
            buttonDodaj.Enabled = false;
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
        }
    }
}
