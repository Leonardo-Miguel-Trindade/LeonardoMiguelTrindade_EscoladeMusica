namespace LeonardoMiguelTrindade_EscoladeMusica
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.CadastrarAulas = new System.Windows.Forms.Button();
            this.CadastrarAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escola de Música";
            // 
            // CadastrarAulas
            // 
            this.CadastrarAulas.Location = new System.Drawing.Point(46, 566);
            this.CadastrarAulas.Name = "CadastrarAulas";
            this.CadastrarAulas.Size = new System.Drawing.Size(274, 100);
            this.CadastrarAulas.TabIndex = 1;
            this.CadastrarAulas.Text = "Cadastrar Aulas";
            this.CadastrarAulas.UseVisualStyleBackColor = true;
            this.CadastrarAulas.Click += new System.EventHandler(this.CadastrarAulas_Click);
            // 
            // CadastrarAluno
            // 
            this.CadastrarAluno.Location = new System.Drawing.Point(388, 566);
            this.CadastrarAluno.Name = "CadastrarAluno";
            this.CadastrarAluno.Size = new System.Drawing.Size(274, 100);
            this.CadastrarAluno.TabIndex = 2;
            this.CadastrarAluno.Text = "Cadastrar Aluno";
            this.CadastrarAluno.UseVisualStyleBackColor = true;
            this.CadastrarAluno.Click += new System.EventHandler(this.CadastrarAluno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 702);
            this.Controls.Add(this.CadastrarAluno);
            this.Controls.Add(this.CadastrarAulas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CadastrarAulas;
        private System.Windows.Forms.Button CadastrarAluno;
    }
}

