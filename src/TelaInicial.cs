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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {            
            this.Hide();           
            TelaConsulta consulta = new TelaConsulta();
            consulta.ShowDialog();           
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVenda venda = new TelaVenda();
            venda.ShowDialog();
            this.Show();
        }
    }
}
