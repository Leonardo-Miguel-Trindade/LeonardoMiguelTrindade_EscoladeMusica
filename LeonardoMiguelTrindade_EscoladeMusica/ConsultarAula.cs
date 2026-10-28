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
    }
}
