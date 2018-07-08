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
        private List<Produto> lista;
        private int subtotal;
        private int pago;

        public TelaFinal(List<Produto> produtos, int subtotal, int pago)
        {
            p = new Produto();
            this.lista = produtos;
            this.subtotal = subtotal;
            this.pago = pago;
            InitializeComponent();
            AtualizarTela();
            
        }

        /*private void tbxTroco_TextChanged(object sender, EventArgs e)
        {
            Decimal valorPago = Convert.ToDecimal(tbxValorPago.Text);
            Decimal precoFinal = Convert.ToDecimal(tbxPrecoFinal.Text);
            Decimal total = 0;

            total = valorPago - precoFinal;
            tbxTroco.Text = total.ToString();
        }*/

        private void AtualizarTela()
        {
            LvwConsulta.SuspendLayout();            
            int Linha = 1;                    
            tbxPrecoFinal.Text = subtotal.ToString();
            tbxValorPago.Text = pago.ToString();
            tbxTroco.Text = (pago - subtotal).ToString();

            LvwConsulta.Items.Clear();
            foreach (Produto p in lista)
            {

                ListViewItem item = new ListViewItem
                {
                    Text = Linha.ToString(),
                    Tag = p
                };

                item.SubItems.Add(p.CodProduto.ToString());
                item.SubItems.Add(p.Nome);
                item.SubItems.Add(p.Descricao);
                item.SubItems.Add(p.Preco.ToString());
                item.SubItems.Add(p.Quantidade.ToString());
                

                Linha++;
                LvwConsulta.Items.Add(item);
            }
                LvwConsulta.ResumeLayout();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.InserirProdutos(lista, "OperadorTeste");
            this.Hide();
        }
    }
}
