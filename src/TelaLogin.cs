using ProjetoPAV.src;
using ProjetoPAV.src.Classes;
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

        private void BtnLogar(object sender, EventArgs e)
        {
            Usuario u = new Usuario();            
            u = u.Logar(txtLogin.Text, txtSenha.Text);      
            //SQLiteBD bd = new SQLiteBD();
           // char u = bd.Logar(txtLogin.Text, txtSenha.Text);

            if (u != null)
            {
                if (u.Tipo == 'o')
                {
                    // Esconder janela login
                    this.Hide();
                    // Iniciar a execução da tela venda
                    TelaInicial venda = new TelaInicial();
                    venda.ShowDialog();
                    // Fechar a tela de login após fechar a tela venda
                    this.Close();
                }else if (u.Tipo == 'a')
                {
                    this.Hide();
                    TelaAdmin admin = new TelaAdmin();
                    admin.ShowDialog();
                    this.Close();
                }else
                {
                    MessageBox.Show("Usuário Bloqueado");
                }
            }else
            {
                MessageBox.Show("Login ou Senha inválido");
            }


           
            
        }
    }
}
