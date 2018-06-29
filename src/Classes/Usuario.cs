using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPAV.src.Classes
{
    public class Usuario
    {
        private string login;
        private string senha;
        private string nome;
        private char tipo;
        private int cpf;
        private SQLiteBD bd;

        public Usuario()
        {
            bd = new SQLiteBD();
        }

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public int CPF { get => cpf; set => cpf = value; }

        public Usuario Logar(string usuario, string login)
        {
            return bd.Logar(login, usuario);
        }
    }
}
