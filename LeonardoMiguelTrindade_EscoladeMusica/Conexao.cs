using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardoMiguelTrindade_EscoladeMusica
{
    internal class Conexao
    {
        private const string StringConexao = "Server=localhost;Port=3306;Database=escola_de_musica;User ID=root;Password=Leo011210@;";

        public static MySqlConnection Abrir()
        {
            MySqlConnection conexao = new MySqlConnection(StringConexao);
            conexao.Open();

            return conexao;
        }
    }
}
