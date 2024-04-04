namespace Desafio_Tecnico_1Trimestre_DAPL
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
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.SenhaBox = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.EsquecerSenha = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoginBox.ForeColor = System.Drawing.Color.Purple;
            this.LoginBox.Location = new System.Drawing.Point(440, 204);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(256, 22);
            this.LoginBox.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Thistle;
            this.Nome.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Nome.Location = new System.Drawing.Point(223, 44);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(557, 81);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "⭒ Bem-Vindo(a) à Biblioteca Online ⭒";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login.Location = new System.Drawing.Point(351, 204);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(66, 23);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login:";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Senha.Location = new System.Drawing.Point(348, 245);
            this.Senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(70, 23);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Senha:";
            // 
            // SenhaBox
            // 
            this.SenhaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SenhaBox.ForeColor = System.Drawing.Color.Purple;
            this.SenhaBox.Location = new System.Drawing.Point(440, 246);
            this.SenhaBox.Margin = new System.Windows.Forms.Padding(4);
            this.SenhaBox.Name = "SenhaBox";
            this.SenhaBox.PasswordChar = '✯';
            this.SenhaBox.Size = new System.Drawing.Size(256, 22);
            this.SenhaBox.TabIndex = 4;
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.MediumPurple;
            this.Entrar.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.ForeColor = System.Drawing.Color.Indigo;
            this.Entrar.Location = new System.Drawing.Point(489, 304);
            this.Entrar.Margin = new System.Windows.Forms.Padding(4);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(100, 28);
            this.Entrar.TabIndex = 5;
            this.Entrar.Text = "Entrar";
            this.Entrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // EsquecerSenha
            // 
            this.EsquecerSenha.AutoSize = true;
            this.EsquecerSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsquecerSenha.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.EsquecerSenha.Location = new System.Drawing.Point(604, 274);
            this.EsquecerSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EsquecerSenha.Name = "EsquecerSenha";
            this.EsquecerSenha.Size = new System.Drawing.Size(101, 13);
            this.EsquecerSenha.TabIndex = 6;
            this.EsquecerSenha.Text = "Esqueceu a senha?";
            this.EsquecerSenha.Click += new System.EventHandler(this.EsquecerSenha_Click);
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Text1.Location = new System.Drawing.Point(481, 378);
            this.Text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(113, 17);
            this.Text1.TabIndex = 7;
            this.Text1.Text = "Não tenho conta";
            this.Text1.Click += new System.EventHandler(this.Text1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.EsquecerSenha);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.SenhaBox);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.LoginBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox SenhaBox;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label EsquecerSenha;
        private System.Windows.Forms.Label Text1;
    }
}

