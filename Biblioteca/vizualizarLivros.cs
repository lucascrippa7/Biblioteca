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
    public partial class vizualizarLivros : Form
    {


		String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

		//MySqlConnection conexao = new MySqlConnection(conn);


		MySqlCommand objCommand = null;
		MySqlConnection conexao = null;


		public vizualizarLivros()
        {
            InitializeComponent();
        }

        private void vizualizarLivros_Load(object sender, EventArgs e)
        {
			listagrid();
			this.WindowState = FormWindowState.Maximized;
		}


		public void listagrid()
		{
			String strSQL = "select";
			strSQL = strSQL  +" lv.id_livro";
			strSQL = strSQL  + " ,lv.id_genero";
			strSQL = strSQL  + " ,gl.nm_genero";
			strSQL = strSQL  + " ,lv.nm_livro";
			strSQL = strSQL  + " ,lv.nm_autor";
			strSQL = strSQL  + " ,lv.nm_editora";
			strSQL = strSQL  + " ,lv.nr_ano_edicao";
			strSQL = strSQL  + " ,lv.ativo";
			strSQL = strSQL  + " from livro lv";
			strSQL = strSQL  + " left join genero_livro gl";
			strSQL = strSQL  + " on gl.id_genero = lv.id_genero";
			strSQL = strSQL  + " order by lv.nm_livro, gl.nm_genero;";

			conexao = new MySqlConnection(conn);
			objCommand = new MySqlCommand(strSQL, conexao);

			try
			{
				MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
				DataTable dtlista = new DataTable();

				objAdp.Fill(dtlista);

				dgDados.DataSource = dtlista;




				/*Adicionando coluna de combobox gênero*/
				var colcb = new DataGridViewComboBoxColumn();
				colcb.Name = "Genero";
				colcb.HeaderText = "Genero";
				dgDados.Columns.Insert(0, colcb);

		
				String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
				MySqlConnection conexao = new MySqlConnection(conn);

				conexao.Open();
				MySqlCommand comando = new MySqlCommand();
				comando = conexao.CreateCommand();
				comando.CommandText = "select * from genero_livro";
				MySqlDataReader drr = comando.ExecuteReader();
				DataTable dtt = new DataTable();
				dtt.Load(drr);
				colcb.ValueMember = "id_genero";
				colcb.DisplayMember = "nm_genero";
				colcb.DataSource = dtt;


			}
			catch
			{
				MessageBox.Show("Deu erro");
			}


		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
			String strSQL = "select * from livro where nm_livro  LIKE '%" + txtBuscaLivros.Text+ "%'";
			//strSQL = strSQL + " lv.id_livro";
			//strSQL = strSQL + " ,lv.id_genero";
			//strSQL = strSQL + " ,gl.nm_genero";
			//strSQL = strSQL + " ,lv.nm_livro";
			//strSQL = strSQL + " ,lv.nm_autor";
			//strSQL = strSQL + " ,lv.nm_editora";
			//strSQL = strSQL + " ,lv.nr_ano_edicao";
			//strSQL = strSQL + " ,lv.ativo";
			//strSQL = strSQL + " from livro lv";
			//strSQL = strSQL + " left join genero_livro gl";
			//strSQL = strSQL + " on gl.id_genero = lv.id_genero";
			//strSQL = strSQL + " order by lv.nm_livro, gl.nm_genero;";

			conexao = new MySqlConnection(conn);
			objCommand = new MySqlCommand(strSQL, conexao);

			try
			{
				MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
				DataTable dtlista = new DataTable();

				objAdp.Fill(dtlista);

				dgDados.DataSource = dtlista;




				///*Adicionando coluna de combobox gênero*/
				//var colcb = new DataGridViewComboBoxColumn();
				//colcb.Name = "Genero";
				//colcb.HeaderText = "Genero";
				//dgDados.Columns.Insert(0, colcb);
				//
				//
				//String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
				//MySqlConnection conexao = new MySqlConnection(conn);
				//
				//conexao.Open();
				//MySqlCommand comando = new MySqlCommand();
				//comando = conexao.CreateCommand();
				//comando.CommandText = "select * from genero_livro";
				//MySqlDataReader drr = comando.ExecuteReader();
				//DataTable dtt = new DataTable();
				//dtt.Load(drr);
				//colcb.ValueMember = "id_genero";
				//colcb.DisplayMember = "nm_genero";
				//colcb.DataSource = dtt;


			}
			catch
			{
				MessageBox.Show("Deu erro");
			}
		}
    }
}
