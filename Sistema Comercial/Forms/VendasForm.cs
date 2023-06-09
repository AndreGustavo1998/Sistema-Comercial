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
    public partial class VendasForm : Form
    {
        public VendasForm()
        {
            InitializeComponent();
        }

        private void buscarVendasButton_Click(object sender, EventArgs e)
        {
            var dados = new VendasDAO().Listar();
            vendasDataGridView.DataSource = dados;
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(vendasDataGridView.SelectedRows[0].Cells["idColumn"].Value);

            new NovasVendasForm().ShowDialog();

            buscarVendasButton.PerformClick();

        }

        private void VendasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
