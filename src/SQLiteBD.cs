using ProjetoPAV.src.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace ProjetoPAV
{
    public class SQLiteBD
    {
        private const string STR_CONEXAO = "Data Source=dados.bd;Version=3";
        public SQLiteBD()
        {
            if (!System.IO.File.Exists("dados.bd"))
                CriarBD();
        }

        private void CriarBD()
        {
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE Usuario (" +
                        "login VARCHAR(30) NOT NULL," +
                        "senha VARCHAR(30) NOT NULL," +
                        "nome VARCHAR(100) NOT NULL," +
                        "tipo CHAR(1) NOT NULL," +
                        "CPF INT NOT NULL," +
                        "PRIMARY KEY(login, CPF)); ";                   
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE Produto (" +
                        "codProduto INT NOT NULL," +
                        "nome VARCHAR(30) NOT NULL," +
                        "descricao VARCHAR(100) NULL," +
                        "preco FLOAT NOT NULL," +
                        "quantidade INT NOT NULL," +                        
                        "PRIMARY KEY(codProduto));";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE Pedido (" +
                        "idPedido INT NOT NULL AUTO_INCREMENT," +
                        "login VARCHAR(30) NOT NULL," +
                        "codProduto INT NOT NULL," +
                        "quantidade VARCHAR(45) NOT NULL," +
                        "PRIMARY KEY(idPedido)); ";

                    cmd.ExecuteNonQuery();
                    //Criar tabela de compra associando operador e produtos
                    //ver como vai ser feito a lista de cancelamentos (botão de remover uma compra ja feita?)

                }
                conexao.Close();
            }
        }

        //Obter as disciplinas
        public ICollection<Produto> obterDisciplinas()
        {
            List<Produto> L = new List<Produto>();
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "select codProduto, nome, descricao, preco, quantidade from Produto order by nome";
                    IDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Produto p = new Produto();
                        p.CodProduto = r.GetInt32(0);
                        p.Nome = r.GetString(1);
                        p.Descricao = r.GetString(2);
                        p.Preco = r.GetFloat(3);
                        p.Quantidade = r.GetInt32(4);
                        L.Add(p);
                    }
                }
                conexao.Close();
            }
            return L;
        }
        
        public Produto obterDisciplina(string codProduto)
        {
            Produto p = null;
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "select codProduto, nome, descricao, preco, quantidade from Produto WHERE codProduto=@codProduto";
                    cmd.Prepare();
                    addParametro(cmd, "@codProduto", codProduto);
                    IDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        p = new Produto();
                        p.CodProduto = r.GetInt32(0);
                        p.Nome = r.GetString(1);
                        p.Descricao = r.GetString(2);
                        p.Preco = r.GetFloat(3);
                        p.Quantidade = r.GetInt32(4);
                    }
                }
                conexao.Close();
            }
            return p;
        }
        
        private void addParametro(IDbCommand cmd, String Campo, object valor)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = Campo;
            param.Value = valor;
            cmd.Parameters.Add(param);
        }
        
        /*
        public void inserir(Disciplina D)
        {
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "insert into disciplina (Nome, Nota1, Nota2) values (@Nome, @Nota1, @Nota2)";
                    cmd.Prepare();
                    addParametro(cmd, "@Nome", D.Nome);
                    addParametro(cmd, "@Nota1", D.Nota1);
                    addParametro(cmd, "@Nota2", D.Nota2);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        public void remover(string Nome)
        {
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "delete from disciplina where Nome=@Nome";
                    cmd.Prepare();
                    addParametro(cmd, "@Nome", Nome);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }
        public void removerTudo()
        {
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "delete from disciplina";
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }
        public void alterar(string Nome, Disciplina D)
        {
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "update disciplina set Nome=@Nome, Nota1=@Nota1, Nota2=@Nota2 where Nome=@NomeAntigo";
                    cmd.Prepare();
                    addParametro(cmd, "@Nome", D.Nome);
                    addParametro(cmd, "@Nota1", D.Nota1);
                    addParametro(cmd, "@Nota2", D.Nota2);
                    addParametro(cmd, "@NomeAntigo", Nome);
                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }*/
    }
}
