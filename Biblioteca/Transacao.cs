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
		int id_tipo_trans = 0;
		int id_cli = 0;

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
			if (id_tipo_trans == 0 || id_cli == 0)
            {
				return;
            }

			dgLivros.DataSource = null;
			dgLivros.Rows.Clear();
			dgLivros.Columns.Clear();

			String strSQL = "select distinct lv.id_livro";
			strSQL = strSQL + " ,lv.nm_livro";
			strSQL = strSQL + " ,gl.nm_genero";
			strSQL = strSQL + " from livro lv";
			strSQL = strSQL + " left join genero_livro gl";
			strSQL = strSQL + " on gl.id_genero = lv.id_genero";
			strSQL = strSQL + " where 1 = 1";
			if (id_tipo_trans == 2) { strSQL = strSQL + " and lv.id_livro not in (select id_livro from transacao where id_tipo_transacao = 2)"; }
			if (id_tipo_trans == 3) { strSQL = strSQL + " and lv.id_livro in (select id_livro from transacao where id_tipo_transacao = 2 and id_cliente =" + cbCliente.SelectedValue + ")"; }

			strSQL = strSQL + " order by lv.nm_livro, gl.nm_genero asc;";


			conexao = new MySqlConnection(conn);
			objCommand = new MySqlCommand(strSQL, conexao);

			try
			{
				MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
				DataTable dtlista = new DataTable();

				objAdp.Fill(dtlista);

				dgLivros.DataSource = dtlista;

				dgLivros.AllowUserToAddRows = false; // RETIRAR LINHA EMBRANCO NO DATAGRID

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
			String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
			MySqlConnection conexao = new MySqlConnection(conn);


			conexao.Open();
			MySqlCommand comando = new MySqlCommand();
			comando = conexao.CreateCommand();

			String strSQL = "";
			foreach (DataGridViewRow linha in dgLivros.Rows)
			{
				if (linha.Cells[0].Value == null)
                {
					int nada = 0; 
                }
				else
				{
					strSQL = "INSERT INTO `projetobiblioteca`.`transacao`";
					strSQL = strSQL + " (`id_tipo_transacao`,";
					strSQL = strSQL + " `dt_transacao`,";
					strSQL = strSQL + " `id_cliente`,";
					strSQL = strSQL + " `id_livro`)";
					strSQL = strSQL + " VALUES";
					strSQL = strSQL + " (" + cbtransacao.SelectedValue + ",";
					strSQL = strSQL + "'" + DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day + "',";
					strSQL = strSQL + cbCliente.SelectedValue + ",";
					strSQL = strSQL + linha.Cells[1].Value + ");";
					conexao = new MySqlConnection(conn);
					objCommand = new MySqlCommand(strSQL, conexao);

					if (linha.Cells[0].Value != null)
                    {							
						MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
						DataTable dtlista = new DataTable();
						objAdp.Fill(dtlista);
					}
				}

			}
			foreach (DataGridViewRow linha in dgLivros.Rows)
			{
				linha.Cells[0].Value = null;
			}			
			listagrid();
		}

        private void txtPesquisaLivro_TextChanged(object sender, EventArgs e)
        {
			dgLivros.ClearSelection();
			foreach (DataGridViewRow linha in dgLivros.Rows)
			{
				if (linha.Cells[2].Value == null)
				{
					int nada = 0;
				}
                else
                {
					if (String.Equals(linha.Cells[2].Value.ToString().ToLower(),txtPesquisaLivro.Text.ToLower()))
					{						
						linha.Selected = true;
					}
				}				
			}
		}

        private void cbtransacao_SelectedValueChanged(object sender, EventArgs e)
        {
			id_tipo_trans = Convert.ToInt16(cbtransacao.SelectedValue);
			listagrid();

		}

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
			id_cli = Convert.ToInt16(cbCliente.SelectedValue);
			listagrid();
		}
    }
}
