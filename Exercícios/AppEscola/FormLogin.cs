using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Digite um nome");
                return;
            }
            if (txtSenha.Text != "12345")
            {
                MessageBox.Show("Digite a senha!");
                return;
            }

            Program.usuario = txtNome.Text;
            FormMain frm = new FormMain();
            frm.ShowDialog();

            this.Close();
        }
    }
}
