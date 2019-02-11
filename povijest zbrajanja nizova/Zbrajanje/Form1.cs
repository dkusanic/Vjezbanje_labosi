﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zbrajanje
{
    public partial class Form1 : Form
    {
        int ukupnaSuma;
        List<Input> lista = new List<Input>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Input i = new Input(txtInput.Text);
            lista.Add(i);
            ukupnaSuma += i.getSum();
            txtSum.Text = ukupnaSuma.ToString();
            listBox1.Items.Add(i.ToString());
        }
    }
}
