
namespace Biblioteca
{
	partial class TipoTransacao
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
            this.label2 = new System.Windows.Forms.Label();
            this.txttipo_transacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Transação";
            // 
            // txttipo_transacao
            // 
            this.txttipo_transacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipo_transacao.Location = new System.Drawing.Point(106, 23);
            this.txttipo_transacao.Name = "txttipo_transacao";
            this.txttipo_transacao.Size = new System.Drawing.Size(202, 20);
            this.txttipo_transacao.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TipoTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttipo_transacao);
            this.Controls.Add(this.label2);
            this.Name = "TipoTransacao";
            this.Text = "TipoTransacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txttipo_transacao;
		private System.Windows.Forms.Button button1;
	}
}