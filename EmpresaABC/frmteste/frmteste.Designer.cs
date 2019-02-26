namespace frmteste
{
    partial class frmteste
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
            this.lblEscolha = new System.Windows.Forms.Label();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.txtEscolha = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(55, 43);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(173, 17);
            this.lblEscolha.TabIndex = 0;
            this.lblEscolha.Text = "Escolha números de 1 a 5";
            // 
            // btnEscolher
            // 
            this.btnEscolher.Location = new System.Drawing.Point(43, 224);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(133, 53);
            this.btnEscolher.TabIndex = 3;
            this.btnEscolher.Text = "Escolher";
            this.btnEscolher.UseVisualStyleBackColor = true;
            this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(232, 224);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(140, 53);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "Exibir Mensagem";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // txtEscolha
            // 
            this.txtEscolha.Location = new System.Drawing.Point(58, 81);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(135, 22);
            this.txtEscolha.TabIndex = 0;
            this.txtEscolha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(55, 128);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(49, 176);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(144, 23);
            this.btnNome.TabIndex = 2;
            this.btnNome.Text = "mostra nome";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // frmteste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 301);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEscolha);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnEscolher);
            this.Controls.Add(this.lblEscolha);
            this.Name = "frmteste";
            this.Text = "frmteste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtEscolha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnNome;
    }
}