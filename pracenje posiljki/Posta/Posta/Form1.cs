using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posta
{
    public partial class Form1 : Form
    {
        List<DK_Posiljka> posiljke = new List<DK_Posiljka>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postaDataSet.DK_Posiljka_dgv' table. You can move, or remove it, as needed.
            this.dK_Posiljka_dgvTableAdapter.Fill(this.postaDataSet.DK_Posiljka_dgv);

        }
        private void OsvjeziPrikaz()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = posiljke;
            dgvPosiljke.DataSource = bs;
        }
    }
}
