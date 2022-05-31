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
			strSQL = strSQL + " lv.id_livro";
			strSQL = strSQL  + " ,gl.nm_genero";
			strSQL = strSQL  + " ,lv.nm_livro";
			strSQL = strSQL  + " ,lv.nm_autor";
			strSQL = strSQL  + " ,lv.nm_editora";
			strSQL = strSQL  + " ,lv.nr_ano_edicao";
			strSQL = strSQL  + " from livro lv";
			strSQL = strSQL  + " left join genero_livro gl";
			strSQL = strSQL  + " on gl.id_genero = lv.id_genero";
			strSQL = strSQL  + " order by lv.nm_livro, gl.nm_genero;";

			dgDados.AllowUserToAddRows = false;

			conexao = new MySqlConnection(conn);
			objCommand = new MySqlCommand(strSQL, conexao);

			try
			{
				MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
				DataTable dtlista = new DataTable();

				objAdp.Fill(dtlista);

				dgDados.DataSource = dtlista;

				dgDados.RowHeadersVisible = false;
				dgDados.MultiSelect = false;

				dgDados.Columns["id_livro"].SortMode = DataGridViewColumnSortMode.NotSortable;

				dgDados.Columns["nm_livro"].Width = 400;
				dgDados.Columns["nm_livro"].ReadOnly = true;
				

				dgDados.Columns["nm_autor"].Width = 180;
				dgDados.Columns["nm_autor"].ReadOnly = true;

				dgDados.Columns["nm_editora"].Width = 100;
				dgDados.Columns["nm_editora"].ReadOnly = true;


			}
			catch
			{
				MessageBox.Show("Deu erro");
			}


		}

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
			DialogResult dialogResult = MessageBox.Show("Deseja alterar o cliente '" + dgDados.CurrentRow.Cells[2].Value + "' ?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
            {

            }




		}
    }
}
