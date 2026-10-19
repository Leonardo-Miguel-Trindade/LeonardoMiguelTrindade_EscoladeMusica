using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeonardoMiguelTrindade_EscoladeMusica
{
    internal class Conexao
    {
        public static MySqlConnection GetConexao()
        {
            var conexao = (MySqlConnection)null;
            try
            {
                string strconexao = "server=localhost;port=3306;user id=escola_app;password=;database=escola_de_musica";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            
            return conexao;
        }
    }
}
