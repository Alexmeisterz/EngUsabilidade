using frmInicio.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmInicio
{
    public partial class frmPesquisarMusica : Form
    {
        private string CampoPesquisa;
        List<Musica> musicas;

        public frmPesquisarMusica()
        {
            InitializeComponent();
            cboPesquisarPor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboPesquisarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CampoPesquisa = Convert.ToString(cboPesquisarPor.SelectedItem);
        }

       
    }
}
