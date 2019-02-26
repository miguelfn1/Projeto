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
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
           carregaCombo();
            carregalista();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //carregaCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMostrar.Text = comboBox1.SelectedItem.ToString();
            ltbListaEstado.Text = comboBox1.SelectedItem.ToString();


        }

        private void lblEstados_Click(object sender, EventArgs e)
        {
            //carregaCombo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void frmEstados_Load(object sender, EventArgs e)
        {
            //carregaCombo();
        }
        public void carregaCombo()
        {
            



            comboBox1.Items.Clear();
            comboBox1.Items.Add("São paulo");
            comboBox1.Items.Add("Rio de Janeiro");
            comboBox1.Items.Add("Acre");
            comboBox1.Items.Add("Manaus");
            comboBox1.Items.Add("Pernambuco");
            comboBox1.Items.Add("Parana");
            comboBox1.Items.Add("Sergipe");
            comboBox1.Items.Add("Minas gerais");
        }

        private void ltbListaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMostrar2.Text = ltbListaEstado.SelectedItem.ToString();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {

            carregalista();
        }
        public void carregalista()
        {
            ltbListaEstado.Items.Clear();
            ltbListaEstado.Items.Add("São paulo");
            ltbListaEstado.Items.Add("Rio de janeiro");
            ltbListaEstado.Items.Add("Acre");
            ltbListaEstado.Items.Add("Parana");
            ltbListaEstado.Items.Add("Minas gerais");
            ltbListaEstado.Items.Add("Manaus");
            ltbListaEstado.Items.Add("Pernambuco");
            ltbListaEstado.Items.Add("Sergipe");
        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregalabel_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = comboBox1.Text.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblRetorno.Text = "Masculino";
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            lblRetorno.Text = "Feminino";
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            if (rdbFeminino.Checked)
            {
                MessageBox.Show("Você escolheu Feminino!!!!");
            }
            if (rdbMasculino.Checked)
            {
                MessageBox.Show("Você escolheu Masculino!!!!");
            }
        }
        
    }
}
