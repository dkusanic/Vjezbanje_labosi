using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess
{
    public partial class FormGuessGame : Form
    {
        GuessGame igra = new GuessGame();
        public FormGuessGame()
        {
            InitializeComponent();
        }

        private void buttonNova_Click(object sender, EventArgs e)
        {
            timer1.Start();
            textBoxGen1.Text = igra.GeneriraniBrojevi[0].ToString();
            textBoxGen2.Text = igra.GeneriraniBrojevi[1].ToString();
            textBoxGen3.Text = igra.GeneriraniBrojevi[2].ToString();
            textBoxGen4.Text = igra.GeneriraniBrojevi[3].ToString();
            textBoxGen5.Text = igra.GeneriraniBrojevi[4].ToString();
        }
    }
}
