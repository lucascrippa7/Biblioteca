namespace Biblioteca
{
    partial class VizualizarGenero
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
            this.dgVizuGenero = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgVizuGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVizuGenero
            // 
            this.dgVizuGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVizuGenero.Location = new System.Drawing.Point(12, 12);
            this.dgVizuGenero.Name = "dgVizuGenero";
            this.dgVizuGenero.Size = new System.Drawing.Size(776, 426);
            this.dgVizuGenero.TabIndex = 0;
            this.dgVizuGenero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVizuGenero_CellClick);
            // 
            // VizualizarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 593);
            this.Controls.Add(this.dgVizuGenero);
            this.Name = "VizualizarGenero";
            this.Text = "VizualizarGenero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizarGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVizuGenero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVizuGenero;
    }
}