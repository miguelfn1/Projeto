using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmTesteVariavel : Form
    {
        bool bandeira = false;
        public FrmTesteVariavel()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Senac largo treze";
            lblNcompleto.Text = "Turma TI92";
            lbl01.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bandeira = true;
            lblBandeira.Text = bandeira.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            lblNcompleto.Text = "";
            bandeira = false;
            lblBandeira.Text = bandeira.ToString();
            lbl01.Text = "1";
        }
    }
}
