﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class Form1 : Form
    {
        DateTime data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data = DateTime.Now;
            lb_DataHora.Text = "Data " + data.ToLongDateString() + " Hora " + data.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChamado chamaForm = new FormChamado();
            chamaForm.Show();
        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chamaFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckBox formBox = new FormCheckBox();
            formBox.Show();
        }

        private void formMascarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMascaras formMasc = new FormMascaras();
            formMasc.Show();
        }
    }
}
