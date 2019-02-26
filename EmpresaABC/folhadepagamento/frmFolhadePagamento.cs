using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folhadepagamento
{
    public partial class frmFolhadePagamento : Form
    {
        public frmFolhadePagamento()
        {
            InitializeComponent();
            carregaClube();
        }

        private void lblLuquido_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void carregaClube()

        {
            comboBox1.Items.Add("Clube A R$: 100");
            comboBox1.Items.Add("Clube B R$: 50");
            comboBox1.Items.Add("Clube C R$: 10 ");

        }

        private void btnCaucula_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox4.Text.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double menos, resu;


            menos = Convert.ToDouble(textBox4.Text);
            
        
        
            if(checkBox1.Checked)
           {
                resu = menos - 150 ;

                textBox1.Text = string.Format("{0}", resu);
            }







            }
        }
    }

