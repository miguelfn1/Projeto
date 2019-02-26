using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            num1 = Double.Parse(textBox1.Text);
            num2 = Double.Parse(textBox2.Text);

            if (rdbAdicao.Checked)
            {
                resp = num1 + num2;
                label3.Text = resp.ToString();
            }
            if (rdbSubtracao.Checked)
            {
                resp = num1 - num2;
                label3.Text = resp.ToString();
            }
            if (rdbMultiplicacao.Checked)
            {
                resp = num1 * num2;
                label3.Text = resp.ToString();
            }
            if (rdbDivisao.Checked)
            {
                resp = num1 / num2;
                label3.Text = resp.ToString();
            }

                if (num2 == 0)
            {
               
                label3.Text = resp.ToString("Impossivel dividir por 0");
            }











        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }
    }
 }
