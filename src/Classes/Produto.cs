using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPAV.src.Classes
{
    //
    public class Produto
    {
        private int _codProduto;
        private string _nome;
        private float preco;
        private string descricao;
        private int quantidade;
        private SQLiteBD bd;

        public Produto()
        {
            bd = new SQLiteBD();
        }

        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public float Preco { get => preco; set => preco = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        // Executar o método da classe SQL para retornar uma coleção com todos os produtos
        public ICollection<Produto> ObterProdutos()
        {
            return bd.ObterProdutos();
        }

        // Executar o método da classe SQLite para alterar um produto
        public void AlterarProduto(int codProduto, Produto p)
        {
            bd.AlterarProduto(codProduto, p);
        }

        public void Remover(int codProduto)
        {
            bd.RemoverProduto(codProduto);
        }

        public Produto ObterProduto(int codProduto)
        {
            return bd.ObterProduto(codProduto);
        }

        public void Inserir(Produto ficha)
        {
            bd.InserirProduto(ficha);
        }

        public void InserirProdutos(List<Produto> lista, String login)
        {
            bd.InserirProdutos(lista, login);
        }
    }
}
