namespace Sistema_Comercial
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clientesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.footerStatusStrip = new System.Windows.Forms.StatusStrip();
            this.nomeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.footerStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesMenu,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.ajudaMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // clientesMenu
            // 
            this.clientesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMenu,
            this.fazerLoginToolStripMenuItem});
            this.clientesMenu.Name = "clientesMenu";
            this.clientesMenu.Size = new System.Drawing.Size(119, 24);
            this.clientesMenu.Text = "Administração";
            // 
            // cadastroMenu
            // 
            this.cadastroMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.cadastroMenu.Name = "cadastroMenu";
            this.cadastroMenu.Size = new System.Drawing.Size(167, 26);
            this.cadastroMenu.Text = "Buscar";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // fazerLoginToolStripMenuItem
            // 
            this.fazerLoginToolStripMenuItem.Name = "fazerLoginToolStripMenuItem";
            this.fazerLoginToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.fazerLoginToolStripMenuItem.Text = "Fazer Login";
            this.fazerLoginToolStripMenuItem.Click += new System.EventHandler(this.fazerLoginToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // ajudaMenu
            // 
            this.ajudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaMenu.Name = "ajudaMenu";
            this.ajudaMenu.Size = new System.Drawing.Size(62, 24);
            this.ajudaMenu.Text = "Ajuda";
            this.ajudaMenu.Click += new System.EventHandler(this.ajudaMenu_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // footerStatusStrip
            // 
            this.footerStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.footerStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeLabel});
            this.footerStatusStrip.Location = new System.Drawing.Point(0, 424);
            this.footerStatusStrip.Name = "footerStatusStrip";
            this.footerStatusStrip.Size = new System.Drawing.Size(800, 26);
            this.footerStatusStrip.TabIndex = 1;
            this.footerStatusStrip.Text = "statusStrip1";
            // 
            // nomeLabel
            // 
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(64, 20);
            this.nomeLabel.Text = "Usurario";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Comercial.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.footerStatusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PrincipalForm";
            this.ShowIcon = false;
            this.Text = "Sistema Comercial Empresarial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.footerStatusStrip.ResumeLayout(false);
            this.footerStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clientesMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastroMenu;
        private System.Windows.Forms.ToolStripMenuItem fazerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaMenu;
        private System.Windows.Forms.StatusStrip footerStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel nomeLabel;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

