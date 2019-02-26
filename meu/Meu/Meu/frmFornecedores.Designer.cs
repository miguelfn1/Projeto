namespace Meu
{
    partial class frmFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedores));
            this.pnlFornecedores = new System.Windows.Forms.Panel();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNomedoFornecedor = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.pnlFornecedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFornecedores
            // 
            this.pnlFornecedores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFornecedores.Controls.Add(this.btnCadastrar);
            this.pnlFornecedores.Controls.Add(this.btnAlterar);
            this.pnlFornecedores.Controls.Add(this.btnApagar);
            this.pnlFornecedores.Controls.Add(this.btnBuscar);
            this.pnlFornecedores.Controls.Add(this.btnNovo);
            this.pnlFornecedores.Location = new System.Drawing.Point(1, 377);
            this.pnlFornecedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFornecedores.Name = "pnlFornecedores";
            this.pnlFornecedores.Size = new System.Drawing.Size(538, 86);
            this.pnlFornecedores.TabIndex = 0;
            this.pnlFornecedores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFornecedores_Paint);
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(12, 46);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(159, 20);
            this.lblNomeFornecedor.TabIndex = 1;
            this.lblNomeFornecedor.Text = "Nome do Fornecerdor:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblEndereco.Location = new System.Drawing.Point(23, 90);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(74, 20);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblProduto.Location = new System.Drawing.Point(23, 133);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 20);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Produto:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnNovo.Location = new System.Drawing.Point(30, 20);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 37);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(124, 21);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 36);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAlterar.Location = new System.Drawing.Point(223, 20);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 36);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnApagar.Location = new System.Drawing.Point(324, 20);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 37);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnBuscar.Location = new System.Drawing.Point(426, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 35);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNomedoFornecedor
            // 
            this.txtNomedoFornecedor.Location = new System.Drawing.Point(188, 39);
            this.txtNomedoFornecedor.Name = "txtNomedoFornecedor";
            this.txtNomedoFornecedor.Size = new System.Drawing.Size(100, 27);
            this.txtNomedoFornecedor.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(125, 90);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 27);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(125, 133);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 27);
            this.txtProduto.TabIndex = 6;
            this.txtProduto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(405, 306);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 42);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPreco.Location = new System.Drawing.Point(23, 189);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(49, 20);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(125, 182);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 27);
            this.txtPreco.TabIndex = 9;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(125, 230);
            this.mtbTelefone.Mask = "(99) 99999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 27);
            this.mtbTelefone.TabIndex = 10;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 233);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 20);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone:";
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 465);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNomedoFornecedor);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNomeFornecedor);
            this.Controls.Add(this.pnlFornecedores);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedores_Load);
            this.pnlFornecedores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFornecedores;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNomedoFornecedor;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblTelefone;
    }
}