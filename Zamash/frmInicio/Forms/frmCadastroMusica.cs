using System;
using System.Windows.Forms;

namespace frmInicio.Forms
{
    public partial class frmCadastroMusica : Form
    {
        private const int ALTURA_APOS_PASSO1 = 373;
        private ErrorProvider errors = new ErrorProvider();

        public frmCadastroMusica()
        {
            InitializeComponent();
        }

        #region [Eventos]
        private void frmCadastroMusica_Load(object sender, EventArgs e)
        {
            tbcPrincipal.TabPages.Remove(tbpPasso2);
            tbcPrincipal.TabPages.Remove(tbpPasso3);
            this.Height = 181;
        }

        private void btnGravarMusica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Música cadastrada com sucesso! ID: 0000", "Gravação", MessageBoxButtons.OK);
            MudarPasso(tbpPasso1);
            txtConfirmaAutor.Clear();
            txtConfirmaLetra.Clear();
            txtConfirmaNome.Clear();
            txtLetra.Clear();
            txtNomeAutor.Clear();
            txtNomeMusica.Clear();
        }

        private void btnAvancarParaPasso2_Click(object sender, EventArgs e)
        {
            MudarPasso(tbpPasso2);
        }

        private void btnVoltarParaPasso1_Click(object sender, EventArgs e)
        {
            MudarPasso(tbpPasso1);
        }

        private void btnAvancarParaPasso3_Click(object sender, EventArgs e)
        {
            MudarPasso(tbpPasso3);
        }

        private void btnVoltarParaPasso2_Click(object sender, EventArgs e)
        {
            MudarPasso(tbpPasso2);
        }
        #endregion [Fim Eventos]
        #region [Métodos]
        private void MudarPasso(TabPage tabPageDestino)
        {
            bool bContinua = true;
            switch (tabPageDestino.Name)
            {
                case "tbpPasso1":
                    tbcPrincipal.TabPages.Remove(tbpPasso2);
                    tbcPrincipal.TabPages.Remove(tbpPasso3);
                    tbcPrincipal.TabPages.Add(tbpPasso1);
                    this.Height = 181;
                    break;

                case "tbpPasso2":
                    if (string.IsNullOrWhiteSpace(txtNomeAutor.Text))
                    {
                        bContinua = false;
                        errors.SetError(txtNomeAutor, "Necessário informar nome do Autor");
                    }

                    if (string.IsNullOrWhiteSpace(txtNomeMusica.Text))
                    {
                        bContinua = false;
                        errors.SetError(txtNomeMusica, "Necessário informar nome da música");
                    }

                    if (bContinua)
                    {
                        errors.Clear();
                        tbcPrincipal.TabPages.Remove(tbpPasso1);
                        tbcPrincipal.TabPages.Remove(tbpPasso3);
                        tbcPrincipal.TabPages.Add(tbpPasso2);
                        this.Height = ALTURA_APOS_PASSO1;
                    }
                    break;

                case "tbpPasso3":
                    if (string.IsNullOrEmpty(txtLetra.Text))
                    {
                        bContinua = false;
                        errors.SetError(lblLetra, "Necessário informar a letra da música");
                    }

                    if (bContinua)
                    {
                        errors.Clear();
                        tbcPrincipal.TabPages.Remove(tbpPasso1);
                        tbcPrincipal.TabPages.Remove(tbpPasso2);
                        tbcPrincipal.TabPages.Add(tbpPasso3);
                        txtConfirmaAutor.Text = txtNomeAutor.Text;
                        txtConfirmaLetra.Text = txtLetra.Text;
                        txtConfirmaNome.Text = txtNomeMusica.Text;
                        this.Height = ALTURA_APOS_PASSO1;
                    }
                    break;

                default:
                    break;
            }
        }
        #endregion [Fim Métodos]

    }
}
