namespace LeonardoMiguelTrindade_EscoladeMusica
{
    partial class ConsultarAula
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonTerca = new System.Windows.Forms.RadioButton();
            this.radioButtonQuarta = new System.Windows.Forms.RadioButton();
            this.radioButtonQuinta = new System.Windows.Forms.RadioButton();
            this.radioButtonSexta = new System.Windows.Forms.RadioButton();
            this.radioButtonSegunda = new System.Windows.Forms.RadioButton();
            this.txtInstrumento = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.radioButtonInstrumento = new System.Windows.Forms.RadioButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 52);
            this.label2.TabIndex = 26;
            this.label2.Text = "Consultar Aula";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dia,
            this.professor,
            this.instrumento});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(105, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1192, 164);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // dia
            // 
            this.dia.HeaderText = "DIA";
            this.dia.MinimumWidth = 6;
            this.dia.Name = "dia";
            // 
            // professor
            // 
            this.professor.HeaderText = "PROFESSOR";
            this.professor.MinimumWidth = 6;
            this.professor.Name = "professor";
            // 
            // instrumento
            // 
            this.instrumento.HeaderText = "INSTRUMENTO";
            this.instrumento.MinimumWidth = 6;
            this.instrumento.Name = "instrumento";
            // 
            // radioButtonTerca
            // 
            this.radioButtonTerca.AutoSize = true;
            this.radioButtonTerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTerca.Location = new System.Drawing.Point(305, 568);
            this.radioButtonTerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTerca.Name = "radioButtonTerca";
            this.radioButtonTerca.Size = new System.Drawing.Size(122, 42);
            this.radioButtonTerca.TabIndex = 40;
            this.radioButtonTerca.TabStop = true;
            this.radioButtonTerca.Text = "Terça";
            this.radioButtonTerca.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuarta
            // 
            this.radioButtonQuarta.AutoSize = true;
            this.radioButtonQuarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonQuarta.Location = new System.Drawing.Point(446, 568);
            this.radioButtonQuarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonQuarta.Name = "radioButtonQuarta";
            this.radioButtonQuarta.Size = new System.Drawing.Size(138, 42);
            this.radioButtonQuarta.TabIndex = 39;
            this.radioButtonQuarta.TabStop = true;
            this.radioButtonQuarta.Text = "Quarta";
            this.radioButtonQuarta.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuinta
            // 
            this.radioButtonQuinta.AutoSize = true;
            this.radioButtonQuinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonQuinta.Location = new System.Drawing.Point(601, 568);
            this.radioButtonQuinta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonQuinta.Name = "radioButtonQuinta";
            this.radioButtonQuinta.Size = new System.Drawing.Size(134, 42);
            this.radioButtonQuinta.TabIndex = 38;
            this.radioButtonQuinta.TabStop = true;
            this.radioButtonQuinta.Text = "Quinta";
            this.radioButtonQuinta.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexta
            // 
            this.radioButtonSexta.AutoSize = true;
            this.radioButtonSexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSexta.Location = new System.Drawing.Point(752, 568);
            this.radioButtonSexta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSexta.Name = "radioButtonSexta";
            this.radioButtonSexta.Size = new System.Drawing.Size(122, 42);
            this.radioButtonSexta.TabIndex = 37;
            this.radioButtonSexta.TabStop = true;
            this.radioButtonSexta.Text = "Sexta";
            this.radioButtonSexta.UseVisualStyleBackColor = true;
            // 
            // radioButtonSegunda
            // 
            this.radioButtonSegunda.AutoSize = true;
            this.radioButtonSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSegunda.Location = new System.Drawing.Point(113, 568);
            this.radioButtonSegunda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSegunda.Name = "radioButtonSegunda";
            this.radioButtonSegunda.Size = new System.Drawing.Size(168, 42);
            this.radioButtonSegunda.TabIndex = 36;
            this.radioButtonSegunda.TabStop = true;
            this.radioButtonSegunda.Text = "Segunda";
            this.radioButtonSegunda.UseVisualStyleBackColor = true;
            // 
            // txtInstrumento
            // 
            this.txtInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstrumento.Location = new System.Drawing.Point(260, 486);
            this.txtInstrumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInstrumento.Multiline = true;
            this.txtInstrumento.Name = "txtInstrumento";
            this.txtInstrumento.Size = new System.Drawing.Size(471, 38);
            this.txtInstrumento.TabIndex = 35;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(220, 667);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfessor.Multiline = true;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(471, 38);
            this.txtProfessor.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 38);
            this.label7.TabIndex = 33;
            this.label7.Text = "Instrumento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 38);
            this.label4.TabIndex = 32;
            this.label4.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "Dia:";
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(1270, 606);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(230, 79);
            this.Voltar.TabIndex = 41;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // excluir
            // 
            this.excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.Location = new System.Drawing.Point(1270, 511);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(230, 79);
            this.excluir.TabIndex = 43;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // editar
            // 
            this.editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.Location = new System.Drawing.Point(1270, 406);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(230, 79);
            this.editar.TabIndex = 42;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 52);
            this.label8.TabIndex = 45;
            this.label8.Text = "Pesquisar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(346, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 46);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonID.Location = new System.Drawing.Point(123, 146);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(57, 33);
            this.radioButtonID.TabIndex = 46;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // radioButtonInstrumento
            // 
            this.radioButtonInstrumento.AutoSize = true;
            this.radioButtonInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInstrumento.Location = new System.Drawing.Point(186, 146);
            this.radioButtonInstrumento.Name = "radioButtonInstrumento";
            this.radioButtonInstrumento.Size = new System.Drawing.Size(159, 33);
            this.radioButtonInstrumento.TabIndex = 48;
            this.radioButtonInstrumento.TabStop = true;
            this.radioButtonInstrumento.Text = "Instrumento";
            this.radioButtonInstrumento.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(97, 415);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(104, 38);
            this.textBoxID.TabIndex = 50;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 38);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID:";
            // 
            // ConsultarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 720);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonInstrumento);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.radioButtonTerca);
            this.Controls.Add(this.radioButtonQuarta);
            this.Controls.Add(this.radioButtonQuinta);
            this.Controls.Add(this.radioButtonSexta);
            this.Controls.Add(this.radioButtonSegunda);
            this.Controls.Add(this.txtInstrumento);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarAula";
            this.Text = "ConsultarAula";
            this.Load += new System.EventHandler(this.ConsultarAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonTerca;
        private System.Windows.Forms.RadioButton radioButtonQuarta;
        private System.Windows.Forms.RadioButton radioButtonQuinta;
        private System.Windows.Forms.RadioButton radioButtonSexta;
        private System.Windows.Forms.RadioButton radioButtonSegunda;
        private System.Windows.Forms.TextBox txtInstrumento;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumento;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonInstrumento;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
    }
}