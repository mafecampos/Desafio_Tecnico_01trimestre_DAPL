using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Tecnico_1Trimestre_DAPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {

        }

        private void Text1_Click(object sender, EventArgs e)
        {
          
        }

        private void EsquecerSenha_Click(object sender, EventArgs e)
        {
            //Criando uma instância do novo formulário
            ForgotPassword novoForm = new ForgotPassword();
            this.Hide();
            //Exibindo o novo formulário
            novoForm.Show();
        }
    }
}
