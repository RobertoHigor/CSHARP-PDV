using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPAV.src.Classes
{
    public class Produto
    {
        private int _codProduto;
        private string _nome;
        private float preco;
        private string descricao;
        private int quantidade;

        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public float Preco { get => preco; set => preco = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
