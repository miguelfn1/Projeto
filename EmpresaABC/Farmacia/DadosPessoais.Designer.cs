namespace Farmacia
{
    partial class lblDadosPessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblDadosPessoais));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ckbCrianca = new System.Windows.Forms.CheckBox();
            this.ckbJovem = new System.Windows.Forms.CheckBox();
            this.ckbAdulto = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.ltbEscolha = new System.Windows.Forms.ListBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            // 
            // lblCargo
            // 
            resources.ApplyResources(this.lblCargo, "lblCargo");
            this.lblCargo.Name = "lblCargo";
            // 
            // lblTelefone
            // 
            resources.ApplyResources(this.lblTelefone, "lblTelefone");
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDepartamento
            // 
            resources.ApplyResources(this.lblDepartamento, "lblDepartamento");
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // txtCargo
            // 
            resources.ApplyResources(this.txtCargo, "txtCargo");
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // txtTelefone
            // 
            resources.ApplyResources(this.txtTelefone, "txtTelefone");
            this.txtTelefone.Name = "txtTelefone";
            // 
            // cboDepartamento
            // 
            resources.ApplyResources(this.cboDepartamento, "cboDepartamento");
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            resources.GetString("cboDepartamento.Items"),
            resources.GetString("cboDepartamento.Items1"),
            resources.GetString("cboDepartamento.Items2"),
            resources.GetString("cboDepartamento.Items3")});
            this.cboDepartamento.Name = "cboDepartamento";
            // 
            // lblDados
            // 
            resources.ApplyResources(this.lblDados, "lblDados");
            this.lblDados.Name = "lblDados";
            this.lblDados.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ckbCrianca
            // 
            resources.ApplyResources(this.ckbCrianca, "ckbCrianca");
            this.ckbCrianca.Name = "ckbCrianca";
            this.ckbCrianca.UseVisualStyleBackColor = true;
            // 
            // ckbJovem
            // 
            resources.ApplyResources(this.ckbJovem, "ckbJovem");
            this.ckbJovem.Name = "ckbJovem";
            this.ckbJovem.UseVisualStyleBackColor = true;
            // 
            // ckbAdulto
            // 
            resources.ApplyResources(this.ckbAdulto, "ckbAdulto");
            this.ckbAdulto.Name = "ckbAdulto";
            this.ckbAdulto.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            resources.ApplyResources(this.lblTipo, "lblTipo");
            this.lblTipo.Name = "lblTipo";
            // 
            // rdbFeminino
            // 
            resources.ApplyResources(this.rdbFeminino, "rdbFeminino");
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            resources.ApplyResources(this.rdbMasculino, "rdbMasculino");
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblSexo
            // 
            resources.ApplyResources(this.lblSexo, "lblSexo");
            this.lblSexo.Name = "lblSexo";
            // 
            // ltbEscolha
            // 
            this.ltbEscolha.FormattingEnabled = true;
            this.ltbEscolha.Items.AddRange(new object[] {
            resources.GetString("ltbEscolha.Items"),
            resources.GetString("ltbEscolha.Items1"),
            resources.GetString("ltbEscolha.Items2"),
            resources.GetString("ltbEscolha.Items3"),
            resources.GetString("ltbEscolha.Items4")});
            resources.ApplyResources(this.ltbEscolha, "ltbEscolha");
            this.ltbEscolha.Name = "ltbEscolha";
            this.ltbEscolha.SelectedIndexChanged += new System.EventHandler(this.ltbEscolha_SelectedIndexChanged);
            // 
            // lblEscolha
            // 
            resources.ApplyResources(this.lblEscolha, "lblEscolha");
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblDadosPessoais
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.ltbEscolha);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.ckbAdulto);
            this.Controls.Add(this.ckbJovem);
            this.Controls.Add(this.ckbCrianca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lblDadosPessoais";
            this.Load += new System.EventHandler(this.DadosPessoais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckBox ckbCrianca;
        private System.Windows.Forms.CheckBox ckbJovem;
        private System.Windows.Forms.CheckBox ckbAdulto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ListBox ltbEscolha;
        private System.Windows.Forms.Label lblEscolha;
    }
}