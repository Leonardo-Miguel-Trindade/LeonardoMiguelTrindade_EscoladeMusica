using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeonardoMiguelTrindade_EscoladeMusica
{
    public partial class ConsultarAula : Form
    {
        public ConsultarAula()
        {
            InitializeComponent();
            CarregarDados();
            
        }

        public void CarregarDados()
        {
            FormatarDGau();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Conexao.listarDados("SELECT * FROM aulas");
        }

        private void ConsultarAula_Load(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Cadastrar_Aula();
            form.Show();
        }

        public void FormatarDGau()
        {
            dataGridView1.Columns["ID"].DataPropertyName = "id";
            dataGridView1.Columns["Instrumento"].DataPropertyName = "instrumento";
            dataGridView1.Columns["Professor"].DataPropertyName = "professor";
            dataGridView1.Columns["Dia"].DataPropertyName = "dia";
            // Paleta do background
            Color roxoEscuro = ColorTranslator.FromHtml("#3F2A5C");
            Color roxoMedio = ColorTranslator.FromHtml("#6B5A8E");
            Color lilas = ColorTranslator.FromHtml("#B57FD6");
            Color creme = ColorTranslator.FromHtml("#FDF3DC");

            // Ligação das colunas (confira se os nomes batem com o Name de cada coluna)
            dataGridView1.Columns["ID"].DataPropertyName = "id";
            dataGridView1.Columns["Instrumento"].DataPropertyName = "instrumento";
            dataGridView1.Columns["Professor"].DataPropertyName = "professor";
            dataGridView1.Columns["Dia"].DataPropertyName = "dia";

            // Aparência geral do grid
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = creme;
            dataGridView1.GridColor = lilas;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;      // remove a coluna cinza da esquerda
            dataGridView1.AllowUserToAddRows = false;     // remove a linha em branco do final
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Colunas ocupam toda a largura do grid (centralizado e proporcional)
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cabeçalho
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = roxoEscuro;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = creme;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = roxoEscuro; // evita mudar de cor ao clicar

            // Linhas
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.ForeColor = roxoEscuro;
            dataGridView1.DefaultCellStyle.BackColor = creme;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 220, 245); // lilás bem claro
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = roxoEscuro;

            // Linha selecionada (importante porque você usa o clique para preencher os campos)
            dataGridView1.DefaultCellStyle.SelectionBackColor = roxoMedio;
            dataGridView1.DefaultCellStyle.SelectionForeColor = creme;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                sql = "SELECT * FROM aulas";
                radioButtonID.Checked = false;
                radioButtonInstrumento.Checked = false;
            }
            else if (radioButtonID.Checked)
            {
                sql = $"SELECT * FROM aulas WHERE id LIKE '%{textBox1.Text}%'";
            }
            else if (radioButtonInstrumento.Checked)
            {
                sql = $"SELECT * FROM aulas WHERE instrumento LIKE '%{textBox1.Text}%'";
            }

            //executando o banco
            try
            {
                FormatarDGau();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao.ExcluirAula("DELETE FROM aulas WHERE ID = " + textBoxID.Text);
            CarregarDados();

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];
            textBoxID.Text = linha.Cells["ID"].Value.ToString();
            txtInstrumento.Text = linha.Cells["Instrumento"].Value.ToString();
            txtProfessor.Text = linha.Cells["Professor"].Value.ToString();

            if (linha.Cells["Dia"].Value.ToString() == "SEGUNDA")
            {
                radioButtonSegunda.Checked = true;
            }
            else if (linha.Cells["Dia"].Value.ToString() == "TERCA")
            {
                radioButtonTerca.Checked = true;
            }
            else if (linha.Cells["Dia"].Value.ToString() == "QUARTA")
            {
                radioButtonQuarta.Checked = true;
            }
            else if (linha.Cells["Dia"].Value.ToString() == "QUINTA")
            {
                radioButtonQuinta.Checked = true;
            }
            else if (linha.Cells["Dia"].Value.ToString() == "SEXTA")
            {
                radioButtonSexta.Checked = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxID.Text))
            {
                var command = new MySqlCommand();
                try
                {
                    Conexao.GetConexao("server=localhost; user=root; password=; database=escola_de_musica");

                    try
                    {
                        String dia = "";
                        if (radioButtonSegunda.Checked)
                        {
                          dia = "SEGUNDA";
                        }else if (radioButtonTerca.Checked)
                        {
                            dia = "TERCA";
                        }
                        else if (radioButtonQuarta.Checked)
                        {
                            dia = "QUARTA";
                        }
                        else if (radioButtonQuinta.Checked)
                        {
                            dia = "QUINTA";
                        }
                        else if (radioButtonSexta.Checked)
                        {
                            dia = "SEXTA";
                        }

                        command = new MySqlCommand("UPDATE aulas SET INSTRUMENTO = '" + txtInstrumento.Text + "', PROFESSOR = '" + txtProfessor.Text + "', DIA = '" + dia + "' WHERE ID = '" + textBoxID.Text + "';",
                            Conexao.GetConexao("server=localhost; user=root; password=; database=escola_de_musica"));

                        command.ExecuteNonQuery();

                        CarregarDados();

                        MessageBox.Show("Aula editada com sucesso!");
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

        private void radioButtonQuinta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
