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
	public partial class GeneroLivro : Form
	{
		public GeneroLivro()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
			MySqlConnection conexao = new MySqlConnection(conn);

			try
			{
				conexao.Open();
				MySqlCommand comando = new MySqlCommand();
				comando = conexao.CreateCommand();

				comando.CommandText = "insert into genero_livro(nm_genero ) values(@genero);";
				comando.Parameters.AddWithValue("genero", txtGenero.Text.Trim());
				


				

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
