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
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        //Botão Remover
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            //Abrir tela de consulta
            TelaConsulta consulta = new TelaConsulta();
            consulta.ShowDialog();      
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void LvwConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
