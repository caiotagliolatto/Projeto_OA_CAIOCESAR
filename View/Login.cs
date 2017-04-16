using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infra;

namespace View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            LoginDAO log = new LoginDAO();
            if (log.login(textBox1.Text, textBox2.Text) == 1)
            {
                Principal main = new Principal();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario não encontrado");
            }
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Preencha os dados antes!");
            }
            else
            {
                LoginDAO lDAO = new LoginDAO();
                lDAO.cadastro(textBox1.Text, textBox2.Text);
                    MessageBox.Show("Cadastro realizado!");
                
            }
        }
    }
}
