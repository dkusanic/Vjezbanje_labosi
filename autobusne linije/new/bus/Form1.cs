using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bus
{
    public partial class Form1 : Form
    {
        List<AutobusnaLinija> busLinije = new List<AutobusnaLinija>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            var podaci = Podaci.DohvatiAUtobusneLinije();
            busLinije = AutobusnaLinija.UcitajAUtobusneLinije(podaci);
            dataGridView1.DataSource = busLinije;
        }
    }
}
