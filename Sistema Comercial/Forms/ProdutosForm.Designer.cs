namespace Sistema_Comercial.Forms
{
    partial class ProdutosForm
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
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.listarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.AllowUserToAddRows = false;
            this.listaDataGridView.AllowUserToDeleteRows = false;
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.tipoColumn,
            this.nomeColumn,
            this.qtdColumn,
            this.valorColumn});
            this.listaDataGridView.Location = new System.Drawing.Point(13, 69);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.ReadOnly = true;
            this.listaDataGridView.RowHeadersWidth = 51;
            this.listaDataGridView.RowTemplate.Height = 24;
            this.listaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaDataGridView.Size = new System.Drawing.Size(846, 301);
            this.listaDataGridView.TabIndex = 1;
            this.listaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDataGridView_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 80;
            // 
            // tipoColumn
            // 
            this.tipoColumn.DataPropertyName = "Tipo";
            this.tipoColumn.HeaderText = "Tipo";
            this.tipoColumn.MinimumWidth = 6;
            this.tipoColumn.Name = "tipoColumn";
            this.tipoColumn.ReadOnly = true;
            this.tipoColumn.Width = 125;
            // 
            // nomeColumn
            // 
            this.nomeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeColumn.DataPropertyName = "Nome";
            this.nomeColumn.HeaderText = "Nome do Produto";
            this.nomeColumn.MinimumWidth = 6;
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // qtdColumn
            // 
            this.qtdColumn.DataPropertyName = "Quantidade";
            this.qtdColumn.HeaderText = "Quantidade";
            this.qtdColumn.MinimumWidth = 6;
            this.qtdColumn.Name = "qtdColumn";
            this.qtdColumn.ReadOnly = true;
            this.qtdColumn.Width = 125;
            // 
            // valorColumn
            // 
            this.valorColumn.DataPropertyName = "Valor";
            this.valorColumn.HeaderText = "Valor";
            this.valorColumn.MinimumWidth = 6;
            this.valorColumn.Name = "valorColumn";
            this.valorColumn.ReadOnly = true;
            this.valorColumn.Width = 125;
            // 
            // fecharButton
            // 
            this.fecharButton.BackColor = System.Drawing.Color.White;
            this.fecharButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharButton.Image = global::Sistema_Comercial.Properties.Resources.close;
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(759, 391);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(100, 40);
            this.fecharButton.TabIndex = 5;
            this.fecharButton.Text = "     Fechar";
            this.fecharButton.UseVisualStyleBackColor = false;
            this.fecharButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.BackColor = System.Drawing.Color.White;
            this.alterarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarButton.Image = global::Sistema_Comercial.Properties.Resources.alterar;
            this.alterarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarButton.Location = new System.Drawing.Point(644, 391);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(94, 40);
            this.alterarButton.TabIndex = 4;
            this.alterarButton.Text = "    Alterar";
            this.alterarButton.UseVisualStyleBackColor = false;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.BackColor = System.Drawing.Color.White;
            this.novoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoButton.Image = global::Sistema_Comercial.Properties.Resources.adicionar;
            this.novoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoButton.Location = new System.Drawing.Point(519, 391);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(102, 40);
            this.novoButton.TabIndex = 3;
            this.novoButton.Text = "   Novo";
            this.novoButton.UseVisualStyleBackColor = false;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.BackColor = System.Drawing.Color.White;
            this.excluirButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirButton.Image = global::Sistema_Comercial.Properties.Resources.delete;
            this.excluirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirButton.Location = new System.Drawing.Point(409, 391);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(93, 40);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "   Excluir";
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // listarButton
            // 
            this.listarButton.BackColor = System.Drawing.Color.White;
            this.listarButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarButton.Image = global::Sistema_Comercial.Properties.Resources.listar;
            this.listarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listarButton.Location = new System.Drawing.Point(13, 13);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(227, 50);
            this.listarButton.TabIndex = 0;
            this.listarButton.Text = "Listar Produtos";
            this.listarButton.UseVisualStyleBackColor = false;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Comercial.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 460);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.listaDataGridView);
            this.Controls.Add(this.listarButton);
            this.Name = "ProdutosForm";
            this.ShowIcon = false;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ProdutosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.DataGridView listaDataGridView;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorColumn;
    }
}