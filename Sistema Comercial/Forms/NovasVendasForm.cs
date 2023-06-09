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

namespace Sistema_Comercial.Forms
{
    public partial class NovasVendasForm : Form
    {
        public NovasVendasForm()
        {
            InitializeComponent();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            new VendasDAO().Adicionar( nomeTxtBox.Text, qtdVendasTxtBox.Text, valorTxtBox.Text);

            MessageBox.Show("Venda adicionada!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void nomaClienteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
