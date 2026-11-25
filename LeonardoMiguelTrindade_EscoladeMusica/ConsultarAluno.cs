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
            CarregarDadosAl();
        }

        public void CarregarDadosAl()
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

            // Mesma paleta da tela de aulas
            Color roxoEscuro = ColorTranslator.FromHtml("#3F2A5C");
            Color roxoMedio = ColorTranslator.FromHtml("#6B5A8E");
            Color lilas = ColorTranslator.FromHtml("#B57FD6");
            Color creme = ColorTranslator.FromHtml("#FDF3DC");
            Color lilasClaro = Color.FromArgb(235, 220, 245);

            // Ligação das colunas
            dataGridView1.Columns["MATRICULA"].DataPropertyName = "matricula";
            dataGridView1.Columns["NOME"].DataPropertyName = "nome";
            dataGridView1.Columns["ENDERECO"].DataPropertyName = "endereco";
            dataGridView1.Columns["CPF"].DataPropertyName = "cpf";
            dataGridView1.Columns["TELEFONE"].DataPropertyName = "telefone";
            dataGridView1.Columns["INSTRUMENTO"].DataPropertyName = "instrumento";

            // Aparência geral
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = creme;
            dataGridView1.GridColor = lilas;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Colunas dividem a largura do grid
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["MATRICULA"].FillWeight = 80;
            dataGridView1.Columns["NOME"].FillWeight = 130;
            dataGridView1.Columns["ENDERECO"].FillWeight = 125;
            dataGridView1.Columns["CPF"].FillWeight = 90;
            dataGridView1.Columns["TELEFONE"].FillWeight = 90;
            dataGridView1.Columns["INSTRUMENTO"].FillWeight = 100;

            // Cabeçalho
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = roxoEscuro;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = creme;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = roxoEscuro;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Linhas
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.ForeColor = roxoEscuro;
            dataGridView1.DefaultCellStyle.BackColor = creme;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = lilasClaro;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = roxoEscuro;

            // Linha selecionada
            dataGridView1.DefaultCellStyle.SelectionBackColor = roxoMedio;
            dataGridView1.DefaultCellStyle.SelectionForeColor = creme;
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
            CarregarDadosAl();
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

                        CarregarDadosAl();

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

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
