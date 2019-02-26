using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMedia_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, calcular;
            num1 = Convert.ToDouble(txtNota1.Text);
            num2 = Convert.ToDouble(txtNota2.Text);
            num3 = Convert.ToDouble(txtNota3.Text);
            num4 = Convert.ToDouble(txtNota4.Text);

            calcular = num1 + num2 + num3 + num4;
            calcular = calcular / 4;
            lblMedia.Text = string.Format("{0}", calcular);
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
