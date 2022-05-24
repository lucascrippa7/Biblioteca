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
            this.txtBuscaLivros = new System.Windows.Forms.TextBox();
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
            // txtBuscaLivros
            // 
            this.txtBuscaLivros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaLivros.Location = new System.Drawing.Point(12, 555);
            this.txtBuscaLivros.Name = "txtBuscaLivros";
            this.txtBuscaLivros.Size = new System.Drawing.Size(726, 20);
            this.txtBuscaLivros.TabIndex = 1;
            this.txtBuscaLivros.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vizualizarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 607);
            this.Controls.Add(this.txtBuscaLivros);
            this.Controls.Add(this.dgDados);
            this.Name = "vizualizarLivros";
            this.Text = "vizualizarLivros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.vizualizarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.TextBox txtBuscaLivros;
    }
}