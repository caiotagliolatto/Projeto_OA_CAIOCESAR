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
using System.Data.SqlClient;
using Domain;

namespace View
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            this.pRODUTOTableAdapter.Fill(this.banco_FinalDataSet.PRODUTO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto p = new Produto(pricebox.Text,namebox.Text, olhapexera.Text);
            ProdutoDAO proDAO = new ProdutoDAO();
            proDAO.Inserir(p);
                MessageBox.Show("Produto inserido", "Metodo realizado");
                namebox.Clear();
                pricebox.Clear();
                olhapexera.Clear();

            refresh();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_FinalDataSet.PRODUTO' table. You can move, or remove it, as needed.
            refresh();

        }
        public void recebeRefresh()
        {
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            delup du = new delup(this, id);
            du.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
