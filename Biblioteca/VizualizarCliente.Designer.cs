namespace Biblioteca
{
    partial class VizualizarCliente
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
            this.dgDadosCliente = new System.Windows.Forms.DataGridView();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDadosCliente
            // 
            this.dgDadosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDadosCliente.Location = new System.Drawing.Point(12, 12);
            this.dgDadosCliente.Name = "dgDadosCliente";
            this.dgDadosCliente.Size = new System.Drawing.Size(1205, 433);
            this.dgDadosCliente.TabIndex = 0;
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaCliente.Location = new System.Drawing.Point(12, 483);
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(1086, 20);
            this.txtBuscaCliente.TabIndex = 1;
            this.txtBuscaCliente.TextChanged += new System.EventHandler(this.txtBuscaCliente_TextChanged);
            // 
            // VizualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 670);
            this.Controls.Add(this.txtBuscaCliente);
            this.Controls.Add(this.dgDadosCliente);
            this.Name = "VizualizarCliente";
            this.Text = "VizualizarCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDadosCliente;
        private System.Windows.Forms.TextBox txtBuscaCliente;
    }
}