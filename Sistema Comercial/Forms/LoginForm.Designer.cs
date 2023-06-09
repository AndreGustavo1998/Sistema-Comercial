namespace Sistema_Comercial.Forms
{
    partial class LoginForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.entrarButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.Location = new System.Drawing.Point(333, 281);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(192, 30);
            this.loginTextBox.TabIndex = 0;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(333, 333);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(192, 30);
            this.senhaTextBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(241, 281);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(70, 24);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabel.Location = new System.Drawing.Point(241, 333);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(76, 24);
            this.senhaLabel.TabIndex = 3;
            this.senhaLabel.Text = "Senha:";
            // 
            // entrarButton
            // 
            this.entrarButton.BackColor = System.Drawing.Color.Turquoise;
            this.entrarButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarButton.Location = new System.Drawing.Point(363, 371);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(114, 49);
            this.entrarButton.TabIndex = 4;
            this.entrarButton.Text = "Entrar";
            this.entrarButton.UseVisualStyleBackColor = false;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Sistema_Comercial.Properties.Resources.entrar;
            this.pictureBox.Location = new System.Drawing.Point(258, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 267);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.entrarButton);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}