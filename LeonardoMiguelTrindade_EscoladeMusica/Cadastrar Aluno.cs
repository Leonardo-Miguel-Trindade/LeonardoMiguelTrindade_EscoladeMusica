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
    public partial class Cadastrar_Aluno : Form
    {
        public Cadastrar_Aluno()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            var matricula = int.Parse(txtMatricula.Text);
            var nome = txtNome.Text;
            var endereco = txtEndereco.Text;
            var cpf = txtCPF.Text;
            var telefone = txtTelefone.Text;
            var instrumento = txtInstrumento.Text;

            Conexao.CadastroAluno(matricula, nome, endereco, cpf, telefone, instrumento);

            limpar();
        }

        private void limpar()
        {
            txtMatricula.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCPF.Text = "";
            txtTelefone.Text = "";
            txtInstrumento.Text = "";
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();

        }
    }
}
