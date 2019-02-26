namespace Farmacia
{
    partial class FrmTesteVariavel
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblNcompleto = new System.Windows.Forms.Label();
            this.btnBandeira = new System.Windows.Forms.Button();
            this.btnPadrao = new System.Windows.Forms.Button();
            this.lblBandeira = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(25, 58);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 50);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "&Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(25, 125);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 52);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblMostrar
            // 
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar.Location = new System.Drawing.Point(119, 58);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(171, 50);
            this.lblMostrar.TabIndex = 2;
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNcompleto
            // 
            this.lblNcompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNcompleto.Location = new System.Drawing.Point(119, 125);
            this.lblNcompleto.Name = "lblNcompleto";
            this.lblNcompleto.Size = new System.Drawing.Size(171, 52);
            this.lblNcompleto.TabIndex = 3;
            this.lblNcompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBandeira
            // 
            this.btnBandeira.Location = new System.Drawing.Point(25, 202);
            this.btnBandeira.Name = "btnBandeira";
            this.btnBandeira.Size = new System.Drawing.Size(75, 36);
            this.btnBandeira.TabIndex = 4;
            this.btnBandeira.Text = "bandeira";
            this.btnBandeira.UseVisualStyleBackColor = true;
            this.btnBandeira.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPadrao
            // 
            this.btnPadrao.Location = new System.Drawing.Point(191, 258);
            this.btnPadrao.Name = "btnPadrao";
            this.btnPadrao.Size = new System.Drawing.Size(75, 49);
            this.btnPadrao.TabIndex = 6;
            this.btnPadrao.Text = "Padrão";
            this.btnPadrao.UseVisualStyleBackColor = true;
            this.btnPadrao.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblBandeira
            // 
            this.lblBandeira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBandeira.Location = new System.Drawing.Point(119, 194);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(171, 52);
            this.lblBandeira.TabIndex = 7;
            this.lblBandeira.Text = "false";
            this.lblBandeira.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl01
            // 
            this.lbl01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl01.Location = new System.Drawing.Point(307, 140);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(32, 52);
            this.lbl01.TabIndex = 8;
            this.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmTesteVariavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 319);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lblBandeira);
            this.Controls.Add(this.btnPadrao);
            this.Controls.Add(this.btnBandeira);
            this.Controls.Add(this.lblNcompleto);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.Name = "FrmTesteVariavel";
            this.Text = "FrmTesteVariavel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblNcompleto;
        private System.Windows.Forms.Button btnBandeira;
        private System.Windows.Forms.Button btnPadrao;
        private System.Windows.Forms.Label lblBandeira;
        private System.Windows.Forms.Label lbl01;
    }
}