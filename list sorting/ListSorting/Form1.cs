﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSorting
{
    public partial class Form1 : Form
    {
        List<User> lista = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] iprezime = textBoxNameLastName.Text.Split(' ');
            User unos = new User(iprezime[0].ToString(), iprezime[1].ToString());
            lista.Add(unos);
            textBoxNameLastName.Clear();
            RefreshList();
        }
        private void RefreshList()
        {
            listBoxPopis.DataSource = null;
            listBoxPopis.Items.Clear();
            listBoxPopis.DataSource = lista;
        }

        private void buttonSortName_Click(object sender, EventArgs e)
        {
            var listaName = lista.OrderBy(obj => obj.Name).ToList();
            listBoxPopis.DataSource = null;
            listBoxPopis.Items.Clear();
            listBoxPopis.DataSource = listaName;
        }

        private void buttonSortLastname_Click(object sender, EventArgs e)
        {
            var listaLast = lista.OrderBy(obj => obj.Lastname).ToList();
            listBoxPopis.DataSource = null;
            lista.OrderBy(obj => obj.Lastname).ToList();
            listBoxPopis.Items.Clear();
            listBoxPopis.DataSource = listaLast;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            lista.Clear();
            RefreshList();
        }
    }
}
