using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolozeneVjezbe
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UcitajStudente();
        }
        private List<Student> UcitajStudente()
        {
            List<Student> studenti = new List<Student>();
            string[] ucitano = File.ReadAllLines("C:\\Users\\Domac\\Documents\\GitHub\\Vjezbanje_labosi\\polozene vjezbe\\studenti.csv");
            foreach (string s in ucitano)
            {
                Student stud = new Student();
                string[] razdvojeno = s.Split(';');
                stud.KorisnickaOznaka = razdvojeno[0];
                stud.Mentor = razdvojeno[1];
                stud.PolozeneVjezbe = int.Parse(razdvojeno[2]);
                studenti.Add(stud);
            }
            return studenti;
        }

        private List<Student> UcitajStudente(string mentor)
        {
            List<Student> studenti = new List<Student>();
            string[] ucitano = File.ReadAllLines("C:\\Users\\Domac\\Documents\\GitHub\\Vjezbanje_labosi\\polozene vjezbe\\studenti.csv");
            foreach (string s in ucitano)
            {
                Student stud = new Student();
                string[] razdvojeno = s.Split(';');
                stud.KorisnickaOznaka = razdvojeno[0];
                stud.Mentor = razdvojeno[1];
                stud.PolozeneVjezbe = int.Parse(razdvojeno[2]);
                if (stud.Mentor.Contains(mentor))
                    studenti.Add(stud);
            }
            return studenti;
        }
        private List<Student> UcitajStudente(int izbor)
        {
            List<Student> studenti = new List<Student>();
            string[] ucitano = File.ReadAllLines("C:\\Users\\Domac\\Documents\\GitHub\\Vjezbanje_labosi\\polozene vjezbe\\studenti.csv");
            foreach (string s in ucitano)
            {
                Student stud = new Student();
                string[] razdvojeno = s.Split(';');
                stud.KorisnickaOznaka = razdvojeno[0];
                stud.Mentor = razdvojeno[1];
                stud.PolozeneVjezbe = int.Parse(razdvojeno[2]);
                switch(izbor)
                {
                    case 1:
                        if (stud.PolozeneVjezbe == 1)
                            studenti.Add(stud);
                        break;
                    case 2:
                        if (stud.PolozeneVjezbe == 0)
                            studenti.Add(stud);
                        break;
                }
            }
            return studenti;
        }
        private void txtMentor_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UcitajStudente(txtMentor.Text);
        }

        private void cmbVjezbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVjezbe.SelectedIndex == 0)
                dataGridView1.DataSource = UcitajStudente();
            else
                dataGridView1.DataSource = UcitajStudente(cmbVjezbe.SelectedIndex);
        }
    }
}
