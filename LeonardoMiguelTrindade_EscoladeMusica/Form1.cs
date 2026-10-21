using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LeonardoMiguelTrindade_EscoladeMusica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao.GetConexao("server=localhost; user=root; password=");
            Conexao.CreateDB();
            Conexao.CreateTables();
        }

        private void CadastrarAulas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCadastrarAulas = new Cadastrar_Aula();
            formCadastrarAulas.Show();
        }

        private void CadastrarAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCadastrarAluno = new Cadastrar_Aluno();
            formCadastrarAluno.Show();
        }
    }
}
