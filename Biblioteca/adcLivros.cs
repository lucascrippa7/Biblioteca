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
    public partial class adcLivros : Form
    {
        public adcLivros()
        {
            InitializeComponent();
        }

        private void adcLivros_Load(object sender, EventArgs e)
        {

            String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);


            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando = conexao.CreateCommand();

            comando.CommandText = "select * from livro ";
            MySqlDataReader drrr = comando.ExecuteReader();
            DataTable dttt = new DataTable();
            dttt.Load(drrr);

            this.WindowState = FormWindowState.Maximized;

        }
    }
}
