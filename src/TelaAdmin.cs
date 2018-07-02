using ProjetoPAV.src;
using ProjetoPAV.src.Classes;
using System;
using System.Windows.Forms;

namespace ProjetoPAV
{
    public partial class TelaAdmin : Form
    {        
        public TelaAdmin()
        {
            InitializeComponent();           
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAdminProduto tela = new TelaAdminProduto();
            tela.ShowDialog();
            this.Show();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAdminUsuario tela = new TelaAdminUsuario();
            tela.ShowDialog();
            this.Show();
        }
    }
}
