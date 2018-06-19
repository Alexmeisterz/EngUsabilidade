using frmInicio.Forms;
using System;
using System.Windows.Forms;

namespace frmInicio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            new frmPesquisarMusica().ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadastroMusica().ShowDialog();
        }
    }
}
