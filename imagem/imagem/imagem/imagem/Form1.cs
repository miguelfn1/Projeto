using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnimagem_Click(object sender, EventArgs e)
        {
            pictureBox1.Width -= 10;
            pictureBox1.Height -= 10;
            double clicar;
            clicar = Convert.ToDouble(label1.Text);
            label1.Text = string.Format("{0}", clicar + 1);
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
