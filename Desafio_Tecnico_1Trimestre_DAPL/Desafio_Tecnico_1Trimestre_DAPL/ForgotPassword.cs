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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void forgotbutton_Click(object sender, EventArgs e)
        {
            Form1 novoForm1 = new Form1();
            this.Hide();
            //Exibindo o novo formulário
            novoForm1.Show();
        }
    }
}
