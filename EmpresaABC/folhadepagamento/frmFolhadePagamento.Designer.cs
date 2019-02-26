namespace folhadepagamento
{
    partial class frmFolhadePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhadePagamento));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFolha = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblLuquido = new System.Windows.Forms.Label();
            this.btnCaucula = new System.Windows.Forms.Button();
            this.lblSalario = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblClube = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblFolha
            // 
            this.lblFolha.AutoSize = true;
            this.lblFolha.Location = new System.Drawing.Point(22, 25);
            this.lblFolha.Name = "lblFolha";
            this.lblFolha.Size = new System.Drawing.Size(74, 13);
            this.lblFolha.TabIndex = 1;
            this.lblFolha.Text = "Data da Folha";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Location = new System.Drawing.Point(238, 57);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(68, 13);
            this.lblSalarioFolha.TabIndex = 2;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(212, 87);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(94, 13);
            this.lblImposto.TabIndex = 3;
            this.lblImposto.Text = "Imposto de Renda";
            // 
            // lblLuquido
            // 
            this.lblLuquido.AutoSize = true;
            this.lblLuquido.Location = new System.Drawing.Point(230, 109);
            this.lblLuquido.Name = "lblLuquido";
            this.lblLuquido.Size = new System.Drawing.Size(76, 13);
            this.lblLuquido.TabIndex = 4;
            this.lblLuquido.Text = "Salário Liquido";
            this.lblLuquido.Click += new System.EventHandler(this.lblLuquido_Click);
            // 
            // btnCaucula
            // 
            this.btnCaucula.Image = ((System.Drawing.Image)(resources.GetObject("btnCaucula.Image")));
            this.btnCaucula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaucula.Location = new System.Drawing.Point(274, 12);
            this.btnCaucula.Name = "btnCaucula";
            this.btnCaucula.Size = new System.Drawing.Size(66, 23);
            this.btnCaucula.TabIndex = 5;
            this.btnCaucula.Text = "Calcula";
            this.btnCaucula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaucula.UseVisualStyleBackColor = true;
            this.btnCaucula.Click += new System.EventHandler(this.btnCaucula_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(19, 109);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Plano de Saude (150)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblClube
            // 
            this.lblClube.AutoSize = true;
            this.lblClube.Location = new System.Drawing.Point(12, 206);
            this.lblClube.Name = "lblClube";
            this.lblClube.Size = new System.Drawing.Size(78, 13);
            this.lblClube.TabIndex = 9;
            this.lblClube.Text = "Clube de Lazer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(312, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(312, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(22, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // frmFolhadePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(448, 289);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblClube);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.btnCaucula);
            this.Controls.Add(this.lblLuquido);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lblFolha);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFolhadePagamento";
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFolha;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblLuquido;
        private System.Windows.Forms.Button btnCaucula;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblClube;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}