namespace Biblioteca
{
    partial class VizualizarUsuario
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
            this.dgVizualizarUsuario = new System.Windows.Forms.DataGridView();
            this.txtBuscaUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVizualizarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVizualizarUsuario
            // 
            this.dgVizualizarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVizualizarUsuario.Location = new System.Drawing.Point(31, 24);
            this.dgVizualizarUsuario.Name = "dgVizualizarUsuario";
            this.dgVizualizarUsuario.Size = new System.Drawing.Size(757, 405);
            this.dgVizualizarUsuario.TabIndex = 0;
            // 
            // txtBuscaUsuario
            // 
            this.txtBuscaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaUsuario.Location = new System.Drawing.Point(43, 458);
            this.txtBuscaUsuario.Name = "txtBuscaUsuario";
            this.txtBuscaUsuario.Size = new System.Drawing.Size(643, 20);
            this.txtBuscaUsuario.TabIndex = 1;
            this.txtBuscaUsuario.TextChanged += new System.EventHandler(this.txtBuscaUsuario_TextChanged);
            // 
            // VizualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.txtBuscaUsuario);
            this.Controls.Add(this.dgVizualizarUsuario);
            this.Name = "VizualizarUsuario";
            this.Text = "VizualizarUsuario";
            this.Load += new System.EventHandler(this.VizualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVizualizarUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVizualizarUsuario;
        private System.Windows.Forms.TextBox txtBuscaUsuario;
    }
}