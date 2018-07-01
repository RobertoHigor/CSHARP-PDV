using ProjetoPAV.src.Classes;
using System;
using System.Windows.Forms;

namespace ProjetoPAV
{
    public partial class TelaAdmin : Form
    {
        private Usuario u;
        private Produto p;

        public TelaAdmin()
        {
            InitializeComponent();
            u = new Usuario();
            p = new Produto();
            tbxProdutoFiltro.Text = "";
            AtualizarTela();
        }

        private void TelaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProdutoPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private bool PassaFiltro(Produto p, string filtro)
        {
            // retornar os produtos que contem o código ou o nome do filtro
            return p.CodProduto.ToString().Contains(filtro) || p.Nome.Trim().Contains(filtro) || p.Descricao.Trim().Contains(filtro);
        }

        private bool PassaFiltro(Usuario u, string filtro)
        {
            // retornar os produtos que contem o código ou o nome do filtro
            return u.CPF.ToString().Contains(filtro) || u.Nome.Trim().Contains(filtro);
        }

        private void AtualizarTela()
        {
            // Filtro utilizado para a pesquisa
            string filtro = tbxProdutoFiltro.Text.Trim().ToLower();
            lvwProdutos.SuspendLayout();
            // Começando na linha 1
            int Linha = 1;
            lvwProdutos.Items.Clear();
            foreach (Produto p in p.ObterProdutos())
            {
                if (string.IsNullOrEmpty(filtro) || PassaFiltro(p, filtro))
                {
                    ListViewItem itemCliente = new ListViewItem
                    {
                        Text = Linha.ToString(),
                        Tag = p
                    };

                    //Add as colunas do item
                    itemCliente.SubItems.Add(p.CodProduto.ToString());
                    itemCliente.SubItems.Add(p.Nome.ToLower());
                    itemCliente.SubItems.Add(p.Descricao.ToLower());
                    itemCliente.SubItems.Add(p.Preco.ToString());
                    itemCliente.SubItems.Add(p.Quantidade.ToString());

                    Linha++;
                    lvwProdutos.Items.Add(itemCliente);
                }

                lvwProdutos.ResumeLayout();

            }

            string filtro2 = tbxUsuarioFiltro.Text.Trim().ToLower();
            lvwUsuarios.SuspendLayout();
            Linha = 1;
            lvwUsuarios.Items.Clear();
            foreach (Usuario u in u.ObterUsuarios())
            {
                if (string.IsNullOrEmpty(filtro2) || PassaFiltro(u, filtro))
                {
                    ListViewItem itemUsuario= new ListViewItem
                    {
                        Text = Linha.ToString(),
                        Tag = u
                    };

                itemUsuario.SubItems.Add(u.Nome.ToLower());
                itemUsuario.SubItems.Add(u.CPF.ToString());
                itemUsuario.SubItems.Add(u.Login.ToLower());
                itemUsuario.SubItems.Add(u.Senha.ToString());
                itemUsuario.SubItems.Add(u.Tipo.ToString());
                    //cpf, login, senha, perfil
                }
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (lvwProdutos.SelectedItems.Count == 0)
                MessageBox.Show("Selecione primeiro o produto a ser removido");
            else if (lvwProdutos.SelectedItems.Count != 1)
                MessageBox.Show("Selecione somente um produto");
            else
            {
                Produto ficha = (Produto)lvwProdutos.SelectedItems[0].Tag;
                if (MessageBox.Show("Tem certeza que deseja remover o produto " +ficha.Nome+"?", "Remover", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    p.Remover(ficha.CodProduto);
                    AtualizarTela();
                }
            }
        }
    }
}
