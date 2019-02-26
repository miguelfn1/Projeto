using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            double num1, divisao;
            num1 = Convert.ToDouble(txtSalario.Text);
            divisao = num1 * 0.05;
            divisao = divisao + num1;
            lblNovo.Text = string.Format("{0:c}", divisao);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            double num1, divisao;
            num1 = Convert.ToDouble(txtSalario.Text);
            divisao = num1 * 0.10;
            divisao = divisao + num1;
            lblNovo.Text = string.Format("{0:c}", divisao);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            double num1, divisao;
            num1 = Convert.ToDouble(txtSalario.Text);
            divisao = num1 * 0.15;
            divisao = divisao + num1;
            lblNovo.Text = string.Format("{0:c}", divisao);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            double num1, divisao;
            num1 = Convert.ToDouble(txtSalario.Text);
            divisao = num1 * 0.20;
            divisao = divisao + num1;
            lblNovo.Text = string.Format("{0:c}", divisao);
        }
    }
}
