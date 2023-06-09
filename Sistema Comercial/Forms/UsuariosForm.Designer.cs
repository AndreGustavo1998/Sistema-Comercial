namespace Sistema_Comercial.Forms
{
    partial class UsuariosForm
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
            this.fecharButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.AllowUserToAddRows = false;
            this.listaDataGridView.AllowUserToDeleteRows = false;
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Location = new System.Drawing.Point(36, 86);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.ReadOnly = true;
            this.listaDataGridView.RowHeadersWidth = 51;
            this.listaDataGridView.RowTemplate.Height = 24;
            this.listaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaDataGridView.Size = new System.Drawing.Size(913, 263);
            this.listaDataGridView.TabIndex = 1;
            // 
            // fecharButton
            // 
            this.fecharButton.BackColor = System.Drawing.Color.White;
            this.fecharButton.Image = global::Sistema_Comercial.Properties.Resources.close;
            this.fecharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharButton.Location = new System.Drawing.Point(848, 377);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(101, 49);
            this.fecharButton.TabIndex = 5;
            this.fecharButton.Text = "     Fechar";
            this.fecharButton.UseVisualStyleBackColor = false;
            this.fecharButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.White;
            this.buscarButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.Image = global::Sistema_Comercial.Properties.Resources.listar;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(36, 27);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(136, 53);
            this.buscarButton.TabIndex = 0;
            this.buscarButton.Text = "   Buscar";
            this.buscarButton.UseVisualStyleBackColor = false;
            this.buscarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Comercial.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 443);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.listaDataGridView);
            this.Controls.Add(this.buscarButton);
            this.Name = "UsuariosForm";
            this.ShowIcon = false;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView listaDataGridView;
        private System.Windows.Forms.Button fecharButton;
    }
}