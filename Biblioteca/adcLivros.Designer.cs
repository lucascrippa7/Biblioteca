namespace Biblioteca
{
    partial class adcLivros
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
            this.lvAddLivros = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvAddLivros
            // 
            this.lvAddLivros.HideSelection = false;
            this.lvAddLivros.Location = new System.Drawing.Point(68, 85);
            this.lvAddLivros.Name = "lvAddLivros";
            this.lvAddLivros.Size = new System.Drawing.Size(615, 316);
            this.lvAddLivros.TabIndex = 0;
            this.lvAddLivros.UseCompatibleStateImageBehavior = false;
            // 
            // adcLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAddLivros);
            this.Name = "adcLivros";
            this.Text = "adcLivros";
            this.Load += new System.EventHandler(this.adcLivros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAddLivros;
    }
}