using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace getCountries
{
    public partial class Form1 : Form
    {

        List<Country> drzava = new List<Country>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drzava = Country.GetCountries(Services.DataService.GetCountriesList());
            dataGridView1.DataSource = drzava;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int zbrojPopulation = 0;
            int zbrojArea = 0;
            
            for (int i=0; i<dataGridView1.SelectedRows.Count; i++)
            {
                var selectedRow = dataGridView1.SelectedRows[i];
                zbrojPopulation += ((Country)selectedRow.DataBoundItem).Population;
                zbrojArea += ((Country)selectedRow.DataBoundItem).Area;
            }
            textBox1.Text = zbrojPopulation.ToString();
            textBox2.Text = zbrojArea.ToString();
        }
    }
}
