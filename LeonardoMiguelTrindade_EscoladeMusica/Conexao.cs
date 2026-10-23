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
using System.Data;

namespace LeonardoMiguelTrindade_EscoladeMusica
{
    internal class Conexao
    {
        //Este método retorna uma conexão aberta com o banco de dados MySQL.
        public static MySqlConnection GetConexao(string str)
        {
            var conexao = (MySqlConnection)null;
            try
            {
                string strconexao = str;
                conexao = new MySqlConnection(strconexao);
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
                command = new MySqlCommand("CREATE DATABASE IF NOT EXISTS escola_de_musica", GetConexao("server=localhost; user=root; password="));
                command.ExecuteNonQuery();

                GetConexao("server=localhost; user=root; password=").Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o banco de dados: " + ex.Message);
            }

            return command;
        }

        //Este método cria as tabelas "alunos" e "aulas" no banco de dados "escola_de_musica" caso elas não existam.
        public static MySqlCommand CreateTables()
        {
            var command = new MySqlCommand();
            try
            {
                command = new MySqlCommand("CREATE TABLE IF NOT EXISTS alunos (\r\n    matricula INT NOT NULL,\r\n  " +
                                           "  nome VARCHAR(50) NOT NULL,\r\n    endereco VARCHAR(100) NOT NULL,\r\n " +
                                           "   cpf VARCHAR(14) NOT NULL,\r\n    telefone VARCHAR(15) NOT NULL,\r\n  " +
                                           "  instrumento VARCHAR(20) NOT NULL,\r\n    PRIMARY KEY (matricula)\r\n);", GetConexao("server=localhost; user=root; password=; database=escola_de_musica"));
                command.ExecuteNonQuery();
                GetConexao("server=localhost; user=root; password=; database=escola_de_musica").Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a tabela 'alunos': " + ex.Message);
            }

            try
            {
                command = new MySqlCommand("CREATE TABLE IF NOT EXISTS aulas (\r\n    id INT NOT NULL AUTO_INCREMENT,\r\n " +
                    "   instrumento VARCHAR(20) NOT NULL,\r\n    dia ENUM('SEGUNDA', 'TERCA', 'QUARTA', 'QUINTA', 'SEXTA') NOT NULL,\r\n " +
                    "   professor VARCHAR(50) NOT NULL,\r\n    PRIMARY KEY (id)\r\n);", GetConexao("server=localhost; user=root; password=; database=escola_de_musica"));
                command.ExecuteNonQuery();
                GetConexao("server=localhost; user=root; password=; database=escola_de_musica").Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a tabela 'aulas': " + ex.Message);
            }

            return command;
        }

        public static MySqlCommand CadastroAula(string instrumento, string dia, string professor)
        {
            var command = new MySqlCommand();
            try
            {
                GetConexao("server=localhost; user=root; password=; database=escola_de_musica");

                try
                {
                    command = new MySqlCommand("INSERT INTO aulas (instrumento, dia, professor) VALUES (@instrumento, @dia, @professor)", GetConexao("server=localhost; user=root; password=; database=escola_de_musica"));
                    command.Parameters.AddWithValue("@instrumento", instrumento);
                    command.Parameters.AddWithValue("@dia", dia);
                    command.Parameters.AddWithValue("@professor", professor);
                    command.ExecuteNonQuery();
                    GetConexao("server=localhost; user=root; password=; database=escola_de_musica").Close();
                    MessageBox.Show("Aula cadastrada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar a aula: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro para se conectar ao banco de dados: " + ex.Message);
            }
            
            return command;
        }

        public static MySqlCommand CadastroAluno(int matricula, string nome, string endereco, string cpf, string telefone, string instumento)
        {
            var command = new MySqlCommand();
            try
            {
                GetConexao("server=localhost; user=root; password=; database=escola_de_musica");

                try
                {
                    command = new MySqlCommand("INSERT INTO alunos (matricula, nome, endereco, cpf, telefone, instrumento) " +
                        "VALUES (@matricula, @nome, @endereco, @cpf, @telefone, @instrumento)", GetConexao("server=localhost; user=root; password=; database=escola_de_musica"));
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@endereco", endereco);
                    command.Parameters.AddWithValue("@cpf", cpf);
                    command.Parameters.AddWithValue("@telefone", telefone);
                    command.Parameters.AddWithValue("@instrumento", instumento);
                    command.ExecuteNonQuery();
                    GetConexao("server=localhost; user=root; password=; database=escola_de_musica").Close();
                    MessageBox.Show("Aluno cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o aluno: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro para se conectar ao banco de dados: " + ex.Message);
            }

            return command;
        }

        public static DataTable listarAlunos()
        {
            DataTable tabela = new DataTable();

            try
            {
                GetConexao("server=localhost; user=root; password=; database=escola_de_musica");

                try
                {
                    string sql = "SELECT * FROM alunos";
                    MySqlCommand command = new MySqlCommand(sql, GetConexao("server=localhost; user=root; password=; database=escola_de_musica"));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabela);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar os alunos: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro para se conectar ao banco de dados: " + ex.Message);
            }
            return tabela;
        }
    }
}
