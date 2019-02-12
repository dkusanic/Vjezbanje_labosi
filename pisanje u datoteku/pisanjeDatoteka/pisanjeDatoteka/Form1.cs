using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace pisanjeDatoteka
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\Domac\Documents\GitHub\Vjezbanje_labosi\pisanje u datoteku\";
        string slova = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            string fileName = textBox1.Text;
            path = Path.Combine(path, fileName);
            if (!File.Exists(path))
                File.Create(path).Close();
            //File.Create(path).Close();
        }
       
        private string generator()
        {
            char[] rijec = new char[4];
            Random r = new Random();            
            for (int i=0;i<4;i++)
            {
                rijec[i] = slova[r.Next(0, slova.Length)];
            }
            return new string(rijec);
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            Process.Start(path);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string n = generator()+"\n";
            File.AppendAllText(path, n);
        }
    }
}
