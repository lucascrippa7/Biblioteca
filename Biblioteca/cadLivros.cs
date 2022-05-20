﻿using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class cadLivros : Form
	{
		public cadLivros()
		{
			InitializeComponent();
		}

        private void cadLivros_Load(object sender, EventArgs e)
        {

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

				comando.CommandText = "insert into livro(nm_livro, nm_autor, nm_editora, nr_ano_edicao, ativo ) values(@livro, @autor, @editora, @ano, @ativo);";
				comando.Parameters.AddWithValue("livro", txtLivro.Text.Trim());
				comando.Parameters.AddWithValue("autor", txtAutor.Text.Trim());
				comando.Parameters.AddWithValue("editora", txtEditora.Text.Trim());
				comando.Parameters.AddWithValue("ano", txtAno.Text.Trim());


                if (cbxativo.Checked)
                {
					comando.Parameters.AddWithValue("ativo", 1);
                }
                else
                {
					comando.Parameters.AddWithValue("ativo", 0);
				}
					

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