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
            var form = new ConsultarAluno();
            form.Show();
        }

        private void ConsultarAluno_Load(object sender, EventArgs e)
        {

        }

        public void FormatarDG()
        {
            dataGridView1.Columns["MATRICULA"].DataPropertyName = "id";
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
    }
}
