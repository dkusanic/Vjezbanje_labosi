using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boje3
{
    public partial class Form1 : Form
    {
        List<PiColor> listaBoja = new List<PiColor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PiColor boja = new PiColor(int.Parse(textBoxRed.Text), int.Parse(textBoxGreen.Text), int.Parse(textBoxBlue.Text), textBoxName.Text.ToString());
            listaBoja.Add(boja);
            var list = new BindingList<PiColor>(listaBoja);
            var source = new BindingSource(list, null);
            comboBoxBoje.DataSource = source;
            comboBoxBoje.DisplayMember = "Name";
        }

        private void comboBoxBoje_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0; i<listaBoja.Count; i++)
            {
                if (listaBoja[i] == listaBoja[comboBoxBoje.SelectedIndex])
                    panelOdabranaBoja.BackColor = Color.FromArgb(listaBoja[comboBoxBoje.SelectedIndex].Red, listaBoja[comboBoxBoje.SelectedIndex].Green, listaBoja[comboBoxBoje.SelectedIndex].Blue);
            }
        }
    }
}
