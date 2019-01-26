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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MyColor boja = new MyColor((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, textBoxName.Text.ToString());
            colors.Add(boja);
            var list = new BindingList<MyColor>(colors);
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
        }
    }
}
