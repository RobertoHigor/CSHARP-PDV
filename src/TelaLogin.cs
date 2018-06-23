using ProjetoPAV.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPAV
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Esconder janela login
            this.Hide();
            // Iniciar a execução da tela venda
            TelaVenda venda = new TelaVenda();
            venda.ShowDialog();
            // Fechar a tela de login após fechar a tela venda
            this.Close();
        }
    }
}
