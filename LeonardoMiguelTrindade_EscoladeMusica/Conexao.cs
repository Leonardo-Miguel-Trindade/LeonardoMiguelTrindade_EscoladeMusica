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
        //Este método retorna uma conexão aberta com o banco de dados MySQL.
        public static MySqlConnection GetConexao()
        {
            var conexao = (MySqlConnection)null;
            try
            {
                string strconexao = "server=localhost;port=3306;user id=escola_app;password=;database=escola_de_musica";
                conexao = new MySqlConnection(strconexao);
                MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso!");
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            
            return conexao;
        }

        //Este método cria o banco de dados "escola_de_musica" caso ele não exista.
        public static MySqlCommand CreateDB() 
        {
            var command = new MySqlCommand();
            try
            {
                command = new MySqlCommand("CREATE DATABASE IF NOT EXISTS escola_de_musica", GetConexao());
                command.ExecuteNonQuery();
                MessageBox.Show("Banco de dados 'escola_de_musica' criado com sucesso!");

                GetConexao().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o banco de dados: " + ex.Message);
            }

            return command;
        }

        public static MySqlCommand CreateTables()
        {
            var command = new MySqlCommand();
            try
            {
                command = new MySqlCommand("CREATE TABLE IF NOT EXISTS alunos (\r\n    matricula INT NOT NULL,\r\n  " +
                                           "  nome VARCHAR(50) NOT NULL,\r\n    endereco VARCHAR(50) NOT NULL,\r\n " +
                                           "   cpf VARCHAR(14) NOT NULL,\r\n    telefone VARCHAR(15) NOT NULL,\r\n  " +
                                           "  instrumento VARCHAR(20) NOT NULL,\r\n    PRIMARY KEY (matricula)\r\n);", GetConexao());
                command.ExecuteNonQuery();
                GetConexao().Close();
                MessageBox.Show("Tabela 'alunos' criada com sucesso!"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a tabela: " + ex.Message);
            }

            try
            {
                command = new MySqlCommand("CREATE TABLE IF NOT EXISTS aulas (\r\n    id INT NOT NULL AUTO_INCREMENT,\r\n " +
                    "   instrumento VARCHAR(20) NOT NULL,\r\n    dia ENUM('SEGUNDA', 'TERCA', 'QUARTA', 'QUINTA', 'SEXTA') NOT NULL,\r\n " +
                    "   professor VARCHAR(50) NOT NULL,\r\n    PRIMARY KEY (id)\r\n);", GetConexao());
                command.ExecuteNonQuery();
                GetConexao().Close();
                MessageBox.Show("Tabela 'aulas' criada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a tabela: " + ex.Message);
            }

            return command;
        }
    }
}
