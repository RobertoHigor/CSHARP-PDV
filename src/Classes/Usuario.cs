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
        private long cpf;
        private SQLiteBD bd;

        public Usuario()
        {
            bd = new SQLiteBD();
        }

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public long CPF { get => cpf; set => cpf = value; }

        public Usuario Logar(string usuario, string login)
        {
            return bd.Logar(login, usuario);
        }

        public ICollection<Usuario> ObterUsuarios()
        {
            return bd.ObterUsuarios();
        }

        public void Inserir(Usuario ficha)
        {
            bd.InserirUsuario(ficha);
        }

        public void Remover(string nome)
        {
            bd.RemoverUsuario(nome);
        }
        public void Alterar(string login, Usuario u)
        {
            bd.AlterarUsuario(login, u);
        }
        public void Bloquear(string login)
        {
            bd.BloquearUsuario(login);
        }
        
    }
}
