using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            busLinije = AutobusnaLinija.UcitajAUtobusneLInije(Podaci.Podaci.DohvatiAUtobusneLinije());
            dataGridView1.DataSource = busLinije;
        }
    }
}
