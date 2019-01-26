using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boje
{
    public partial class Form1 : Form
    {
        List<Color> listaBoja = new List<Color>();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void odaberiBojuBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            odabranaBojaPnl.BackColor = colorDialog1.Color;
        }

        private void dodajBojuBtn_Click(object sender, EventArgs e)
        {
            listaBoja.Add(odabranaBojaPnl.BackColor);
            for (int i=0; i<listaBoja.Count; i++)
            {
                Panel p = new Panel();
                p.Size = new Size(15,15);
                p.Location = new Point(17 * i, 20);
                p.BackColor = listaBoja[i];
                bojeUListiGrpbx.Controls.Add(p);
            }
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            if(listaBoja.Count>0)
            {
                randomBojaPnl.BackColor = listaBoja[r.Next(listaBoja.Count)];
            }
        }
    }
}
