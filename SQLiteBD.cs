using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class SQLiteBD
    {
        private const string STR_CONEXAO = "Data source=dados.db;Version=3";
        public SQLiteBD()
        {
            if (System.IO.File.Exists("dados.db"))
                CriarBD();
        }

        private void CriarBD()
        {
            SQLiteConnection conexao;
        }
    }
}
