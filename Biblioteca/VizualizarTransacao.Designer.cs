namespace Biblioteca
{
    partial class VizualizarTransacao
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
            this.dgVizuaTransacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgVizuaTransacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVizuaTransacao
            // 
            this.dgVizuaTransacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVizuaTransacao.Location = new System.Drawing.Point(52, 47);
            this.dgVizuaTransacao.Name = "dgVizuaTransacao";
            this.dgVizuaTransacao.Size = new System.Drawing.Size(251, 376);
            this.dgVizuaTransacao.TabIndex = 0;
            // 
            // VizualizarTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgVizuaTransacao);
            this.Name = "VizualizarTransacao";
            this.Text = "VizualizarTransacao";
            this.Load += new System.EventHandler(this.VizualizarTransacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVizuaTransacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVizuaTransacao;
    }
}