using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boje2
{
    public partial class Form1 : Form
    {
        List<MyColor> colors = new List<MyColor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_ValueChanged();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_ValueChanged();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_ValueChanged();
        }

        private void numericUpDown_ValueChanged()
        {
            panelColor.BackColor = Color.FromArgb((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }
    }
}
