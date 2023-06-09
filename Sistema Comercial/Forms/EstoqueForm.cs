using Sistema_Comercial.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Comercial.Forms
{
    public partial class EstoqueForm : Form
    {
        public EstoqueForm()
        {
            InitializeComponent();
            
            Text = "Novo Produto";
            idTxtBox.Text = "Automático";
            idTxtBox.ReadOnly = true;
            nomeTxtBox.Focus();
        }

        public EstoqueForm(int id)
        {
            InitializeComponent();
            var estoque = new ProdutosDAO().Buscar(id);
            Text = "Alteração de Produto";
            idTxtBox.Text = estoque.ID.ToString();
            idTxtBox.ReadOnly = true;

            tipoTxtBox.Text = estoque.Tipo;
            tipoTxtBox.Focus();

            nomeTxtBox.Text = estoque.Nome_Produto;
            nomeTxtBox.Focus();

            quantidadeTxtBox.Text = estoque.Nome_Produto;
            quantidadeTxtBox.Focus();

            valorTxtBox.Text = estoque.Nome_Produto;
            valorTxtBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (Text == "Novo Produto")
            {
                
                new ProdutosDAO().Adicionar( tipoTxtBox.Text, nomeTxtBox.Text, quantidadeTxtBox.Text, valorTxtBox.Text);

                MessageBox.Show("Produto adicionado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                
                new ProdutosDAO().Atualizar(Convert.ToInt32(idTxtBox.Text), tipoTxtBox.Text, nomeTxtBox.Text, quantidadeTxtBox.Text, valorTxtBox.Text);

                MessageBox.Show("Produto alterado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }
        

        private void EstoqueForm_Load(object sender, EventArgs e)
        {

        }
    }
}
