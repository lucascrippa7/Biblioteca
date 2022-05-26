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


        int id_genero = 0;
        int index_selct = 0;
        String nm_genero = null;

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
            dgVizuGenero.AllowUserToAddRows = false;

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

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           
            String strSQL = "update genero_livro  set nm_genero ='" + dgVizuGenero.CurrentRow.Cells[1].Value.ToString() + "' where id_genero = " + id_genero;

           

            try
            {


                conexao = new MySqlConnection(conn);
                objCommand = new MySqlCommand(strSQL, conexao);
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtlista = new DataTable();

                objAdp.Fill(dtlista);

                nm_genero = null;

                listagrid();

            }
            catch
            {
                MessageBox.Show("Deu erro");
            }
        }

        private void dgVizuGenero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nm_genero != null)
            {
                dgVizuGenero.Rows[index_selct].Cells[1].Value = nm_genero;
            }            
            id_genero = Convert.ToInt32 (dgVizuGenero.CurrentRow.Cells[0].Value.ToString());
            nm_genero = dgVizuGenero.CurrentRow.Cells[1].Value.ToString();
            index_selct = dgVizuGenero.CurrentRow.Cells[1].RowIndex;


        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            String strSQL = "delete from genero_livro where id_genero = " + id_genero;

            conexao = new MySqlConnection(conn);
            objCommand = new MySqlCommand(strSQL, conexao);

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtlista = new DataTable();

                objAdp.Fill(dtlista);

                listagrid();

            }
            catch
            {
                MessageBox.Show("Deu erro");
            }
        }
    }
}
