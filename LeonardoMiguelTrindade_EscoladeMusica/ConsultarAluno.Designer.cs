namespace LeonardoMiguelTrindade_EscoladeMusica
{
    partial class ConsultarAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATRICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTRUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInstrumento = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonMatricula = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATRICULA,
            this.NOME,
            this.CPF,
            this.ENDERECO,
            this.TELEFONE,
            this.INSTRUMENTO});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1192, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MATRICULA
            // 
            this.MATRICULA.HeaderText = "MATRICULA";
            this.MATRICULA.MinimumWidth = 6;
            this.MATRICULA.Name = "MATRICULA";
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.MinimumWidth = 6;
            this.NOME.Name = "NOME";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 6;
            this.CPF.Name = "CPF";
            // 
            // ENDERECO
            // 
            this.ENDERECO.HeaderText = "ENDEREÇO";
            this.ENDERECO.MinimumWidth = 6;
            this.ENDERECO.Name = "ENDERECO";
            // 
            // TELEFONE
            // 
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.MinimumWidth = 6;
            this.TELEFONE.Name = "TELEFONE";
            // 
            // INSTRUMENTO
            // 
            this.INSTRUMENTO.HeaderText = "INSTRUMENTO";
            this.INSTRUMENTO.MinimumWidth = 6;
            this.INSTRUMENTO.Name = "INSTRUMENTO";
            // 
            // txtInstrumento
            // 
            this.txtInstrumento.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstrumento.ForeColor = System.Drawing.Color.White;
            this.txtInstrumento.Location = new System.Drawing.Point(365, 806);
            this.txtInstrumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInstrumento.Multiline = true;
            this.txtInstrumento.Name = "txtInstrumento";
            this.txtInstrumento.Size = new System.Drawing.Size(471, 38);
            this.txtInstrumento.TabIndex = 24;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.White;
            this.txtTelefone.Location = new System.Drawing.Point(275, 760);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefone.Multiline = true;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(471, 38);
            this.txtTelefone.TabIndex = 23;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.White;
            this.txtCPF.Location = new System.Drawing.Point(147, 714);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.Multiline = true;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(471, 38);
            this.txtCPF.TabIndex = 22;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(288, 658);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(471, 38);
            this.txtEndereco.TabIndex = 21;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(184, 601);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(471, 38);
            this.txtNome.TabIndex = 20;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.White;
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.White;
            this.txtMatricula.Location = new System.Drawing.Point(317, 540);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatricula.Multiline = true;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(471, 38);
            this.txtMatricula.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 804);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 44);
            this.label7.TabIndex = 18;
            this.label7.Text = "Instrumento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 760);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 44);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 708);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 44);
            this.label5.TabIndex = 16;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 44);
            this.label4.TabIndex = 15;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Matrícula:";
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.MediumPurple;
            this.Voltar.Font = new System.Drawing.Font("Perpetua", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.Color.White;
            this.Voltar.Location = new System.Drawing.Point(1245, 686);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(230, 79);
            this.Voltar.TabIndex = 33;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(288, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 46);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 44);
            this.label8.TabIndex = 35;
            this.label8.Text = "Pesquisar";
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.MediumPurple;
            this.editar.Font = new System.Drawing.Font("Perpetua", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.Color.White;
            this.editar.Location = new System.Drawing.Point(1245, 485);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(230, 79);
            this.editar.TabIndex = 36;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Perpetua", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1245, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 79);
            this.button1.TabIndex = 37;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonMatricula
            // 
            this.radioButtonMatricula.AutoSize = true;
            this.radioButtonMatricula.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMatricula.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMatricula.Location = new System.Drawing.Point(69, 254);
            this.radioButtonMatricula.Name = "radioButtonMatricula";
            this.radioButtonMatricula.Size = new System.Drawing.Size(152, 36);
            this.radioButtonMatricula.TabIndex = 38;
            this.radioButtonMatricula.TabStop = true;
            this.radioButtonMatricula.Text = "Matrícula";
            this.radioButtonMatricula.UseVisualStyleBackColor = false;
            this.radioButtonMatricula.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNome.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNome.Location = new System.Drawing.Point(227, 254);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(104, 36);
            this.radioButtonNome.TabIndex = 39;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = false;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // ConsultarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LeonardoMiguelTrindade_EscoladeMusica.Properties.Resources.The_Art_Of_4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1517, 853);
            this.Controls.Add(this.radioButtonNome);
            this.Controls.Add(this.radioButtonMatricula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.txtInstrumento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultarAluno";
            this.Text = "ConsultarAluno";
            this.Load += new System.EventHandler(this.ConsultarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtInstrumento;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTRUMENTO;
        private System.Windows.Forms.RadioButton radioButtonMatricula;
        private System.Windows.Forms.RadioButton radioButtonNome;
    }
}