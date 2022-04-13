
namespace Biblioteca
{
	partial class Cliente
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
			this.txtClienteCelular = new System.Windows.Forms.MaskedTextBox();
			this.txtClienteBairro = new System.Windows.Forms.TextBox();
			this.lblClienteBairro = new System.Windows.Forms.Label();
			this.btnClienteSalvar = new System.Windows.Forms.Button();
			this.lblClienteData = new System.Windows.Forms.Label();
			this.txtClienteCep = new System.Windows.Forms.TextBox();
			this.lblClienteCep = new System.Windows.Forms.Label();
			this.txtClienteComplemento = new System.Windows.Forms.TextBox();
			this.lblClienteComplemento = new System.Windows.Forms.Label();
			this.cbxClienteEstado = new System.Windows.Forms.ComboBox();
			this.lblClienteEstado = new System.Windows.Forms.Label();
			this.txtClienteCidade = new System.Windows.Forms.TextBox();
			this.lblClienteCidade = new System.Windows.Forms.Label();
			this.txtClienteNumero = new System.Windows.Forms.TextBox();
			this.lblClienteNumero = new System.Windows.Forms.Label();
			this.TxtClienteEndereco = new System.Windows.Forms.TextBox();
			this.lblClienteEndereco = new System.Windows.Forms.Label();
			this.lblClienteCelular = new System.Windows.Forms.Label();
			this.txtClienteSobrenome = new System.Windows.Forms.TextBox();
			this.lblClienteSobrenome = new System.Windows.Forms.Label();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.lblCLienteCPF = new System.Windows.Forms.Label();
			this.txtCLienteNome = new System.Windows.Forms.TextBox();
			this.lblClienteNome = new System.Windows.Forms.Label();
			this.txtClienteId = new System.Windows.Forms.TextBox();
			this.lblCLienteId = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// txtClienteCelular
			// 
			this.txtClienteCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClienteCelular.Location = new System.Drawing.Point(551, 109);
			this.txtClienteCelular.Mask = "(99) 00000-0000";
			this.txtClienteCelular.Name = "txtClienteCelular";
			this.txtClienteCelular.Size = new System.Drawing.Size(111, 20);
			this.txtClienteCelular.TabIndex = 53;
			// 
			// txtClienteBairro
			// 
			this.txtClienteBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClienteBairro.Location = new System.Drawing.Point(90, 185);
			this.txtClienteBairro.Name = "txtClienteBairro";
			this.txtClienteBairro.Size = new System.Drawing.Size(217, 20);
			this.txtClienteBairro.TabIndex = 38;
			// 
			// lblClienteBairro
			// 
			this.lblClienteBairro.AutoSize = true;
			this.lblClienteBairro.Location = new System.Drawing.Point(47, 193);
			this.lblClienteBairro.Name = "lblClienteBairro";
			this.lblClienteBairro.Size = new System.Drawing.Size(34, 13);
			this.lblClienteBairro.TabIndex = 52;
			this.lblClienteBairro.Text = "Bairro";
			// 
			// btnClienteSalvar
			// 
			this.btnClienteSalvar.Location = new System.Drawing.Point(89, 301);
			this.btnClienteSalvar.Name = "btnClienteSalvar";
			this.btnClienteSalvar.Size = new System.Drawing.Size(100, 23);
			this.btnClienteSalvar.TabIndex = 51;
			this.btnClienteSalvar.Text = "Salvar";
			this.btnClienteSalvar.UseVisualStyleBackColor = true;
			// 
			// lblClienteData
			// 
			this.lblClienteData.AutoSize = true;
			this.lblClienteData.Location = new System.Drawing.Point(446, 263);
			this.lblClienteData.Name = "lblClienteData";
			this.lblClienteData.Size = new System.Drawing.Size(89, 13);
			this.lblClienteData.TabIndex = 50;
			this.lblClienteData.Text = "Data Nascimento";
			// 
			// txtClienteCep
			// 
			this.txtClienteCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClienteCep.Location = new System.Drawing.Point(552, 226);
			this.txtClienteCep.Name = "txtClienteCep";
			this.txtClienteCep.Size = new System.Drawing.Size(111, 20);
			this.txtClienteCep.TabIndex = 43;
			// 
			// lblClienteCep
			// 
			this.lblClienteCep.AutoSize = true;
			this.lblClienteCep.Location = new System.Drawing.Point(508, 228);
			this.lblClienteCep.Name = "lblClienteCep";
			this.lblClienteCep.Size = new System.Drawing.Size(28, 13);
			this.lblClienteCep.TabIndex = 49;
			this.lblClienteCep.Text = "CEP";
			// 
			// txtClienteComplemento
			// 
			this.txtClienteComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClienteComplemento.Location = new System.Drawing.Point(90, 226);
			this.txtClienteComplemento.Name = "txtClienteComplemento";
			this.txtClienteComplemento.Size = new System.Drawing.Size(393, 20);
			this.txtClienteComplemento.TabIndex = 41;
			// 
			// lblClienteComplemento
			// 
			this.lblClienteComplemento.AutoSize = true;
			this.lblClienteComplemento.Location = new System.Drawing.Point(12, 228);
			this.lblClienteComplemento.Name = "lblClienteComplemento";
			this.lblClienteComplemento.Size = new System.Drawing.Size(71, 13);
			this.lblClienteComplemento.TabIndex = 48;
			this.lblClienteComplemento.Text = "Complemento";
			// 
			// cbxClienteEstado
			// 
			this.cbxClienteEstado.FormattingEnabled = true;
			this.cbxClienteEstado.ItemHeight = 13;
			this.cbxClienteEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
			this.cbxClienteEstado.Location = new System.Drawing.Point(89, 260);
			this.cbxClienteEstado.Name = "cbxClienteEstado";
			this.cbxClienteEstado.Size = new System.Drawing.Size(111, 21);
			this.cbxClienteEstado.TabIndex = 45;
			// 
			// lblClienteEstado
			// 
			this.lblClienteEstado.AutoSize = true;
			this.lblClienteEstado.Location = new System.Drawing.Point(41, 260);
			this.lblClienteEstado.Name = "lblClienteEstado";
			this.lblClienteEstado.Size = new System.Drawing.Size(40, 13);
			this.lblClienteEstado.TabIndex = 47;
			this.lblClienteEstado.Text = "Estado";
			// 
			// txtClienteCidade
			// 
			this.txtClienteCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClienteCidade.Location = new System.Drawing.Point(377, 186);
			this.txtClienteCidade.Name = "txtClienteCidade";
			this.txtClienteCidade.Size = new System.Drawing.Size(286, 20);
			this.txtClienteCidade.TabIndex = 40;
			// 
			// lblClienteCidade
			// 
			this.lblClienteCidade.AutoSize = true;
			this.lblClienteCidade.Location = new System.Drawing.Point(313, 188);
			this.lblClienteCidade.Name = "lblClienteCidade";
			this.lblClienteCidade.Size = new System.Drawing.Size(40, 13);
			this.lblClienteCidade.TabIndex = 46;
			this.lblClienteCidade.Text = "Cidade";
			// 
			// txtClienteNumero
			// 
			this.txtClienteNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClienteNumero.Location = new System.Drawing.Point(552, 148);
			this.txtClienteNumero.Name = "txtClienteNumero";
			this.txtClienteNumero.Size = new System.Drawing.Size(111, 20);
			this.txtClienteNumero.TabIndex = 37;
			// 
			// lblClienteNumero
			// 
			this.lblClienteNumero.AutoSize = true;
			this.lblClienteNumero.Location = new System.Drawing.Point(492, 148);
			this.lblClienteNumero.Name = "lblClienteNumero";
			this.lblClienteNumero.Size = new System.Drawing.Size(44, 13);
			this.lblClienteNumero.TabIndex = 44;
			this.lblClienteNumero.Text = "Numero";
			// 
			// TxtClienteEndereco
			// 
			this.TxtClienteEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtClienteEndereco.Location = new System.Drawing.Point(90, 148);
			this.TxtClienteEndereco.Name = "TxtClienteEndereco";
			this.TxtClienteEndereco.Size = new System.Drawing.Size(393, 20);
			this.TxtClienteEndereco.TabIndex = 36;
			// 
			// lblClienteEndereco
			// 
			this.lblClienteEndereco.AutoSize = true;
			this.lblClienteEndereco.Location = new System.Drawing.Point(29, 148);
			this.lblClienteEndereco.Name = "lblClienteEndereco";
			this.lblClienteEndereco.Size = new System.Drawing.Size(53, 13);
			this.lblClienteEndereco.TabIndex = 42;
			this.lblClienteEndereco.Text = "Endereço";
			// 
			// lblClienteCelular
			// 
			this.lblClienteCelular.AutoSize = true;
			this.lblClienteCelular.Location = new System.Drawing.Point(499, 116);
			this.lblClienteCelular.Name = "lblClienteCelular";
			this.lblClienteCelular.Size = new System.Drawing.Size(39, 13);
			this.lblClienteCelular.TabIndex = 39;
			this.lblClienteCelular.Text = "Celular";
			// 
			// txtClienteSobrenome
			// 
			this.txtClienteSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClienteSobrenome.Location = new System.Drawing.Point(89, 110);
			this.txtClienteSobrenome.Name = "txtClienteSobrenome";
			this.txtClienteSobrenome.Size = new System.Drawing.Size(393, 20);
			this.txtClienteSobrenome.TabIndex = 34;
			// 
			// lblClienteSobrenome
			// 
			this.lblClienteSobrenome.AutoSize = true;
			this.lblClienteSobrenome.Location = new System.Drawing.Point(21, 110);
			this.lblClienteSobrenome.Name = "lblClienteSobrenome";
			this.lblClienteSobrenome.Size = new System.Drawing.Size(61, 13);
			this.lblClienteSobrenome.TabIndex = 35;
			this.lblClienteSobrenome.Text = "Sobrenome";
			// 
			// txtCPF
			// 
			this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCPF.Location = new System.Drawing.Point(551, 76);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(111, 20);
			this.txtCPF.TabIndex = 32;
			// 
			// lblCLienteCPF
			// 
			this.lblCLienteCPF.AutoSize = true;
			this.lblCLienteCPF.Location = new System.Drawing.Point(508, 76);
			this.lblCLienteCPF.Name = "lblCLienteCPF";
			this.lblCLienteCPF.Size = new System.Drawing.Size(27, 13);
			this.lblCLienteCPF.TabIndex = 33;
			this.lblCLienteCPF.Text = "CPF";
			// 
			// txtCLienteNome
			// 
			this.txtCLienteNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCLienteNome.Location = new System.Drawing.Point(89, 76);
			this.txtCLienteNome.Name = "txtCLienteNome";
			this.txtCLienteNome.Size = new System.Drawing.Size(393, 20);
			this.txtCLienteNome.TabIndex = 31;
			// 
			// lblClienteNome
			// 
			this.lblClienteNome.AutoSize = true;
			this.lblClienteNome.Location = new System.Drawing.Point(46, 76);
			this.lblClienteNome.Name = "lblClienteNome";
			this.lblClienteNome.Size = new System.Drawing.Size(35, 13);
			this.lblClienteNome.TabIndex = 30;
			this.lblClienteNome.Text = "Nome";
			// 
			// txtClienteId
			// 
			this.txtClienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClienteId.Location = new System.Drawing.Point(89, 44);
			this.txtClienteId.Name = "txtClienteId";
			this.txtClienteId.ReadOnly = true;
			this.txtClienteId.Size = new System.Drawing.Size(100, 20);
			this.txtClienteId.TabIndex = 29;
			this.txtClienteId.Text = "0";
			// 
			// lblCLienteId
			// 
			this.lblCLienteId.AutoSize = true;
			this.lblCLienteId.Location = new System.Drawing.Point(64, 44);
			this.lblCLienteId.Name = "lblCLienteId";
			this.lblCLienteId.Size = new System.Drawing.Size(18, 13);
			this.lblCLienteId.TabIndex = 28;
			this.lblCLienteId.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(222, 260);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 55;
			this.label1.Text = "País";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(269, 258);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 56;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.maskedTextBox1.Location = new System.Drawing.Point(552, 257);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(111, 20);
			this.maskedTextBox1.TabIndex = 57;
			// 
			// Cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 621);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtClienteCelular);
			this.Controls.Add(this.txtClienteBairro);
			this.Controls.Add(this.lblClienteBairro);
			this.Controls.Add(this.btnClienteSalvar);
			this.Controls.Add(this.lblClienteData);
			this.Controls.Add(this.txtClienteCep);
			this.Controls.Add(this.lblClienteCep);
			this.Controls.Add(this.txtClienteComplemento);
			this.Controls.Add(this.lblClienteComplemento);
			this.Controls.Add(this.cbxClienteEstado);
			this.Controls.Add(this.lblClienteEstado);
			this.Controls.Add(this.txtClienteCidade);
			this.Controls.Add(this.lblClienteCidade);
			this.Controls.Add(this.txtClienteNumero);
			this.Controls.Add(this.lblClienteNumero);
			this.Controls.Add(this.TxtClienteEndereco);
			this.Controls.Add(this.lblClienteEndereco);
			this.Controls.Add(this.lblClienteCelular);
			this.Controls.Add(this.txtClienteSobrenome);
			this.Controls.Add(this.lblClienteSobrenome);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.lblCLienteCPF);
			this.Controls.Add(this.txtCLienteNome);
			this.Controls.Add(this.lblClienteNome);
			this.Controls.Add(this.txtClienteId);
			this.Controls.Add(this.lblCLienteId);
			this.Name = "Cliente";
			this.Text = "Cliente";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MaskedTextBox txtClienteCelular;
		private System.Windows.Forms.TextBox txtClienteBairro;
		private System.Windows.Forms.Label lblClienteBairro;
		private System.Windows.Forms.Button btnClienteSalvar;
		private System.Windows.Forms.Label lblClienteData;
		private System.Windows.Forms.TextBox txtClienteCep;
		private System.Windows.Forms.Label lblClienteCep;
		private System.Windows.Forms.TextBox txtClienteComplemento;
		private System.Windows.Forms.Label lblClienteComplemento;
		private System.Windows.Forms.ComboBox cbxClienteEstado;
		private System.Windows.Forms.Label lblClienteEstado;
		private System.Windows.Forms.TextBox txtClienteCidade;
		private System.Windows.Forms.Label lblClienteCidade;
		private System.Windows.Forms.TextBox txtClienteNumero;
		private System.Windows.Forms.Label lblClienteNumero;
		private System.Windows.Forms.TextBox TxtClienteEndereco;
		private System.Windows.Forms.Label lblClienteEndereco;
		private System.Windows.Forms.Label lblClienteCelular;
		private System.Windows.Forms.TextBox txtClienteSobrenome;
		private System.Windows.Forms.Label lblClienteSobrenome;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.Label lblCLienteCPF;
		private System.Windows.Forms.TextBox txtCLienteNome;
		private System.Windows.Forms.Label lblClienteNome;
		private System.Windows.Forms.TextBox txtClienteId;
		private System.Windows.Forms.Label lblCLienteId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}