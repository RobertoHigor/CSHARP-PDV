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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        //Preencher a tela com os dados do objeto
        private void AtualizarTela(Produto p)
        {
            tbxCodProduto.Text = p.CodProduto.ToString();
            tbxNome.Text = p.Nome;
            tbxPreco.Text = p.Preco.ToString();
            tbxDescricao.Text = p.Descricao;
            tbxQuantidade.Text = p.Quantidade.ToString();
        }

        // Pegar os dados dos campos e colocar no objeto
        private void AtualizarObjeto(Produto p)
        {
            p.CodProduto = Convert.ToInt32(tbxCodProduto.Text);
            p.Nome = tbxNome.Text;
            p.Descricao = tbxDescricao.Text;
            p.Preco = Convert.ToSingle(tbxPreco.Text);
            p.Quantidade = Convert.ToInt32(tbxQuantidade.Text);
        }

        private static FrmProduto Instancia = null;
        public static bool Executar(Produto p)
        {
            if (Instancia == null)
                Instancia = new FrmProduto();
            Instancia.AtualizarTela(p);
            if (Instancia.ShowDialog() == DialogResult.OK)
            {
                Instancia.AtualizarObjeto(p);
                return true;
            }
            else
                return false;
        }
    }
}
