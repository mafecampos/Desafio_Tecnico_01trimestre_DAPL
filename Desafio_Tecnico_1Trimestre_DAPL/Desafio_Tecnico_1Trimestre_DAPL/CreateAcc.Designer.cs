namespace Desafio_Tecnico_1Trimestre_DAPL
{
    partial class CreateAcc
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
            this.Create = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.AutoSize = true;
            this.Create.Location = new System.Drawing.Point(453, 42);
            this.Create.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(108, 16);
            this.Create.TabIndex = 0;
            this.Create.Text = "⭒ Crie sua conta ⭒";
            // 
            // CreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Create);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAcc";
            this.Text = "CreateAcc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Create;
    }
}