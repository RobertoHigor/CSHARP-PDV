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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        //Preencher a tela com os dados do objeto
        private void AtualizarTela(Usuario u)
        {
            tbxLogin.Text = u.Login;
            tbxNome.Text = u.Nome;
            tbxSenha.Text = u.Senha;
            tbxTipo.Text = u.Tipo.ToString();
            tbxCPF.Text = u.CPF.ToString();
        }

        // Pegar os dados dos campos e colocar no objeto
        private void AtualizarObjeto(Usuario u)
        {
                        u.Login = tbxLogin.Text;
            u.Nome = tbxNome.Text;
            u.Senha = tbxSenha.Text;
            u.Tipo = (char)tbxTipo.Text[0];
            u.CPF = Convert.ToInt64(tbxCPF.Text);
        }

        private static FrmUsuario Instancia = null;
        public static bool Executar(Usuario u)
        {
            if (Instancia == null)
                Instancia = new FrmUsuario();
            Instancia.AtualizarTela(u);
            if (Instancia.ShowDialog() == DialogResult.OK)
            {
                Instancia.AtualizarObjeto(u);
                return true;
            }
            else
                return false;
        }
    }
}
