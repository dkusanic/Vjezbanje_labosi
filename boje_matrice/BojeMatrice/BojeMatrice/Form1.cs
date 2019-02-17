using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BojeMatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Panel[,] matrix;
            List<Panel> listaPanela = new List<Panel>();
            for (int i=0; i<int.Parse(nudSirina.Value.ToString()); i++)
            {
                for (int j=0; j<int.Parse(nudVisina.Value.ToString()); j++)
                {
                    matrix = new Panel[i, j];
                    matrix[i, j].Location = new Point(12+50*i, 107+50*j);
                    matrix[i, j].Size = new Size(50, 50);
                }
            }
        }
        private void help(object sender, HelpEventArgs e)
        {
            Help.ShowHelp(this, "helpfile.chm", HelpNavigator.TopicId, "1234");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }
    }
}
