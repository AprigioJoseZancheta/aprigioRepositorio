using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_Calculo
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        double numero2 = 0;
        double calculo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Converter();
            calculo = numero1 + numero2;
            tb_Resultado.Text = calculo.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Converter();
            calculo = numero1 - numero2;
            tb_Resultado.Text = calculo.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Converter();
            calculo = numero1 * numero2;
            tb_Resultado.Text = calculo.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Converter();
            calculo = numero1 / numero2;
            tb_Resultado.Text = calculo.ToString();
        }
        private void Converter()
        {
            try
            {
                numero1 = double.Parse(tb_numero1.Text);
                numero2 = double.Parse(tb_numero2.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivél converter, erro" + erro);
            }
        } 
    }
}
