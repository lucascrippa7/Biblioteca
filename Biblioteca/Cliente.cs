using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
	public partial class Cliente : Form
	{
		public Cliente()
		{
			InitializeComponent();
		}

		private void btnClienteSalvar_Click(object sender, EventArgs e)
		{
			String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
			MySqlConnection conexao = new MySqlConnection(conn);

			try
			{
				conexao.Open();
				MySqlCommand comando = new MySqlCommand();
				comando = conexao.CreateCommand();

				comando.CommandText = "insert into cliente(nm_cliente, nr_cpf, dt_nascimento, nm_endereco, nr_endereco, nm_complemento, nm_bairro," +
                    " nm_cidade, nm_estado, nm_pais, nr_cep, celular) values(@cliente, @cpf, @dtnasc, @endereco, @numero, @complemento, @bairro, " +
                    "@cidade, @estado, @pais, @cep, @celular);";
				comando.Parameters.AddWithValue("cliente", txtCLienteNome.Text.Trim());
				comando.Parameters.AddWithValue("cpf", txtCPF.Text.Trim());
				comando.Parameters.AddWithValue("dtnasc", txtnascimento.Text.Trim());
				comando.Parameters.AddWithValue("endereco", TxtClienteEndereco.Text.Trim());
				comando.Parameters.AddWithValue("numero", txtClienteNumero.Text.Trim());
				comando.Parameters.AddWithValue("complemento", txtClienteComplemento.Text.Trim());
				comando.Parameters.AddWithValue("bairro", txtClienteBairro.Text.Trim());
				comando.Parameters.AddWithValue("cidade", txtClienteCidade.Text.Trim());
				comando.Parameters.AddWithValue("estado", cbxClienteEstado.Text.Trim());
				comando.Parameters.AddWithValue("pais", txtpais.Text.Trim());
				comando.Parameters.AddWithValue("cep", txtClienteCep.Text.Trim());
				comando.Parameters.AddWithValue("celular", txtClienteCelular.Text.Trim());
				
				int valorretorno = comando.ExecuteNonQuery();
				if (valorretorno < 1)
					MessageBox.Show("Erro ao inserir");
				else
					MessageBox.Show("inserido com sucesso");
			}
			catch (MySqlException msqle)
			{
				MessageBox.Show("Erro de acesso ao MySQL: " + msqle.Message, "erro");
			}
			finally
			{
				conexao.Close();
			}
		}
	}
}
