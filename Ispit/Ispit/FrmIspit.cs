using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ispit
{
    public partial class FrmIspit : Form
    {
        public FrmIspit()
        {
            InitializeComponent();
        }

        private void FrmIspit_Load(object sender, System.EventArgs e)
        {
            PrikaziKolegije();
            PrikaziPitanja();
            Kolegij odabraniKolegij = dgvKolegiji.SelectedRows[0].DataBoundItem as Kolegij;
        }
        private void PrikaziKolegije()
        {
            List<Kolegij> listaK = Kolegij.DohvatiKolegije();
            dgvKolegiji.DataSource = listaK;
        }
        private void PrikaziPitanja()
        {
            Kolegij odabraniKolegij = dgvKolegiji.SelectedRows[0].DataBoundItem as Kolegij;            
            dgvPitanja.DataSource = odabraniKolegij.DohvatiPitanja();
        }
    }
}
