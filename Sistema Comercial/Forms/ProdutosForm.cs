using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Comercial.Forms
{
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            var dados = new ProdutosDAO().ListarTodas();
            listaDataGridView.DataSource = dados;
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o produto?", ProductName,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //pega o id da linha selecionada no grid
                int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);
                //executa a exclusão
                new ProdutosDAO().Excluir(id);
                //executa a busca novamente, como se tivesse clicado no botão
                listarButton.PerformClick();
                //avisa o usuário
                
            MessageBox.Show("Cidade excluída com sucesso!", ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);
            
            new EstoqueForm().ShowDialog();
            
            listarButton.PerformClick();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);
            
            new EstoqueForm(id).ShowDialog();
            
            listarButton.PerformClick();
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {

        }

        private void listaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
