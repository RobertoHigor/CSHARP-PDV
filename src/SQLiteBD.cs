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
                    cmd.CommandText = "create table produto(" +
                                "codigo INT not null," +
                                "nome VARCHAR(30) NOT NULL," +
                                "descrição VARCHAR(100) NULL," +
                                "preço FLOAT NOT NULL);" +

                                "create table Usuario(" +
                                "nome varchar(100) not null," +
                                "CPF varchar(15) not null," +
                                "login varchar(30) not null," +
                                "senha varchar(30) not null," +
                                "perfil varchar(15) not null);" +

                                //Criar tabela de compra associando operador e produtos
                                //ver como vai ser feito a lista de cancelamentos (botão de remover uma compra ja feita?)

                    cmd.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        /*public ICollection<Disciplina> obterDisciplinas()
        {
            List<Produtos> L = new List<Produtos>();
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "select Nome, Nota1, Nota2 from Disciplina order by nome";
                    IDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Disciplina d = new Disciplina();
                        d.Nome = r.GetString(0);
                        d.Nota1 = r.GetFloat(1);
                        d.Nota2 = r.GetFloat(2);
                        L.Add(d);
                    }
                }
                conexao.Close();
            }
            return L;
        }
        public Disciplina obterDisciplina(string Nome)
        {
            Disciplina D = null;
            using (IDbConnection conexao = new SQLiteConnection(STR_CONEXAO))
            {
                conexao.Open();
                using (IDbCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "select Nome, Nota1, Nota2 from Disciplina where nome=@nome";
                    cmd.Prepare();
                    addParametro(cmd, "@Nome", Nome);
                    IDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        D = new Disciplina();
                        D.Nome = r.GetString(0);
                        D.Nota1 = r.GetFloat(1);
                        D.Nota2 = r.GetFloat(2);
                    }
                }
                conexao.Close();
            }
            return D;
        }
        private void addParametro(IDbCommand cmd, String Campo, object valor)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = Campo;
            param.Value = valor;
            cmd.Parameters.Add(param);
        }
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
