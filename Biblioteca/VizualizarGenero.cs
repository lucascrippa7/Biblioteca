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
    public partial class VizualizarGenero : Form
    {

        String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

        //MySqlConnection conexao = new MySqlConnection(conn);


        MySqlCommand objCommand = null;
        MySqlConnection conexao = null;



        public VizualizarGenero()
        {
            InitializeComponent();
        }

        private void VizualizarGenero_Load(object sender, EventArgs e)
        {
            listagrid();
            this.WindowState = FormWindowState.Maximized;
        }

        public void listagrid()
        {
            String strSQL = "Select * from genero_livro";

            conexao = new MySqlConnection(conn);
            objCommand = new MySqlCommand(strSQL, conexao);

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtlista = new DataTable();

                objAdp.Fill(dtlista);

                dgVizuGenero.DataSource = dtlista;

            }
            catch
            {
                MessageBox.Show("Deu erro");
            }


        }

    }
}
