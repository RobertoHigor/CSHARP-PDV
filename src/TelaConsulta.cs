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
    public partial class TelaConsulta : Form
    {
        private Produto p;       
        public TelaConsulta()
        {
            InitializeComponent();          
            p = new Produto();
            tbxFiltro.Text = "";
            AtualizarTela();
        }

        //Botão de consultar
        private void Button1_Click(object sender, EventArgs e)
        {
            // Executa o método de atualizar a tela
            AtualizarTela();
        }

        private bool PassaFiltro(Produto p, string filtro)
        {
            // retornar os produtos que contem o código ou o nome do filtro
            return p.CodProduto.ToString().Contains(filtro) || p.Nome.Trim().Contains(filtro);
        }

        private void AtualizarTela()
        {
            // Filtro utilizado para a pesquisa
            string filtro = tbxFiltro.Text.Trim().ToLower();
            lvwProdutos.SuspendLayout();
            // Começando na linha 1
            int Linha = 1;            
            lvwProdutos.Items.Clear();
            foreach(Produto p in p.ObterProdutos())
            {
                if (string.IsNullOrEmpty(filtro) || PassaFiltro(p, filtro))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = Linha.ToString();
                    item.Tag = p;

                    //Add as colunas do item
                    item.SubItems.Add(p.CodProduto.ToString());
                    item.SubItems.Add(p.Nome);
                    item.SubItems.Add(p.Descricao);
                    item.SubItems.Add(p.Preco.ToString());
                    item.SubItems.Add(p.Quantidade.ToString());

                    Linha++;
                    lvwProdutos.Items.Add(item);
                }

                lvwProdutos.ResumeLayout();

            }
        }
    }
}
