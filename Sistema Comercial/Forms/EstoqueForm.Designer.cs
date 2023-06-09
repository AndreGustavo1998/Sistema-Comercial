namespace Sistema_Comercial.Forms
{
    partial class EstoqueForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.quantidadeTxtBox = new System.Windows.Forms.TextBox();
            this.tipoTxtBox = new System.Windows.Forms.TextBox();
            this.valorLabel = new System.Windows.Forms.Label();
            this.valorTxtBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(30, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 16);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(33, 32);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(147, 22);
            this.idTxtBox.TabIndex = 1;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(30, 69);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(44, 16);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Nome";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(30, 124);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(77, 16);
            this.quantidadeLabel.TabIndex = 3;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(30, 185);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(35, 16);
            this.tipoLabel.TabIndex = 4;
            this.tipoLabel.Text = "Tipo";
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.Location = new System.Drawing.Point(33, 88);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(454, 22);
            this.nomeTxtBox.TabIndex = 5;
            // 
            // quantidadeTxtBox
            // 
            this.quantidadeTxtBox.Location = new System.Drawing.Point(33, 143);
            this.quantidadeTxtBox.Name = "quantidadeTxtBox";
            this.quantidadeTxtBox.Size = new System.Drawing.Size(74, 22);
            this.quantidadeTxtBox.TabIndex = 6;
            // 
            // tipoTxtBox
            // 
            this.tipoTxtBox.Location = new System.Drawing.Point(33, 206);
            this.tipoTxtBox.Name = "tipoTxtBox";
            this.tipoTxtBox.Size = new System.Drawing.Size(273, 22);
            this.tipoTxtBox.TabIndex = 7;
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(486, 185);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(39, 16);
            this.valorLabel.TabIndex = 8;
            this.valorLabel.Text = "Valor";
            // 
            // valorTxtBox
            // 
            this.valorTxtBox.Location = new System.Drawing.Point(489, 206);
            this.valorTxtBox.Name = "valorTxtBox";
            this.valorTxtBox.Size = new System.Drawing.Size(238, 22);
            this.valorTxtBox.TabIndex = 9;
            // 
            // salvarButton
            // 
            this.salvarButton.BackColor = System.Drawing.Color.White;
            this.salvarButton.Location = new System.Drawing.Point(489, 251);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(96, 40);
            this.salvarButton.TabIndex = 10;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.BackColor = System.Drawing.Color.White;
            this.fecharButton.Location = new System.Drawing.Point(648, 252);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(79, 39);
            this.fecharButton.TabIndex = 11;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = false;
            this.fecharButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // EstoqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.valorTxtBox);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.tipoTxtBox);
            this.Controls.Add(this.quantidadeTxtBox);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.idLabel);
            this.Name = "EstoqueForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produto";
            this.Load += new System.EventHandler(this.EstoqueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.TextBox quantidadeTxtBox;
        private System.Windows.Forms.TextBox tipoTxtBox;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.TextBox valorTxtBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button fecharButton;
    }
}