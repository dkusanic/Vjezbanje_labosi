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
            List<string> lista = new List<string>();
            foreach (PiColor b in listaBoja)
            {
                var naziv = b.Name;
                lista.Add(naziv);
            }
            var list = new BindingList<string>(lista);
            var source = new BindingSource(list, null);
            comboBoxBoje.DataSource = source;
        }
    }
}
