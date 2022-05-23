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
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
			String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
			MySqlConnection conexao = new MySqlConnection(conn);

			try
			{
				conexao.Open();
				MySqlCommand comando = new MySqlCommand();
				comando = conexao.CreateCommand();

				comando.CommandText = "insert into usuario(Nome, senha) values(@nome, @senha);";
				comando.Parameters.AddWithValue("nome", txtLoginUsuario.Text.Trim());
				comando.Parameters.AddWithValue("senha", txtSenhaUsuario.Text.Trim());
		

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
