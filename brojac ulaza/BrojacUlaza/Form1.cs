using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrojacUlaza
{
    public partial class Form1 : Form
    {
        List<Letter> text = new List<Letter>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUnos_KeyUp(object sender, KeyEventArgs e)
        {
            listBoxIspis.DataSource = null;
            foreach (Letter l in text)
            {
                if (e.KeyCode.ToString() == l.Symbol)
                    l.Count++;
                else
                {
                    l.Symbol = e.KeyCode.ToString();
                    l.Count = 1;
                    text.Add(l);
                }                
            }
            listBoxIspis.DataSource = text;
            listBoxIspis.DisplayMember = ToString();
        }
    }
}
