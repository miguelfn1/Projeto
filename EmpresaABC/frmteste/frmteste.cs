using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmteste
{
    public partial class frmteste : Form
    {
        public frmteste()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {

            if (txtEscolha.Text.Equals(""))
            {
                MessageBox.Show("Favor insira numero ");

            }
            else
            {
                String valor = "";



                switch (Convert.ToInt32(txtEscolha.Text))
                {
                    case 1:
                        valor = "1";
                        break;
                    case 2:
                        valor = "2";
                        break;
                    case 3:
                        valor = "3";
                        break;
                    case 4:
                        valor = "4";
                        break;
                    case 5:
                        valor = "5";
                        break;

                    default:
                        MessageBox.Show("Escolha um item  de 1 a 5");
                        break;
                }
                MessageBox.Show("Escolheu o item " + valor);
            }

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            double resp = 0, v1 = 50, v2 = 35;
            resp = v1 + v2;
            DialogResult mensagem = MessageBox.Show(" A soma de " + v1 + "+" + v2 + "=" + resp, " Escolha Valor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (mensagem == DialogResult.Yes)
            {
                MessageBox.Show("Você clicou no Sim");
            }
            if (mensagem == DialogResult.No)
            {
                MessageBox.Show("Você clicou no Não");
            }
            if (mensagem == DialogResult.Cancel)
            {
                MessageBox.Show("Você clicou no Cancelar");
            }
        }

        private void btnNome_Click(object sender, EventArgs e)
        { 
            string nome = "Senac";
            if (txtNome.Text.Equals(nome))
            {
                MessageBox.Show("Olá, seja bem vindo!!!");
                txtNome.Focus();
            }else
            {
                MessageBox.Show("Favor inserir o nome correto!!!");
                txtNome.Focus();
                txtNome.Clear();
            }
            }
        }
    }

