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
            this.CadastrarAulas = new System.Windows.Forms.Button();
            this.CadastrarAluno = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadastrarAulas
            // 
            this.CadastrarAulas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CadastrarAulas.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarAulas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CadastrarAulas.Location = new System.Drawing.Point(42, 570);
            this.CadastrarAulas.Name = "CadastrarAulas";
            this.CadastrarAulas.Size = new System.Drawing.Size(226, 88);
            this.CadastrarAulas.TabIndex = 1;
            this.CadastrarAulas.Text = "Cadastrar Aulas";
            this.CadastrarAulas.UseVisualStyleBackColor = false;
            this.CadastrarAulas.Click += new System.EventHandler(this.CadastrarAulas_Click);
            // 
            // CadastrarAluno
            // 
            this.CadastrarAluno.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CadastrarAluno.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CadastrarAluno.Location = new System.Drawing.Point(274, 570);
            this.CadastrarAluno.Name = "CadastrarAluno";
            this.CadastrarAluno.Size = new System.Drawing.Size(237, 88);
            this.CadastrarAluno.TabIndex = 2;
            this.CadastrarAluno.Text = "Cadastrar Aluno";
            this.CadastrarAluno.UseVisualStyleBackColor = false;
            this.CadastrarAluno.Click += new System.EventHandler(this.CadastrarAluno_Click);
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sair.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sair.Location = new System.Drawing.Point(517, 570);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(213, 88);
            this.sair.TabIndex = 3;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LeonardoMiguelTrindade_EscoladeMusica.Properties.Resources.The_Art_Of;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1473, 702);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.CadastrarAluno);
            this.Controls.Add(this.CadastrarAulas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CadastrarAulas;
        private System.Windows.Forms.Button CadastrarAluno;
        private System.Windows.Forms.Button sair;
    }
}

