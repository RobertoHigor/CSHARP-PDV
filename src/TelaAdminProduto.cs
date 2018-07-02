using ProjetoPAV.src.Classes;
using System;
using System.Windows.Forms;

namespace ProjetoPAV.src
{
    public partial class TelaAdminProduto : Form
    {
        private Produto p;
        public TelaAdminProduto()
        {
            InitializeComponent();
            p = new Produto();
            tbxProdutoFiltro.Text = "";
            AtualizarTela();            
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
        }

        private bool PassaFiltro(Produto p, string filtro)
        {
            // retornar os produtos que contem o código ou o nome do filtro
            return p.CodProduto.ToString().Contains(filtro) || p.Nome.Trim().Contains(filtro) || p.Descricao.Trim().Contains(filtro);
        }

        private void BtnCadastroProduto_Click(object sender, EventArgs e)
        {
            Produto ficha = new Produto();
            if (FrmProduto.Executar(ficha))
            {
                p.Inserir(ficha);
                if (!PassaFiltro(ficha, tbxProdutoFiltro.Text.Trim().ToLower()))
                    tbxProdutoFiltro.Text = "";
                AtualizarTela();
            }
        }

        private void BtnProdutoAlterar_Click(object sender, EventArgs e)
        {
            if (lvwProdutos.SelectedItems.Count == 0)
                MessageBox.Show("Selecione primeiro o produto a ser removido");
            else if (lvwProdutos.SelectedItems.Count != 1)
                MessageBox.Show("Selecione somente um produto");
            else
            {
                Produto ficha = (Produto)lvwProdutos.SelectedItems[0].Tag;
                int codProduto = ficha.CodProduto;
                if (FrmProduto.Executar(ficha))
                {
                    p.AlterarProduto(codProduto, ficha);
                    if (!PassaFiltro(ficha, tbxProdutoFiltro.Text.Trim().ToLower()))
                        tbxProdutoFiltro.Text = "";
                    AtualizarTela();
                }
            }
        }

        private void BtnProdutoPesquisar_Click_1(object sender, EventArgs e)
        {
            AtualizarTela();
        }
    }
}
