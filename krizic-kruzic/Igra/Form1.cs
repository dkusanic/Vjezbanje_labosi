using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igra
{
    public partial class Form1 : Form
    {
        int igrac = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            
        }
    }
}
