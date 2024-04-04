namespace Desafio_Tecnico_1Trimestre_DAPL
{
    partial class ForgotPassword
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
            this.Forgot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ForgotBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.forgotbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Forgot
            // 
            this.Forgot.AutoSize = true;
            this.Forgot.Font = new System.Drawing.Font("Gabriola", 26.25F);
            this.Forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Forgot.Location = new System.Drawing.Point(309, 58);
            this.Forgot.Name = "Forgot";
            this.Forgot.Size = new System.Drawing.Size(404, 81);
            this.Forgot.TabIndex = 0;
            this.Forgot.Text = ">> Esqueci minha senha <<";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(338, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail:";
            // 
            // ForgotBox
            // 
            this.ForgotBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ForgotBox.ForeColor = System.Drawing.Color.Purple;
            this.ForgotBox.Location = new System.Drawing.Point(435, 184);
            this.ForgotBox.Name = "ForgotBox";
            this.ForgotBox.Size = new System.Drawing.Size(226, 22);
            this.ForgotBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(339, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha automática será enviada para o seu e-mail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // forgotbutton
            // 
            this.forgotbutton.BackColor = System.Drawing.Color.MediumPurple;
            this.forgotbutton.Font = new System.Drawing.Font("Myanmar Text", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotbutton.ForeColor = System.Drawing.Color.Indigo;
            this.forgotbutton.Location = new System.Drawing.Point(419, 278);
            this.forgotbutton.Name = "forgotbutton";
            this.forgotbutton.Size = new System.Drawing.Size(145, 42);
            this.forgotbutton.TabIndex = 4;
            this.forgotbutton.Text = "Recebi minha senha!";
            this.forgotbutton.UseVisualStyleBackColor = false;
            this.forgotbutton.Click += new System.EventHandler(this.forgotbutton_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.forgotbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ForgotBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Forgot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Forgot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ForgotBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button forgotbutton;
    }
}