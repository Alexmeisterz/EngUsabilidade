namespace frmInicio.Forms
{
    partial class frmCadastroMusica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMusica));
            this.txtLetra = new System.Windows.Forms.RichTextBox();
            this.pnlLetra = new System.Windows.Forms.Panel();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpPasso1 = new System.Windows.Forms.TabPage();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnAvancarParaPasso2 = new System.Windows.Forms.Button();
            this.imgNextPrevious = new System.Windows.Forms.ImageList(this.components);
            this.lblNomeMusica = new System.Windows.Forms.Label();
            this.txtNomeMusica = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.tbpPasso2 = new System.Windows.Forms.TabPage();
            this.pblBotaoMais = new System.Windows.Forms.Panel();
            this.btnVoltarParaPasso1 = new System.Windows.Forms.Button();
            this.btnAvancarParaPasso3 = new System.Windows.Forms.Button();
            this.pnlLabelLetra = new System.Windows.Forms.Panel();
            this.lblLetra = new System.Windows.Forms.Label();
            this.tbpPasso3 = new System.Windows.Forms.TabPage();
            this.pnlConfirmarMid = new System.Windows.Forms.Panel();
            this.txtConfirmaLetra = new System.Windows.Forms.RichTextBox();
            this.pnlConfirmarBottom = new System.Windows.Forms.Panel();
            this.btnVoltarParaPasso2 = new System.Windows.Forms.Button();
            this.btnGravarMusica = new System.Windows.Forms.Button();
            this.imgGravar = new System.Windows.Forms.ImageList(this.components);
            this.pnlConfirmaTopo = new System.Windows.Forms.Panel();
            this.lblConfirmaNome = new System.Windows.Forms.Label();
            this.txtConfirmaNome = new System.Windows.Forms.TextBox();
            this.txtConfirmaAutor = new System.Windows.Forms.TextBox();
            this.lblConfirmaAutor = new System.Windows.Forms.Label();
            this.lblConfirmaRevisao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLetra.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tbpPasso1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tbpPasso2.SuspendLayout();
            this.pblBotaoMais.SuspendLayout();
            this.pnlLabelLetra.SuspendLayout();
            this.tbpPasso3.SuspendLayout();
            this.pnlConfirmarMid.SuspendLayout();
            this.pnlConfirmarBottom.SuspendLayout();
            this.pnlConfirmaTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLetra
            // 
            this.txtLetra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLetra.Location = new System.Drawing.Point(0, 0);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(800, 224);
            this.txtLetra.TabIndex = 0;
            this.txtLetra.Text = "";
            // 
            // pnlLetra
            // 
            this.pnlLetra.Controls.Add(this.txtLetra);
            this.pnlLetra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLetra.Location = new System.Drawing.Point(3, 32);
            this.pnlLetra.Name = "pnlLetra";
            this.pnlLetra.Size = new System.Drawing.Size(800, 224);
            this.pnlLetra.TabIndex = 13;
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpPasso1);
            this.tbcPrincipal.Controls.Add(this.tbpPasso2);
            this.tbcPrincipal.Controls.Add(this.tbpPasso3);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(814, 334);
            this.tbcPrincipal.TabIndex = 11;
            // 
            // tbpPasso1
            // 
            this.tbpPasso1.Controls.Add(this.pnlTop);
            this.tbpPasso1.Location = new System.Drawing.Point(4, 22);
            this.tbpPasso1.Name = "tbpPasso1";
            this.tbpPasso1.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPasso1.Size = new System.Drawing.Size(806, 308);
            this.tbpPasso1.TabIndex = 0;
            this.tbpPasso1.Text = "Passo 1 - Música e Autor";
            this.tbpPasso1.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnAvancarParaPasso2);
            this.pnlTop.Controls.Add(this.lblNomeMusica);
            this.pnlTop.Controls.Add(this.txtNomeMusica);
            this.pnlTop.Controls.Add(this.txtNomeAutor);
            this.pnlTop.Controls.Add(this.lblNomeAutor);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 112);
            this.pnlTop.TabIndex = 0;
            // 
            // btnAvancarParaPasso2
            // 
            this.btnAvancarParaPasso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAvancarParaPasso2.ImageKey = "icons8-arrow-40.png";
            this.btnAvancarParaPasso2.ImageList = this.imgNextPrevious;
            this.btnAvancarParaPasso2.Location = new System.Drawing.Point(670, 79);
            this.btnAvancarParaPasso2.Name = "btnAvancarParaPasso2";
            this.btnAvancarParaPasso2.Size = new System.Drawing.Size(111, 30);
            this.btnAvancarParaPasso2.TabIndex = 4;
            this.btnAvancarParaPasso2.UseVisualStyleBackColor = true;
            this.btnAvancarParaPasso2.Click += new System.EventHandler(this.btnAvancarParaPasso2_Click);
            // 
            // imgNextPrevious
            // 
            this.imgNextPrevious.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNextPrevious.ImageStream")));
            this.imgNextPrevious.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNextPrevious.Images.SetKeyName(0, "icons8-arrow-40.png");
            this.imgNextPrevious.Images.SetKeyName(1, "icons8-arrow-40 - Cópia.png");
            // 
            // lblNomeMusica
            // 
            this.lblNomeMusica.AutoSize = true;
            this.lblNomeMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMusica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNomeMusica.Location = new System.Drawing.Point(6, 9);
            this.lblNomeMusica.Name = "lblNomeMusica";
            this.lblNomeMusica.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.lblNomeMusica.Size = new System.Drawing.Size(180, 25);
            this.lblNomeMusica.TabIndex = 0;
            this.lblNomeMusica.Text = "Nome da música:";
            // 
            // txtNomeMusica
            // 
            this.txtNomeMusica.Location = new System.Drawing.Point(184, 14);
            this.txtNomeMusica.Name = "txtNomeMusica";
            this.txtNomeMusica.Size = new System.Drawing.Size(597, 20);
            this.txtNomeMusica.TabIndex = 1;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(184, 53);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(597, 20);
            this.txtNomeAutor.TabIndex = 3;
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNomeAutor.Location = new System.Drawing.Point(6, 47);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(163, 25);
            this.lblNomeAutor.TabIndex = 2;
            this.lblNomeAutor.Text = "Nome do Autor:";
            // 
            // tbpPasso2
            // 
            this.tbpPasso2.Controls.Add(this.pnlLetra);
            this.tbpPasso2.Controls.Add(this.pblBotaoMais);
            this.tbpPasso2.Controls.Add(this.pnlLabelLetra);
            this.tbpPasso2.Location = new System.Drawing.Point(4, 22);
            this.tbpPasso2.Name = "tbpPasso2";
            this.tbpPasso2.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPasso2.Size = new System.Drawing.Size(806, 308);
            this.tbpPasso2.TabIndex = 1;
            this.tbpPasso2.Text = "Passo 2 - Letra";
            this.tbpPasso2.UseVisualStyleBackColor = true;
            // 
            // pblBotaoMais
            // 
            this.pblBotaoMais.Controls.Add(this.btnVoltarParaPasso1);
            this.pblBotaoMais.Controls.Add(this.btnAvancarParaPasso3);
            this.pblBotaoMais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblBotaoMais.Location = new System.Drawing.Point(3, 256);
            this.pblBotaoMais.Name = "pblBotaoMais";
            this.pblBotaoMais.Size = new System.Drawing.Size(800, 49);
            this.pblBotaoMais.TabIndex = 16;
            // 
            // btnVoltarParaPasso1
            // 
            this.btnVoltarParaPasso1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVoltarParaPasso1.ImageKey = "icons8-arrow-40 - Cópia.png";
            this.btnVoltarParaPasso1.ImageList = this.imgNextPrevious;
            this.btnVoltarParaPasso1.Location = new System.Drawing.Point(0, 6);
            this.btnVoltarParaPasso1.Name = "btnVoltarParaPasso1";
            this.btnVoltarParaPasso1.Size = new System.Drawing.Size(111, 30);
            this.btnVoltarParaPasso1.TabIndex = 14;
            this.btnVoltarParaPasso1.TabStop = false;
            this.btnVoltarParaPasso1.UseVisualStyleBackColor = true;
            this.btnVoltarParaPasso1.Click += new System.EventHandler(this.btnVoltarParaPasso1_Click);
            // 
            // btnAvancarParaPasso3
            // 
            this.btnAvancarParaPasso3.ImageKey = "icons8-arrow-40.png";
            this.btnAvancarParaPasso3.ImageList = this.imgNextPrevious;
            this.btnAvancarParaPasso3.Location = new System.Drawing.Point(689, 6);
            this.btnAvancarParaPasso3.Name = "btnAvancarParaPasso3";
            this.btnAvancarParaPasso3.Size = new System.Drawing.Size(111, 30);
            this.btnAvancarParaPasso3.TabIndex = 0;
            this.btnAvancarParaPasso3.UseVisualStyleBackColor = true;
            this.btnAvancarParaPasso3.Click += new System.EventHandler(this.btnAvancarParaPasso3_Click);
            // 
            // pnlLabelLetra
            // 
            this.pnlLabelLetra.Controls.Add(this.lblLetra);
            this.pnlLabelLetra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLabelLetra.Location = new System.Drawing.Point(3, 3);
            this.pnlLabelLetra.Name = "pnlLabelLetra";
            this.pnlLabelLetra.Size = new System.Drawing.Size(800, 29);
            this.pnlLabelLetra.TabIndex = 15;
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLetra.Location = new System.Drawing.Point(3, 0);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(61, 25);
            this.lblLetra.TabIndex = 0;
            this.lblLetra.Text = "Letra";
            // 
            // tbpPasso3
            // 
            this.tbpPasso3.Controls.Add(this.pnlConfirmarMid);
            this.tbpPasso3.Controls.Add(this.pnlConfirmarBottom);
            this.tbpPasso3.Controls.Add(this.pnlConfirmaTopo);
            this.tbpPasso3.Controls.Add(this.label3);
            this.tbpPasso3.Location = new System.Drawing.Point(4, 22);
            this.tbpPasso3.Name = "tbpPasso3";
            this.tbpPasso3.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPasso3.Size = new System.Drawing.Size(806, 308);
            this.tbpPasso3.TabIndex = 2;
            this.tbpPasso3.Text = "Passo 3 - Revisão e Confirmação";
            this.tbpPasso3.UseVisualStyleBackColor = true;
            // 
            // pnlConfirmarMid
            // 
            this.pnlConfirmarMid.Controls.Add(this.txtConfirmaLetra);
            this.pnlConfirmarMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfirmarMid.Location = new System.Drawing.Point(3, 126);
            this.pnlConfirmarMid.Name = "pnlConfirmarMid";
            this.pnlConfirmarMid.Padding = new System.Windows.Forms.Padding(6, 0, 5, 0);
            this.pnlConfirmarMid.Size = new System.Drawing.Size(800, 145);
            this.pnlConfirmarMid.TabIndex = 1;
            // 
            // txtConfirmaLetra
            // 
            this.txtConfirmaLetra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmaLetra.Location = new System.Drawing.Point(6, 0);
            this.txtConfirmaLetra.Name = "txtConfirmaLetra";
            this.txtConfirmaLetra.ReadOnly = true;
            this.txtConfirmaLetra.Size = new System.Drawing.Size(789, 145);
            this.txtConfirmaLetra.TabIndex = 0;
            this.txtConfirmaLetra.Text = "";
            // 
            // pnlConfirmarBottom
            // 
            this.pnlConfirmarBottom.Controls.Add(this.btnVoltarParaPasso2);
            this.pnlConfirmarBottom.Controls.Add(this.btnGravarMusica);
            this.pnlConfirmarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConfirmarBottom.Location = new System.Drawing.Point(3, 271);
            this.pnlConfirmarBottom.Name = "pnlConfirmarBottom";
            this.pnlConfirmarBottom.Size = new System.Drawing.Size(800, 34);
            this.pnlConfirmarBottom.TabIndex = 2;
            // 
            // btnVoltarParaPasso2
            // 
            this.btnVoltarParaPasso2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVoltarParaPasso2.ImageKey = "icons8-arrow-40 - Cópia.png";
            this.btnVoltarParaPasso2.ImageList = this.imgNextPrevious;
            this.btnVoltarParaPasso2.Location = new System.Drawing.Point(7, 3);
            this.btnVoltarParaPasso2.Name = "btnVoltarParaPasso2";
            this.btnVoltarParaPasso2.Size = new System.Drawing.Size(111, 28);
            this.btnVoltarParaPasso2.TabIndex = 21;
            this.btnVoltarParaPasso2.TabStop = false;
            this.btnVoltarParaPasso2.UseVisualStyleBackColor = true;
            this.btnVoltarParaPasso2.Click += new System.EventHandler(this.btnVoltarParaPasso2_Click);
            // 
            // btnGravarMusica
            // 
            this.btnGravarMusica.ForeColor = System.Drawing.Color.Blue;
            this.btnGravarMusica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarMusica.ImageKey = "icons8-save-as-64.png";
            this.btnGravarMusica.ImageList = this.imgGravar;
            this.btnGravarMusica.Location = new System.Drawing.Point(684, 3);
            this.btnGravarMusica.Name = "btnGravarMusica";
            this.btnGravarMusica.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGravarMusica.Size = new System.Drawing.Size(111, 28);
            this.btnGravarMusica.TabIndex = 0;
            this.btnGravarMusica.Text = "Gravar!";
            this.btnGravarMusica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarMusica.UseVisualStyleBackColor = true;
            this.btnGravarMusica.Click += new System.EventHandler(this.btnGravarMusica_Click);
            // 
            // imgGravar
            // 
            this.imgGravar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgGravar.ImageStream")));
            this.imgGravar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgGravar.Images.SetKeyName(0, "icons8-save-as-64.png");
            // 
            // pnlConfirmaTopo
            // 
            this.pnlConfirmaTopo.Controls.Add(this.lblConfirmaNome);
            this.pnlConfirmaTopo.Controls.Add(this.txtConfirmaNome);
            this.pnlConfirmaTopo.Controls.Add(this.txtConfirmaAutor);
            this.pnlConfirmaTopo.Controls.Add(this.lblConfirmaAutor);
            this.pnlConfirmaTopo.Controls.Add(this.lblConfirmaRevisao);
            this.pnlConfirmaTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfirmaTopo.Location = new System.Drawing.Point(3, 3);
            this.pnlConfirmaTopo.Name = "pnlConfirmaTopo";
            this.pnlConfirmaTopo.Size = new System.Drawing.Size(800, 123);
            this.pnlConfirmaTopo.TabIndex = 0;
            // 
            // lblConfirmaNome
            // 
            this.lblConfirmaNome.AutoSize = true;
            this.lblConfirmaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblConfirmaNome.Location = new System.Drawing.Point(2, 45);
            this.lblConfirmaNome.Name = "lblConfirmaNome";
            this.lblConfirmaNome.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.lblConfirmaNome.Size = new System.Drawing.Size(180, 25);
            this.lblConfirmaNome.TabIndex = 1;
            this.lblConfirmaNome.Text = "Nome da música:";
            // 
            // txtConfirmaNome
            // 
            this.txtConfirmaNome.Location = new System.Drawing.Point(188, 50);
            this.txtConfirmaNome.Name = "txtConfirmaNome";
            this.txtConfirmaNome.ReadOnly = true;
            this.txtConfirmaNome.Size = new System.Drawing.Size(607, 20);
            this.txtConfirmaNome.TabIndex = 2;
            // 
            // txtConfirmaAutor
            // 
            this.txtConfirmaAutor.Location = new System.Drawing.Point(188, 89);
            this.txtConfirmaAutor.Name = "txtConfirmaAutor";
            this.txtConfirmaAutor.ReadOnly = true;
            this.txtConfirmaAutor.Size = new System.Drawing.Size(607, 20);
            this.txtConfirmaAutor.TabIndex = 4;
            // 
            // lblConfirmaAutor
            // 
            this.lblConfirmaAutor.AutoSize = true;
            this.lblConfirmaAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblConfirmaAutor.Location = new System.Drawing.Point(2, 83);
            this.lblConfirmaAutor.Name = "lblConfirmaAutor";
            this.lblConfirmaAutor.Size = new System.Drawing.Size(163, 25);
            this.lblConfirmaAutor.TabIndex = 3;
            this.lblConfirmaAutor.Text = "Nome do Autor:";
            // 
            // lblConfirmaRevisao
            // 
            this.lblConfirmaRevisao.AutoSize = true;
            this.lblConfirmaRevisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaRevisao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblConfirmaRevisao.Location = new System.Drawing.Point(294, 11);
            this.lblConfirmaRevisao.Name = "lblConfirmaRevisao";
            this.lblConfirmaRevisao.Size = new System.Drawing.Size(253, 25);
            this.lblConfirmaRevisao.TabIndex = 0;
            this.lblConfirmaRevisao.Text = "Revisão das informações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(6, -74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Letra";
            // 
            // frmCadastroMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 334);
            this.Controls.Add(this.tbcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.frmCadastroMusica_Load);
            this.pnlLetra.ResumeLayout(false);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpPasso1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tbpPasso2.ResumeLayout(false);
            this.pblBotaoMais.ResumeLayout(false);
            this.pnlLabelLetra.ResumeLayout(false);
            this.pnlLabelLetra.PerformLayout();
            this.tbpPasso3.ResumeLayout(false);
            this.tbpPasso3.PerformLayout();
            this.pnlConfirmarMid.ResumeLayout(false);
            this.pnlConfirmarBottom.ResumeLayout(false);
            this.pnlConfirmaTopo.ResumeLayout(false);
            this.pnlConfirmaTopo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtLetra;
        private System.Windows.Forms.Panel pnlLetra;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpPasso1;
        private System.Windows.Forms.TabPage tbpPasso2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnAvancarParaPasso2;
        private System.Windows.Forms.Label lblNomeMusica;
        private System.Windows.Forms.TextBox txtNomeMusica;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Panel pblBotaoMais;
        private System.Windows.Forms.Button btnAvancarParaPasso3;
        private System.Windows.Forms.Panel pnlLabelLetra;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.TabPage tbpPasso3;
        private System.Windows.Forms.Panel pnlConfirmarBottom;
        private System.Windows.Forms.Button btnGravarMusica;
        private System.Windows.Forms.Panel pnlConfirmaTopo;
        private System.Windows.Forms.Label lblConfirmaNome;
        private System.Windows.Forms.TextBox txtConfirmaNome;
        private System.Windows.Forms.TextBox txtConfirmaAutor;
        private System.Windows.Forms.Label lblConfirmaAutor;
        private System.Windows.Forms.Label lblConfirmaRevisao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlConfirmarMid;
        private System.Windows.Forms.ImageList imgNextPrevious;
        private System.Windows.Forms.RichTextBox txtConfirmaLetra;
        private System.Windows.Forms.ImageList imgGravar;
        private System.Windows.Forms.Button btnVoltarParaPasso1;
        private System.Windows.Forms.Button btnVoltarParaPasso2;
    }
}