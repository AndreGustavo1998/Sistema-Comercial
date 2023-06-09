using Sistema_Comercial.Forms;
using Sistema_Comercial.Mapeamento;
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

namespace Sistema_Comercial
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }
        void VerificarLogin()
        {
            if (Global.UsuarioLogado == null)
            {
                usuariosToolStripMenuItem.Enabled = false;
                
                nomeLabel.Text = "Nenhum usuário logado";
                //fecha os forms abertos
                foreach (Form f in this.MdiChildren)
                    f.Close();
                fazerLoginToolStripMenuItem.Text = "Entrar";
                //chama a tela de login
                new LoginForm().ShowDialog();
            }
            if (Global.UsuarioLogado != null)
            {
                //só habilita o menu de usuários se for admin (nível 1)
                usuariosToolStripMenuItem.Enabled = Global.UsuarioLogado.Nivel == 1;
                
                fazerLoginToolStripMenuItem.Text = "Fazer Logoff";
                nomeLabel.Text = Global.UsuarioLogado.Nome;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VerificarLogin();
            
        }

        private void fazerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.UsuarioLogado = null;
            VerificarLogin();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm clienteForm = new UsuariosForm();
            
            clienteForm.WindowState = FormWindowState.Maximized;
            clienteForm.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosForm produtosForm = new ProdutosForm();
            
            produtosForm.WindowState = FormWindowState.Maximized;
            produtosForm.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendasForm vendasForm = new VendasForm();

            vendasForm.WindowState = FormWindowState.Maximized;
            vendasForm.Show();
        }

        private void ajudaMenu_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sobre().ShowDialog();
        }
    }
}
