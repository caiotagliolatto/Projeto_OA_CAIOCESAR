using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Infra;

namespace View
{
    public partial class delup : Form
    {
        Produto p;
        Principal mainF;
        ProdutoDAO pDAO = new ProdutoDAO();
        int id;
        public delup(Principal main, int id)
        {
            InitializeComponent();
            mainF = main;
            this.id = id;
            p = pDAO.ler(id);
            nomebox.Text = p.nome;
            precobox.Text = p.preco;
            descbox.Text = p.descricao;
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdutoDAO pDAO = new ProdutoDAO();
            pDAO.Excluir(id);
            MessageBox.Show("Produto Excluido!");
            this.Close();
        }

        private void delup_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainF.recebeRefresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.nome = nomebox.Text;
            p.descricao = descbox.Text;
            p.preco = precobox.Text;
            pDAO.Atualizar(p, id);
            MessageBox.Show("Produto Alterado!");
            this.Close();

        }
    }
}
