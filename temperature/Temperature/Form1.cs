using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        List<Measurement> listaMjerenja = new List<Measurement>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Measurement novoMjerenje = new Measurement(dtpDateTime.Value, txtNaziv.Text, double.Parse(txtTemperatura.Text));
            listaMjerenja.Add(novoMjerenje);
            OsvjezavanjeListe();
            IzracunajProsjek();
        }
        private void OsvjezavanjeListe()
        {
            BindingSource bs = new BindingSource(listaMjerenja, null);
            dgvData.DataSource = bs;
        }
        private void IzracunajProsjek()
        {
            double prosjek = 0;
            foreach(Measurement m in listaMjerenja)
            {
                prosjek += m.Temperature;
            }
            prosjek = prosjek / listaMjerenja.Count;
            if (prosjek < 0)
                lblAverage.ForeColor = Color.Blue;
            if (prosjek > 0)
                lblAverage.ForeColor = Color.Red;
            lblAverage.Text = Math.Round(prosjek, 2).ToString();            
        }
    }
}
