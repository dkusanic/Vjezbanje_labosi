using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bus_linije
{
    public partial class Form1 : Form
    {
        List<AutobusnaLinija> busLinije = new List<AutobusnaLinija>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            busLinije = AutobusnaLinija.UcitajAUtobusneLinije(Podaci.Podaci.DohvatiAUtobusneLinije());
            dataGridView1.DataSource = busLinije;
        }
    }
}
