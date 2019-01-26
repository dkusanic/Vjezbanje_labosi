using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frekvencije_slova
{
    public partial class Form1 : Form
    {
        List<Letter> letterFreq = new List<Letter>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
            checkFreq();
            Print();
        }

        private void checkFreq()
        {
            letterFreq.Clear();
            foreach (char c in textBoxUnos.Text)
            {
                Letter l = letterFreq.FirstOrDefault(x => x.LetterName == c);
                if (l != null)
                {
                    l.Freq++;
                }
                else
                {
                    Letter nl = new Letter();
                    nl.Freq = 1;
                    nl.LetterName = c;
                    letterFreq.Add(nl);
                }
            }
        }
        private void Print()
        {
            textBoxIspis.Clear();
            foreach (Letter l in letterFreq.OrderByDescending(l=>l.Freq))
            {
                textBoxIspis.Text += l.LetterName + "..." + l.Freq + Environment.NewLine;
            }
        }
    }
}
