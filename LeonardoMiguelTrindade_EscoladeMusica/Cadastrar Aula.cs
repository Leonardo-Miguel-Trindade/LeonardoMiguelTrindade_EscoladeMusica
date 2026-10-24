using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
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
    public partial class Cadastrar_Aula : Form
    {
        public Cadastrar_Aula()
        {
            InitializeComponent();
        }

        private void Cadastrar_Aula_Load(object sender, EventArgs e)
        {
            
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            var instrumento = txtInstrumento.Text;
            var professor = txtProfessor.Text; 
            String dia;

            if (radioButtonSegunda.Checked) dia = "SEGUNDA";
            else if (radioButtonTerca.Checked) dia = "TERÇA";
            else if (radioButtonQuarta.Checked) dia = "QUARTA";
            else if (radioButtonQuinta.Checked) dia = "QUINTA";
            else dia = "SEXTA";

            Conexao.CadastroAula(instrumento, dia, professor);

            limpar();
        }

        private void limpar()
        {
            txtInstrumento.Text = "";
            txtProfessor.Text = "";
            radioButtonSegunda.Checked = false;
            radioButtonTerca.Checked = false;
            radioButtonQuarta.Checked = false;
            radioButtonQuinta.Checked = false;
            radioButtonSexta.Checked = false;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ConsultarAula();
            form.Show();
        }
    }
}
