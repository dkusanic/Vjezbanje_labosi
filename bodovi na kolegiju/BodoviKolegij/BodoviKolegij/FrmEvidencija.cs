using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodoviKolegij
{
    public partial class FrmEvidencija : Form
    {
        public List<Predmeti> listaPredmeta = new List<Predmeti>();
        public FrmEvidencija()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Predmeti predmet = new Predmeti(textBox2.Text);
            listaPredmeta.Add(predmet);
            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPredmeta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aktivnosti aktivnost = new Aktivnosti(textBox3.Text, int.Parse(textBox4.Text));
            listaPredmeta[listBox1.SelectedIndex].listaAktivnosti.Add(aktivnost);
            listBox2.DataSource = null;
            listBox2.DataSource = listaPredmeta[listBox1.SelectedIndex].listaAktivnosti;
            listBox2.DisplayMember = "Naziv";
            listBox2.ValueMember = "Naziv";
            textBox3.Clear();
            textBox4.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPredmeta;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.DataSource = null;
            listBox2.DataSource = listaPredmeta[listBox1.SelectedIndex].listaAktivnosti;
            listBox2.DisplayMember = "Naziv";
            listBox2.ValueMember = "Naziv";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= listaPredmeta[listBox1.SelectedIndex].listaAktivnosti[listBox2.SelectedIndex].MaxBodovi)
                listaPredmeta[listBox1.SelectedIndex].listaAktivnosti[listBox2.SelectedIndex].Bodovi = int.Parse(textBox1.Text);
            else
                MessageBox.Show("Uneseni bodovi su veći od maksimalnog broja bodova!");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPredmeta;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listaPredmeta[listBox1.SelectedIndex].listaAktivnosti[listBox2.SelectedIndex].Bodovi.ToString();
        }

        private void FrmEvidencija_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPredmeta;
        }
    }
}
