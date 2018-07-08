using ProjetoPAV.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoPAV.src
{
    public partial class TelaVenda : Form
    {
        private Produto p;
        private List<Produto> produtos;       

        public object Selecteditemindex { get; private set; }

        public TelaVenda()
        {
            InitializeComponent();
            p = new Produto();
            produtos = new List<Produto>();
        }

        //Botão Remover
        private void Button3_Click(object sender, EventArgs e)
        {            
            produtos.RemoveAt(LvwConsulta.SelectedIndices[0]);
            AtualizarTela();

        }

        private void Button1_Click(object sender, EventArgs e)
        {    
            //Abrir tela de consulta
            TelaConsulta consulta = new TelaConsulta();
            consulta.ShowDialog();      
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Adicionar produto na lista     
            p = new Produto();
            int codProduto = Convert.ToInt32(tbxCodProduto.Value);

            if (codProduto >= 0)
            {
                
                    p = p.ObterProduto(Convert.ToInt32(tbxCodProduto.Value));
            }
            else
                MessageBox.Show("Digite o código do produto");

            if (p != null)
            {
                for (int i = 0; i < Convert.ToInt32(txtQuantidade.Value); i++)
                    produtos.Add(p);
            }
            else
                MessageBox.Show("Código Inválido");
            AtualizarTela();
        }

        private void SomaTotal()
        {;
            Int32 soma = 0;

            foreach (ListViewItem item in LvwConsulta.Items)
            {
                soma = soma + Convert.ToInt32(item.SubItems[columnHeader1.Text]);

                txtSubTotal.Text = soma.ToString();
            }
        }

        private void AtualizarTela()
        {
            LvwConsulta.SuspendLayout();
            int Linha = 1;
            float subtotal = 0;
            txtQuantidade.Value = 1;
            LvwConsulta.Items.Clear();            
            foreach (Produto p in produtos)
            {                  
                    ListViewItem item = new ListViewItem
                    {
                        Text = Linha.ToString(),
                        Tag = p
                    };

                    txtValorUnidade.Text = p.Preco.ToString();                    

                    item.SubItems.Add(p.CodProduto.ToString());
                    item.SubItems.Add(p.Nome);
                    item.SubItems.Add(p.Descricao);
                    item.SubItems.Add(p.Preco.ToString());
                    item.SubItems.Add(p.Quantidade.ToString());                   

                    Linha++;
                    LvwConsulta.Items.Add(item);

                    subtotal += p.Preco;    
            }
                txtSubTotal.Text = subtotal.ToString();
                LvwConsulta.ResumeLayout();

            }
    

        //botão confirmar compra
        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbxPago.Text) < Convert.ToInt32(txtSubTotal.Text))
                MessageBox.Show("Valor pago não suficiente");
            else
            {
                this.Hide();
                TelaFinal destino = new TelaFinal(produtos, Convert.ToInt32(txtSubTotal.Text), Convert.ToInt32(tbxPago.Text));
                destino.ShowDialog();
            }
        }
    }
}
