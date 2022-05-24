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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);


            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando = conexao.CreateCommand();

            comando.CommandText = "select nome from usuario ";

            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbUsuarios.ValueMember = "nome";
            cbUsuarios.DisplayMember = "nome";
            cbUsuarios.DataSource = dt;

            cbUsuarios.SelectedIndex = -1;
        }

        private void CarregarUsuario()
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text == "teste")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorreto");
            }
        }
    }
}
