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
            FormatarDG();
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

        public void FormatarDG()
        {
            dataGridView1.Columns["ID"].DataPropertyName = "id";
            dataGridView1.Columns["Instrumento"].DataPropertyName = "instrumento";
            dataGridView1.Columns["Professor"].DataPropertyName = "professor";
            dataGridView1.Columns["Dia"].DataPropertyName = "dia";
            //cores da tabela 
            dataGridView1.ForeColor = System.Drawing.Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Coral;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;

            //alinhamento das colunas
            dataGridView1.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Instrumento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Professor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Dia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //alinhamento dos dados
            dataGridView1.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Instrumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Professor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Dia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Tamanho padrão das colunas
            dataGridView1.Columns["ID"].Width = 200;
            dataGridView1.Columns["Instrumento"].Width = 200;
            dataGridView1.Columns["Professor"].Width = 200;
            dataGridView1.Columns["Dia"].Width = 200;

            //Muda tipo da fonta, tamanhos e deixa o texto em negrito
            dataGridView1.Columns["Instrumento"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);
            dataGridView1.Columns["Professor"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);
            dataGridView1.Columns["Dia"].DefaultCellStyle.Font = new Font("arial", 10, FontStyle.Bold);

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
    }
}
