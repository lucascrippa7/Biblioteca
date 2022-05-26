
namespace Biblioteca
{
	partial class Transacao
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbtransacao = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.dgLivros = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtPesquisaLivro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Livro";
            // 
            // cbtransacao
            // 
            this.cbtransacao.FormattingEnabled = true;
            this.cbtransacao.Location = new System.Drawing.Point(127, 32);
            this.cbtransacao.Name = "cbtransacao";
            this.cbtransacao.Size = new System.Drawing.Size(206, 21);
            this.cbtransacao.TabIndex = 1;
            this.cbtransacao.SelectedValueChanged += new System.EventHandler(this.cbtransacao_SelectedValueChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(127, 109);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(477, 21);
            this.cbCliente.TabIndex = 3;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // dgLivros
            // 
            this.dgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLivros.Location = new System.Drawing.Point(127, 205);
            this.dgLivros.Name = "dgLivros";
            this.dgLivros.Size = new System.Drawing.Size(477, 314);
            this.dgLivros.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Efetuar Transação";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtdata
            // 
            this.txtdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdata.Location = new System.Drawing.Point(127, 71);
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(100, 20);
            this.txtdata.TabIndex = 17;
            this.txtdata.TextChanged += new System.EventHandler(this.txtdata_TextChanged);
            // 
            // txtPesquisaLivro
            // 
            this.txtPesquisaLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisaLivro.Location = new System.Drawing.Point(127, 165);
            this.txtPesquisaLivro.Name = "txtPesquisaLivro";
            this.txtPesquisaLivro.Size = new System.Drawing.Size(477, 20);
            this.txtPesquisaLivro.TabIndex = 18;
            this.txtPesquisaLivro.TextChanged += new System.EventHandler(this.txtPesquisaLivro_TextChanged);
            // 
            // Transacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 620);
            this.Controls.Add(this.txtPesquisaLivro);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgLivros);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbtransacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Transacao";
            this.Text = "Transacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbtransacao;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DataGridView dgLivros;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txtPesquisaLivro;
    }
}