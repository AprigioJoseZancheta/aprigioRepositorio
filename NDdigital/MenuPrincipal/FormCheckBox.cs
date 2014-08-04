using System;
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
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            if (cb_email.Checked == true)
            {
                MessageBox.Show("Sim, True");
            }
            else
            {
                MessageBox.Show("Não, False");
            }
        }
    }
}
