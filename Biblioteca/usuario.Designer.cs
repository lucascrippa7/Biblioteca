namespace Biblioteca
{
    partial class usuario
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
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Location = new System.Drawing.Point(25, 32);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(33, 13);
            this.lblLoginUsuario.TabIndex = 2;
            this.lblLoginUsuario.Text = "Login";
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginUsuario.Location = new System.Drawing.Point(81, 32);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsuario.TabIndex = 3;
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Location = new System.Drawing.Point(23, 71);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaUsuario.TabIndex = 4;
            this.lblSenhaUsuario.Text = "Senha";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaUsuario.Location = new System.Drawing.Point(81, 68);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaUsuario.TabIndex = 5;
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Location = new System.Drawing.Point(81, 114);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUsuario.TabIndex = 6;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 841);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.lblLoginUsuario);
            this.Name = "usuario";
            this.Text = "usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Button btnSalvarUsuario;
    }
}