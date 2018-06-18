namespace frmInicio
{
    partial class frmPesquisarMusica
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
            this.txtValorPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPesquisarPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorPesquisa
            // 
            this.txtValorPesquisa.Location = new System.Drawing.Point(206, 18);
            this.txtValorPesquisa.Name = "txtValorPesquisa";
            this.txtValorPesquisa.Size = new System.Drawing.Size(516, 20);
            this.txtValorPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(281, 71);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(364, 26);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Consultar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o texto que deseja pesquisar";
            // 
            // cboPesquisarPor
            // 
            this.cboPesquisarPor.FormattingEnabled = true;
            this.cboPesquisarPor.Items.AddRange(new object[] {
            "Autor",
            "Palavra(s) contida(s) na letra"});
            this.cboPesquisarPor.Location = new System.Drawing.Point(206, 44);
            this.cboPesquisarPor.Name = "cboPesquisarPor";
            this.cboPesquisarPor.Size = new System.Drawing.Size(516, 21);
            this.cboPesquisarPor.TabIndex = 3;
            this.cboPesquisarPor.SelectedIndexChanged += new System.EventHandler(this.cboPesquisarPor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesquisar por";
            // 
            // frmPesquisarMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPesquisarPor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtValorPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPesquisarMusica";
            this.Text = "Pesquisador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPesquisarPor;
        private System.Windows.Forms.Label label2;
    }
}