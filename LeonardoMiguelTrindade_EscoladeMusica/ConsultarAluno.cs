using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LeonardoMiguelTrindade_EscoladeMusica
{
    public partial class ConsultarAluno : Form
    {
        public ConsultarAluno()
        {
            InitializeComponent();
            FormatarDG();
            dataGridView1.AutoGenerateColumns = false;
            CarregarDados();
        }

        public void CarregarDados()
        {
            dataGridView1.DataSource = Conexao.listarDados("SELECT * FROM alunos");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Cadastrar_Aluno();
            form.Show();
        }

        private void ConsultarAluno_Load(object sender, EventArgs e)
        {

        }

        public void FormatarDG()
        {
            dataGridView1.Columns["MATRICULA"].DataPropertyName = "matricula";
            dataGridView1.Columns["NOME"].DataPropertyName = "nome";
            dataGridView1.Columns["ENDERECO"].DataPropertyName = "endereco";
            dataGridView1.Columns["CPF"].DataPropertyName = "cpf";
            dataGridView1.Columns["TELEFONE"].DataPropertyName = "telefone";
            dataGridView1.Columns["INSTRUMENTO"].DataPropertyName = "instrumento";

            //cores da tabela 
            dataGridView1.ForeColor = System.Drawing.Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Coral;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;

            //alinhamento das colunas
            dataGridView1.Columns["MATRICULA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["NOME"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ENDERECO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CPF"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TELEFONE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["INSTRUMENTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //alinhamento dos dados
            dataGridView1.Columns["MATRICULA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["NOME"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ENDERECO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CPF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TELEFONE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["INSTRUMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Tamanho padrão das colunas
            dataGridView1.Columns["MATRICULA"].Width = 200;
            dataGridView1.Columns["NOME"].Width = 200;
            dataGridView1.Columns["ENDERECO"].Width = 200;
            dataGridView1.Columns["CPF"].Width = 200;
            dataGridView1.Columns["TELEFONE"].Width = 200;
            dataGridView1.Columns["INSTRUMENTO"].Width = 200;

            //Muda tipo da fonta, tamanhos e deixa o texto em negrito
            dataGridView1.Columns["MATRICULA"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);
            dataGridView1.Columns["NOME"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);
            dataGridView1.Columns["ENDERECO"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);
            dataGridView1.Columns["CPF"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);
            dataGridView1.Columns["TELEFONE"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);
            dataGridView1.Columns["INSTRUMENTO"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);

            //mudar acor da linha na tabela
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Coral;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkRed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                sql = "SELECT * FROM aulas";
                radioButtonNome.Checked = false;
                radioButtonMatricula.Checked = false;
            }
            else if (radioButtonMatricula.Checked)
            {
                sql = $"SELECT * FROM alunos WHERE matricula LIKE '%{textBox1.Text}%'";
            }
            else if (radioButtonNome.Checked)
            {
                sql = $"SELECT * FROM alunos WHERE nome LIKE '%{textBox1.Text}%'";
            }

            //executando o banco
            try
            {
                FormatarDG();
                Conexao.GetConexao("server=localhost;user id=root;password=;database=escola_de_musica");
                dataGridView1.DataSource = Conexao.listarDados(sql);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Conectar com o banco de dados: " + erro.Message);
            }
            finally
            {
                Conexao.GetConexao("server=localhost;user id=root;password=;database=escola_de_musica").Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao.ExcluirAluno("DELETE FROM alunos WHERE matricula = " + txtMatricula.Text);
            CarregarDados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];
            txtMatricula.Text = linha.Cells["MATRICULA"].Value.ToString();
            txtInstrumento.Text = linha.Cells["INSTRUMENTO"].Value.ToString();
            txtNome.Text = linha.Cells["NOME"].Value.ToString();
            txtCPF.Text = linha.Cells["CPF"].Value.ToString();
            txtEndereco.Text = linha.Cells["ENDERECO"].Value.ToString();
            txtTelefone.Text = linha.Cells["TELEFONE"].Value.ToString();

        }

        public void editarAluno()
        {
            if (!string.IsNullOrEmpty(txtMatricula.Text))
            {
                var command = new MySqlCommand();
                try
                {
                    Conexao.GetConexao("server=localhost; user=root; password=; database=escola_de_musica");

                    try
                    {
                        command = new MySqlCommand("UPDATE alunos SET NOME = '"+ txtNome.Text +"', CPF = '"+ txtCPF.Text +"', ENDERECO = '"+ txtEndereco.Text +"', TELEFONE = '"+ txtTelefone.Text +"', INSTRUMENTO = '"+ txtInstrumento.Text +"' WHERE MATRICULA = '"+ txtMatricula.Text +"';",
                            Conexao.GetConexao("server=localhost; user=root; password=; database=escola_de_musica"));
                        
                        command.ExecuteNonQuery();

                        CarregarDados();

                        MessageBox.Show("Aluno editado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao listar os dados: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro para se conectar ao banco de dados: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.");
            }

        }

        private void editar_Click(object sender, EventArgs e)
        {
            editarAluno();
        }
    }
}
