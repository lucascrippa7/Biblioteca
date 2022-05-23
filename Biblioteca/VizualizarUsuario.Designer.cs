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
            ((System.ComponentModel.ISupportInitialize)(this.dgVizualizarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVizualizarUsuario
            // 
            this.dgVizualizarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVizualizarUsuario.Location = new System.Drawing.Point(31, 24);
            this.dgVizualizarUsuario.Name = "dgVizualizarUsuario";
            this.dgVizualizarUsuario.Size = new System.Drawing.Size(388, 150);
            this.dgVizualizarUsuario.TabIndex = 0;
            // 
            // VizualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgVizualizarUsuario);
            this.Name = "VizualizarUsuario";
            this.Text = "VizualizarUsuario";
            this.Load += new System.EventHandler(this.VizualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVizualizarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVizualizarUsuario;
    }
}