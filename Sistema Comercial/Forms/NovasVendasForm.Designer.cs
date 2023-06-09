namespace Sistema_Comercial.Forms
{
    partial class NovasVendasForm
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
            this.nomaClienteLabel = new System.Windows.Forms.Label();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.qtdLabel = new System.Windows.Forms.Label();
            this.qtdVendasTxtBox = new System.Windows.Forms.TextBox();
            this.valorLabel = new System.Windows.Forms.Label();
            this.valorTxtBox = new System.Windows.Forms.TextBox();
            this.fecharButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomaClienteLabel
            // 
            this.nomaClienteLabel.AutoSize = true;
            this.nomaClienteLabel.Location = new System.Drawing.Point(28, 26);
            this.nomaClienteLabel.Name = "nomaClienteLabel";
            this.nomaClienteLabel.Size = new System.Drawing.Size(113, 16);
            this.nomaClienteLabel.TabIndex = 2;
            this.nomaClienteLabel.Text = "Nome do Produto";
            this.nomaClienteLabel.Click += new System.EventHandler(this.nomaClienteLabel_Click);
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.Location = new System.Drawing.Point(31, 60);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(195, 22);
            this.nomeTxtBox.TabIndex = 3;
            // 
            // qtdLabel
            // 
            this.qtdLabel.AutoSize = true;
            this.qtdLabel.Location = new System.Drawing.Point(28, 106);
            this.qtdLabel.Name = "qtdLabel";
            this.qtdLabel.Size = new System.Drawing.Size(146, 16);
            this.qtdLabel.TabIndex = 4;
            this.qtdLabel.Text = "Quantidade de Vendas";
            // 
            // qtdVendasTxtBox
            // 
            this.qtdVendasTxtBox.Location = new System.Drawing.Point(31, 135);
            this.qtdVendasTxtBox.Name = "qtdVendasTxtBox";
            this.qtdVendasTxtBox.Size = new System.Drawing.Size(143, 22);
            this.qtdVendasTxtBox.TabIndex = 5;
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(28, 175);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(73, 16);
            this.valorLabel.TabIndex = 6;
            this.valorLabel.Text = "Valor Total";
            // 
            // valorTxtBox
            // 
            this.valorTxtBox.Location = new System.Drawing.Point(31, 205);
            this.valorTxtBox.Name = "valorTxtBox";
            this.valorTxtBox.Size = new System.Drawing.Size(143, 22);
            this.valorTxtBox.TabIndex = 7;
            // 
            // fecharButton
            // 
            this.fecharButton.BackColor = System.Drawing.Color.White;
            this.fecharButton.Location = new System.Drawing.Point(666, 320);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(99, 47);
            this.fecharButton.TabIndex = 8;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = false;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.BackColor = System.Drawing.Color.White;
            this.salvarButton.Location = new System.Drawing.Point(535, 320);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(108, 47);
            this.salvarButton.TabIndex = 9;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // NovasVendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 379);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.valorTxtBox);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.qtdVendasTxtBox);
            this.Controls.Add(this.qtdLabel);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.nomaClienteLabel);
            this.Name = "NovasVendasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novas Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomaClienteLabel;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.Label qtdLabel;
        private System.Windows.Forms.TextBox qtdVendasTxtBox;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.TextBox valorTxtBox;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button salvarButton;
    }
}