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
    public partial class VizualizarTransacao : Form
    {

        String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

        //MySqlConnection conexao = new MySqlConnection(conn);


        MySqlCommand objCommand = null;
        MySqlConnection conexao = null;


        public VizualizarTransacao()
        {
            InitializeComponent();
        }

        private void VizualizarTransacao_Load(object sender, EventArgs e)
        {
            listagrid();
            this.WindowState = FormWindowState.Maximized;
        }

        public void listagrid()
        {
            String strSQL = "Select liv.nm_livro, tt.nm_tipo_transacao, lt.dt_transacao, cli.nm_cliente from log_transacao lt";
            strSQL = strSQL + " inner join tipo_transacao tt";
            strSQL = strSQL + " on tt.id_tipo_transacao = lt.id_tipo_transacao";
            strSQL = strSQL + " inner join cliente cli";
            strSQL = strSQL + " on cli.id_cliente = lt.id_cliente";
            strSQL = strSQL + " inner join livro liv";
            strSQL = strSQL + " on liv.id_livro = lt.id_livro";
            strSQL = strSQL + " order by lt.id_transacao;";

            dgVizuaTransacao.AllowUserToAddRows = false;
           

            conexao = new MySqlConnection(conn);
            objCommand = new MySqlCommand(strSQL, conexao);

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtlista = new DataTable();

                objAdp.Fill(dtlista);

                dgVizuaTransacao.DataSource = dtlista;

                dgVizuaTransacao.RowHeadersVisible = false;
                dgVizuaTransacao.MultiSelect = false;

                dgVizuaTransacao.Columns["nm_livro"].Width = 455;
                dgVizuaTransacao.Columns["nm_livro"].ReadOnly = true;
                dgVizuaTransacao.Columns["nm_livro"].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgVizuaTransacao.Columns["nm_tipo_transacao"].ReadOnly = true;
                dgVizuaTransacao.Columns["nm_tipo_transacao"].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgVizuaTransacao.Columns["dt_transacao"].ReadOnly = true;
                dgVizuaTransacao.Columns["dt_transacao"].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgVizuaTransacao.Columns["nm_cliente"].ReadOnly = true;
                dgVizuaTransacao.Columns["nm_cliente"].SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            catch
            {
                MessageBox.Show("Deu erro");
            }


        }
    }
}
