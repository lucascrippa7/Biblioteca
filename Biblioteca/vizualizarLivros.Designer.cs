namespace Biblioteca
{
    partial class vizualizarLivros
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
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDados
            // 
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(12, 26);
            this.dgDados.Name = "dgDados";
            this.dgDados.Size = new System.Drawing.Size(1009, 497);
            this.dgDados.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(357, 550);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // vizualizarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 607);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgDados);
            this.Name = "vizualizarLivros";
            this.Text = "vizualizarLivros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.vizualizarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button btnAtualizar;
    }
}