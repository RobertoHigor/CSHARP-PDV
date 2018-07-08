using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoPAV.src.Classes;

namespace ProjetoPAV.src
{
    public partial class TelaFinal : Form
    {
        private Produto p;
        public TelaFinal()
        {
            InitializeComponent();
        }

        private void tbxTroco_TextChanged(object sender, EventArgs e)
        {
            Decimal valorPago = Convert.ToDecimal(tbxValorPago.Text);
            Decimal precoFinal = Convert.ToDecimal(tbxPrecoFinal.Text);
            Decimal total = 0;

            total = valorPago - precoFinal;
            tbxTroco.Text = total.ToString();
        }

        public string Propriedade { get; set; }

        private void TelaFinal_Load(object sender, EventArgs e)
        {
            if (!this.Propriedade.Equals(""))
            {
                tbxPrecoFinal.Text = this.Propriedade;
            }            
        }

        private void AtualizarTela()
        {
            LvwConsulta.SuspendLayout();
            int Linha = 1;
            LvwConsulta.Items.Clear();
            foreach (Produto p in p.ObterProdutos())
            {

                    ListViewItem item = new ListViewItem
                    {
                        Text = Linha.ToString(),
                        Tag = p
                    };                  

                    item.SubItems.Add(p.CodProduto.ToString());
                    item.SubItems.Add(p.Nome);
                    item.SubItems.Add(p.Descricao);
                    item.SubItems.Add(p.Quantidade.ToString());
                    item.SubItems.Add(p.Preco.ToString());

                    Linha++;
                    LvwConsulta.Items.Add(item);
                

                LvwConsulta.ResumeLayout();

            }
        }
    }
}
