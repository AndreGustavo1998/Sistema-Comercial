namespace Sistema_Comercial.Forms
{
    partial class VendasForm
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
            this.vendasDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novoButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.buscarVendasButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasDataGridView
            // 
            this.vendasDataGridView.AllowUserToAddRows = false;
            this.vendasDataGridView.AllowUserToDeleteRows = false;
            this.vendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn});
            this.vendasDataGridView.Location = new System.Drawing.Point(12, 68);
            this.vendasDataGridView.Name = "vendasDataGridView";
            this.vendasDataGridView.ReadOnly = true;
            this.vendasDataGridView.RowHeadersWidth = 51;
            this.vendasDataGridView.RowTemplate.Height = 24;
            this.vendasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendasDataGridView.Size = new System.Drawing.Size(875, 319);
            this.vendasDataGridView.TabIndex = 1;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 80;
            // 
            // novoButton
            // 
            this.novoButton.BackColor = System.Drawing.Color.White;
            this.novoButton.Image = global::Sistema_Comercial.Properties.Resources.adicionar;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.Location = new System.Drawing.Point(643, 406);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(131, 34);
            this.novoButton.TabIndex = 3;
            this.novoButton.Text = "      Nova Venda";
            this.novoButton.UseVisualStyleBackColor = false;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.BackColor = System.Drawing.Color.White;
            this.fecharButton.Image = global::Sistema_Comercial.Properties.Resources.close;
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(802, 406);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(85, 34);
            this.fecharButton.TabIndex = 2;
            this.fecharButton.Text = "     Fechar";
            this.fecharButton.UseVisualStyleBackColor = false;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // buscarVendasButton
            // 
            this.buscarVendasButton.BackColor = System.Drawing.Color.White;
            this.buscarVendasButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarVendasButton.Image = global::Sistema_Comercial.Properties.Resources.listar;
            this.buscarVendasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarVendasButton.Location = new System.Drawing.Point(12, 12);
            this.buscarVendasButton.Name = "buscarVendasButton";
            this.buscarVendasButton.Size = new System.Drawing.Size(155, 50);
            this.buscarVendasButton.TabIndex = 0;
            this.buscarVendasButton.Text = "     Buscar Vendas";
            this.buscarVendasButton.UseVisualStyleBackColor = false;
            this.buscarVendasButton.Click += new System.EventHandler(this.buscarVendasButton_Click);
            // 
            // VendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Comercial.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 452);
            this.Controls.Add(this.vendasDataGridView);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.buscarVendasButton);
            this.Name = "VendasForm";
            this.ShowIcon = false;
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscarVendasButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.DataGridView vendasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
    }
}