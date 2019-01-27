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
            igra.GenerirajBrojeve();
            PrikaziGeneriraneBrojeve(igra.GeneriraniBrojevi);
        }

        private void PrikaziGeneriraneBrojeve(List<int> generiraniBrojevi)
        {
            textBoxGen1.Text = igra.GeneriraniBrojevi[0].ToString();
            textBoxGen2.Text = igra.GeneriraniBrojevi[1].ToString();
            textBoxGen3.Text = igra.GeneriraniBrojevi[2].ToString();
            textBoxGen4.Text = igra.GeneriraniBrojevi[3].ToString();
            textBoxGen5.Text = igra.GeneriraniBrojevi[4].ToString();
        }
        private void SakrijGeneriraneBrojeve()
        {
            textBoxGen1.Text = ""; ;
            textBoxGen2.Text = "";
            textBoxGen3.Text = "";
            textBoxGen4.Text = "";
            textBoxGen5.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            SakrijGeneriraneBrojeve();
        }

        private void buttonProvjera_Click(object sender, EventArgs e)
        {
            igra.UneseniBrojevi.Add(int.Parse(textBoxUnos1.Text));
            igra.UneseniBrojevi.Add(int.Parse(textBoxUnos2.Text));
            igra.UneseniBrojevi.Add(int.Parse(textBoxUnos3.Text));
            igra.UneseniBrojevi.Add(int.Parse(textBoxUnos4.Text));
            igra.UneseniBrojevi.Add(int.Parse(textBoxUnos5.Text));
            if (igra.ProvjeraIspravnosti())
            {
                MessageBox.Show("Točno, pogodili ste sve brojeve!");
                PrikaziGeneriraneBrojeve(igra.GeneriraniBrojevi);
            }
            else
            {
                MessageBox.Show("Netočno, pokušajte ponovno!");
                PrikaziGeneriraneBrojeve(igra.GeneriraniBrojevi);
            }

        }
    }
}
