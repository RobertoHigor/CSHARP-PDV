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
        private object items;

        public object Selecteditemindex { get; private set; }

        public TelaVenda()
        {
            InitializeComponent();
            p = new Produto();       
        }

        //Botão Remover
        private void Button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= LvwConsulta.Items.Count; i++ )
            {
                if(Selecteditemindex != null)
                {
                    LvwConsulta.Items.RemoveAt(i);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {    
            //Abrir tela de consulta
            TelaConsulta consulta = new TelaConsulta();
            consulta.ShowDialog();      
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
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
            LvwConsulta.Items.Clear();
            foreach (Produto p in p.ObterProdutos())
            {
                if (txtCodProduto.Text.ToString() == p.CodProduto.ToString())
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
                    item.SubItems.Add(p.Quantidade.ToString());
                    item.SubItems.Add(p.Preco.ToString());

                    Linha++;
                    LvwConsulta.Items.Add(item);
                }

                LvwConsulta.ResumeLayout();

            }
        }

        //botão confirmar compra
        private void button2_Click(object sender, EventArgs e)
        {
            TelaFinal final = new TelaFinal();
            final.ShowDialog();

            TelaFinal destino = new TelaFinal();
            destino.Propriedade = txtSubTotal.Text;
            destino.Show();            
        }
    }
}
