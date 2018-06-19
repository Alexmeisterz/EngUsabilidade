using frmInicio.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DataLayer;

namespace frmInicio
{
    public partial class frmPesquisarMusica : Form
    {
        /// <summary>
        /// Autor
        /// Palavra(s) contida(s) na letra
        /// </summary>
        private string CampoPesquisa;
        List<Musica> musicas;
        ErrorProvider errors = new ErrorProvider();

        public frmPesquisarMusica()
        {
            InitializeComponent();
            cboPesquisarPor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboPesquisarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CampoPesquisa = Convert.ToString(cboPesquisarPor.SelectedItem);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var valorAPesquisar = txtValorPesquisa.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(this.CampoPesquisa) && !string.IsNullOrWhiteSpace(valorAPesquisar))
            {
                errors.Clear();
                this.musicas = new Musica().CriarUmaPorradaDeMusica();

                switch (this.CampoPesquisa)
                {
                    case "Autor":

                        foreach (var musica in musicas)
                            if (musica.Autor.ToLower().Contains(valorAPesquisar))
                                dtsMusicas1.MUSICAS.AddMUSICASRow(musica.Nome, musica.Autor, musica.Letra);

                        break;

                    case "Palavra(s) contida(s) na letra":

                        foreach (var musica in musicas)
                            if (musica.Nome.Contains(valorAPesquisar))
                                dtsMusicas1.MUSICAS.AddMUSICASRow(musica.Nome, musica.Autor, musica.Letra);

                        break;

                    default:
                        break;
                }

                if (dtsMusicas1.MUSICAS.Count <= 0)
                    MessageBox.Show($"Nenhuma música com \"{valorAPesquisar}\" foi encontrada!", "Absolutamente nada =( ", MessageBoxButtons.OK);
            }
            else
            {
                
                errors.SetError(txtValorPesquisa, "Preciso saber pelo que procurar!");
            }
        }

        private void frmPesquisarMusica_Load(object sender, EventArgs e)
        {
            cboPesquisarPor.SelectedIndex = 1;
        }
    }
}
