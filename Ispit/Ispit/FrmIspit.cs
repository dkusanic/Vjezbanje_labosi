using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ispit
{
    public partial class FrmIspit : Form
    {
        Kolegij odabraniKolegij;
        List<Kolegij> listaK = Kolegij.DohvatiKolegije();
        public FrmIspit()
        {            
            InitializeComponent();
        }

        private void FrmIspit_Load(object sender, System.EventArgs e)
        {
            PrikaziKolegije();
            PrikaziPitanja();


        }
        private void PrikaziKolegije()
        {            
            dgvKolegiji.DataSource = listaK;
        }
        private void PrikaziPitanja()
        {
            foreach (Kolegij k in listaK)
            {
                if (odabraniKolegij.Id == k.Id)
                    dgvPitanja.DataSource = k.DohvatiPitanja();

            }
        }

        private void dgvKolegiji_SelectionChanged(object sender, System.EventArgs e)
        {
            odabraniKolegij = (Kolegij)dgvKolegiji.CurrentRow.DataBoundItem;
            PrikaziPitanja();
        }
    }
}
