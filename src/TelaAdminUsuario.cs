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
        private Classes.Usuario usuario;
        public TelaAdminUsuario()
        {
            InitializeComponent();
            usuario = new Classes.Usuario();            
            tbxUsuarioFiltro.Text = "";
            AtualizarTela();
            
        }

        private bool PassaFiltro(Classes.Usuario u, string filtro)
        {
            // retornar os produtos que contem o código ou o nome do filtro
            return u.CPF.ToString().Contains(filtro) || u.Nome.Trim().ToLower().Contains(filtro) || u.Login.Trim().ToLower().Contains(filtro);
        }

        private void AtualizarTela()
        {
            string filtro = tbxUsuarioFiltro.Text.Trim().ToLower();
            lvwUsuarios.SuspendLayout();
            int Linha;
            Linha = 1;
            lvwUsuarios.Items.Clear();
            foreach (Classes.Usuario usuario in usuario.ObterUsuarios())
            {
                if (string.IsNullOrEmpty(filtro) || PassaFiltro(usuario, filtro))
                {
                    ListViewItem itemUsuario = new ListViewItem
                    {
                        Text = Linha.ToString(),
                        Tag = usuario
                    };

                    itemUsuario.SubItems.Add(usuario.Login.ToLower());
                    itemUsuario.SubItems.Add(usuario.Senha.ToString());
                    itemUsuario.SubItems.Add(usuario.Nome.ToLower());                                       
                    itemUsuario.SubItems.Add(usuario.Tipo.ToString());
                    itemUsuario.SubItems.Add(usuario.CPF.ToString());

                    Linha++;
                    lvwUsuarios.Items.Add(itemUsuario);
                }

                lvwUsuarios.ResumeLayout();
            }
        }

        private void BtnCadastroUsuario_Click(object sender, EventArgs e)
        {
            Classes.Usuario ficha = new Classes.Usuario();
            if (FrmUsuario.Executar(ficha))
            {
                usuario.Inserir(ficha);
                if (!PassaFiltro(ficha, tbxUsuarioFiltro.Text.Trim().ToLower()))
                    tbxUsuarioFiltro.Text = "";
                AtualizarTela();
            }
        }

        private void BtnUsuarioAlterar_Click(object sender, EventArgs e)
        {

            if (lvwUsuarios.SelectedItems.Count == 0)
                MessageBox.Show("Selecione primeiro o usuario a ser alterado");
            else if (lvwUsuarios.SelectedItems.Count != 1)
                MessageBox.Show("Selecione somente um usuario");
            else
            {
                Classes.Usuario ficha = (Classes.Usuario)lvwUsuarios.SelectedItems[0].Tag;
                if (FrmUsuario.Executar(ficha))
                {
                    usuario.Alterar(ficha.Login, ficha);
                    if (!PassaFiltro(ficha, tbxUsuarioFiltro.Text.Trim().ToLower()))
                        tbxUsuarioFiltro.Text = "";
                    AtualizarTela();
                }                
            }

        }

        private void BtnBloquearUsuario_Click(object sender, EventArgs e)
        {
            if (lvwUsuarios.SelectedItems.Count == 0)
                MessageBox.Show("Selecione primeiro o usuario a ser bloqueado");
            else if (lvwUsuarios.SelectedItems.Count != 1)
                MessageBox.Show("Selecione somente um usuario");
            else
            {
                Classes.Usuario ficha = (Classes.Usuario)lvwUsuarios.SelectedItems[0].Tag;
                if (MessageBox.Show("Tem certeza que deseja bloquear o usuario " + ficha.Nome + "?", "Remover", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usuario.Bloquear(ficha.Login);
                    AtualizarTela();
                }
            }
        }


        private void BtnRemoverUsuario_Click(object sender, EventArgs e)
        {
            if (lvwUsuarios.SelectedItems.Count == 0)
                MessageBox.Show("Selecione primeiro o usuario a ser removido");
            else if (lvwUsuarios.SelectedItems.Count != 1)
                MessageBox.Show("Selecione somente um usuario");
            else
            {
                Classes.Usuario ficha = (Classes.Usuario)lvwUsuarios.SelectedItems[0].Tag;
                if (MessageBox.Show("Tem certeza que deseja remover o usuario " + ficha.Nome + "?", "Remover", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usuario.Remover(ficha.Login);
                    AtualizarTela();
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarTela();
        }
    }
}
