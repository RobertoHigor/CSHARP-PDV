using ProjetoPAV.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPAV.src
{
    public partial class TelaAdminUsuario : Form
    {
        private Usuario usuario;
        public TelaAdminUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();            
            tbxProdutoFiltro.Text = "";
            AtualizarTela();
            
        }

        private bool PassaFiltro(Usuario u, string filtro)
        {
            // retornar os produtos que contem o código ou o nome do filtro
            return u.CPF.ToString().Contains(filtro) || u.Nome.Trim().Contains(filtro);
        }

        private void AtualizarTela()
        {
            string filtro = tbxProdutoFiltro.Text.Trim().ToLower();
            lvwUsuarios.SuspendLayout();
            int Linha;
            Linha = 1;
            lvwUsuarios.Items.Clear();
            foreach (Usuario usuario in usuario.ObterUsuarios())
            {
                if (string.IsNullOrEmpty(filtro) || PassaFiltro(usuario, filtro))
                {
                    ListViewItem itemUsuario = new ListViewItem
                    {
                        Text = Linha.ToString(),
                        Tag = usuario
                    };

                    itemUsuario.SubItems.Add(usuario.Nome.ToLower());
                    itemUsuario.SubItems.Add(usuario.CPF.ToString());
                    itemUsuario.SubItems.Add(usuario.Login.ToLower());
                    itemUsuario.SubItems.Add(usuario.Senha.ToString());
                    itemUsuario.SubItems.Add(usuario.Tipo.ToString());
                }
            }
        }

        private void BtnCadastroUsuario_Click(object sender, EventArgs e)
        {

        }

        private void BtnUsuarioAlterar_Click(object sender, EventArgs e)
        {

            if (lvwUsuarios.SelectedItems.Count == 0)
                MessageBox.Show("Selecione primeiro o produto a ser removido");
            else if (lvwUsuarios.SelectedItems.Count != 1)
                MessageBox.Show("Selecione somente um produto");
            //else
            
         }

        private void BtnBloquearUsuario_Click(object sender, EventArgs e)
        {
            if (lvwUsuarios.SelectedItems.Count == 0)
                MessageBox.Show("Selecione primeiro o produto a ser removido");
            else if (lvwUsuarios.SelectedItems.Count != 1)
                MessageBox.Show("Selecione somente um produto");
            //else
        }


        private void BtnRemoverUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarTela();
        }
    }
}
