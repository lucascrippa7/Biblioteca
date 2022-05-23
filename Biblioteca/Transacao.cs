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
	public partial class Transacao : Form
	{

		String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

		//MySqlConnection conexao = new MySqlConnection(conn);


		MySqlCommand objCommand = null;
		MySqlConnection conexao = null;
		public Transacao()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

        private void Transacao_Load(object sender, EventArgs e)
        {
			DateTime date = DateTime.Now;
			string date_str = date.ToString("dd/MM/yyyy");
			txtdata.Text = date_str;
			


			String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
			MySqlConnection conexao = new MySqlConnection(conn);


			conexao.Open();
			MySqlCommand comando = new MySqlCommand();
			comando = conexao.CreateCommand();

			comando.CommandText = "select * from tipo_transacao ";
			
			MySqlDataReader dr = comando.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(dr);
			cbtransacao.ValueMember = "id_tipo_transacao";
			cbtransacao.DisplayMember = "nm_tipo_transacao";
			cbtransacao.DataSource = dt;

			cbtransacao.SelectedIndex = -1;


			comando.CommandText = "select * from cliente";
			MySqlDataReader drr = comando.ExecuteReader();
			DataTable dtt = new DataTable();
			dtt.Load(drr);
			cbCliente.ValueMember = "id_cliente";
			cbCliente.DisplayMember = "nm_cliente";
			cbCliente.DataSource = dtt;

			cbCliente.SelectedIndex = -1;


			this.WindowState = FormWindowState.Maximized;

			listagrid();

		}

        private void button1_Click(object sender, EventArgs e)
        {
			adcLivros frm = new adcLivros();
			frm.Show();
			
        }




		public void listagrid()
		{
			String strSQL = "select lv.id_livro";
			strSQL = strSQL + " ,lv.nm_livro";
			strSQL = strSQL + " ,gl.nm_genero";
			strSQL = strSQL + " from livro lv";
			strSQL = strSQL + " left join genero_livro gl";
			strSQL = strSQL + " on gl.id_genero = lv.id_genero";
			strSQL = strSQL + " order by lv.nm_livro, gl.nm_genero asc;";


			conexao = new MySqlConnection(conn);
			objCommand = new MySqlCommand(strSQL, conexao);

			try
			{
				MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
				DataTable dtlista = new DataTable();

				objAdp.Fill(dtlista);

				dgLivros.DataSource = dtlista;


				var col = new DataGridViewCheckBoxColumn();
				col.Name = "Coluna";
				col.HeaderText = "Select";
				col.FalseValue = false;
				col.TrueValue = true;
				//Make the default checked
				col.CellTemplate.Value = false;
				//col.CellTemplate.Style.NullValue = false;
				dgLivros.Columns.Insert(0, col);


				dgLivros.RowHeadersVisible = false;
				dgLivros.MultiSelect = false;
				dgLivros.Columns["id_livro"].Visible = false;

				dgLivros.Columns["Coluna"].SortMode = DataGridViewColumnSortMode.NotSortable;

				dgLivros.Columns["nm_livro"].ReadOnly = true;
				dgLivros.Columns["nm_livro"].SortMode = DataGridViewColumnSortMode.NotSortable;

				dgLivros.Columns["nm_genero"].ReadOnly = true;
				dgLivros.Columns["nm_genero"].SortMode = DataGridViewColumnSortMode.NotSortable;

			}
			catch
			{
				MessageBox.Show("Deu erro");
			}
		}

        private void button3_Click(object sender, EventArgs e)
        {

			foreach (DataGridViewRow linha in dgLivros.Rows)
			{

				if (linha.Cells[0].Value == null)
                {
					int nada = 0; 
                }
				else
				{
					MessageBox.Show(linha.Cells[1].Value.ToString() + " -- " + linha.Cells[2].Value.ToString());

				}
			}

			foreach (DataGridViewRow linha in dgLivros.Rows)
			{
				linha.Cells[0].Value = null;
			}

		}
    }
}
