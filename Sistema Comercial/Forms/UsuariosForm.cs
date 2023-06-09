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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dados = new UsuariosDAO().ListarTodas();
            listaDataGridView.DataSource = dados;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
