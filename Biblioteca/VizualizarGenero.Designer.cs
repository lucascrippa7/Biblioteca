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
            this.txtBuscaGenero = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
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
            // txtBuscaGenero
            // 
            this.txtBuscaGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaGenero.Location = new System.Drawing.Point(12, 465);
            this.txtBuscaGenero.Name = "txtBuscaGenero";
            this.txtBuscaGenero.Size = new System.Drawing.Size(549, 20);
            this.txtBuscaGenero.TabIndex = 1;
            this.txtBuscaGenero.TextChanged += new System.EventHandler(this.txtBuscaGenero_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(596, 465);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(713, 462);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // VizualizarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 593);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBuscaGenero);
            this.Controls.Add(this.dgVizuGenero);
            this.Name = "VizualizarGenero";
            this.Text = "VizualizarGenero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizarGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVizuGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVizuGenero;
        private System.Windows.Forms.TextBox txtBuscaGenero;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeletar;
    }
}