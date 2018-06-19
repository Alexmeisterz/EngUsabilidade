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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarMusica));
            this.txtValorPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPesquisarPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.pnltopo = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsoMusicas = new System.Windows.Forms.BindingSource(this.components);
            this.dtsMusicas1 = new DataLayer.dtsMusicas();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.pnltopo.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoMusicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsMusicas1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorPesquisa
            // 
            this.txtValorPesquisa.Location = new System.Drawing.Point(180, 14);
            this.txtValorPesquisa.Name = "txtValorPesquisa";
            this.txtValorPesquisa.Size = new System.Drawing.Size(450, 20);
            this.txtValorPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.ImageKey = "icons8-binoculars-40.png";
            this.btnPesquisar.ImageList = this.imageList1;
            this.btnPesquisar.Location = new System.Drawing.Point(655, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(67, 47);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o texto que deseja pesquisar";
            // 
            // cboPesquisarPor
            // 
            this.cboPesquisarPor.FormattingEnabled = true;
            this.cboPesquisarPor.Items.AddRange(new object[] {
            "Autor",
            "Palavra(s) contida(s) na letra"});
            this.cboPesquisarPor.Location = new System.Drawing.Point(180, 40);
            this.cboPesquisarPor.Name = "cboPesquisarPor";
            this.cboPesquisarPor.Size = new System.Drawing.Size(450, 21);
            this.cboPesquisarPor.TabIndex = 3;
            this.cboPesquisarPor.SelectedIndexChanged += new System.EventHandler(this.cboPesquisarPor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisar por";
            // 
            // grdResultado
            // 
            this.grdResultado.AllowUserToAddRows = false;
            this.grdResultado.AllowUserToDeleteRows = false;
            this.grdResultado.AutoGenerateColumns = false;
            this.grdResultado.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.letraDataGridViewTextBoxColumn});
            this.grdResultado.DataSource = this.bsoMusicas;
            this.grdResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdResultado.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdResultado.Location = new System.Drawing.Point(0, 0);
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.Size = new System.Drawing.Size(734, 355);
            this.grdResultado.TabIndex = 0;
            // 
            // pnltopo
            // 
            this.pnltopo.Controls.Add(this.label1);
            this.pnltopo.Controls.Add(this.txtValorPesquisa);
            this.pnltopo.Controls.Add(this.label2);
            this.pnltopo.Controls.Add(this.btnPesquisar);
            this.pnltopo.Controls.Add(this.cboPesquisarPor);
            this.pnltopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltopo.Location = new System.Drawing.Point(0, 0);
            this.pnltopo.Name = "pnltopo";
            this.pnltopo.Size = new System.Drawing.Size(734, 78);
            this.pnltopo.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grdResultado);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 78);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(734, 355);
            this.pnlGrid.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-binoculars-40.png");
            this.imageList1.Images.SetKeyName(1, "icons8-search-property-64.png");
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 57;
            // 
            // letraDataGridViewTextBoxColumn
            // 
            this.letraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.letraDataGridViewTextBoxColumn.DataPropertyName = "Letra";
            this.letraDataGridViewTextBoxColumn.HeaderText = "Letra";
            this.letraDataGridViewTextBoxColumn.Name = "letraDataGridViewTextBoxColumn";
            this.letraDataGridViewTextBoxColumn.ReadOnly = true;
            this.letraDataGridViewTextBoxColumn.Width = 56;
            // 
            // bsoMusicas
            // 
            this.bsoMusicas.DataMember = "MUSICAS";
            this.bsoMusicas.DataSource = this.dtsMusicas1;
            // 
            // dtsMusicas1
            // 
            this.dtsMusicas1.DataSetName = "dtsMusicas";
            this.dtsMusicas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmPesquisarMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 433);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnltopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisarMusica";
            this.Text = "Pesquisador";
            this.Load += new System.EventHandler(this.frmPesquisarMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.pnltopo.ResumeLayout(false);
            this.pnltopo.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsoMusicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsMusicas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPesquisarPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Panel pnltopo;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn letraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsoMusicas;
        private DataLayer.dtsMusicas dtsMusicas1;
        private System.Windows.Forms.ImageList imageList1;
    }
}