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
		public Transacao()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

        private void Transacao_Load(object sender, EventArgs e)
        {
			String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
			MySqlConnection conexao = new MySqlConnection(conn);


			conexao.Open();
			MySqlCommand comando = new MySqlCommand();
			comando = conexao.CreateCommand();

			comando.CommandText = "select * from tipo_transacao ";
			
			MySqlDataReader dr = comando.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(dr);
			cbtransacao.DisplayMember = "nm_tipo_transacao";
			cbtransacao.DataSource = dt;

			cbtransacao.SelectedIndex = -1;


			comando.CommandText = "select * from cliente";
			MySqlDataReader drr = comando.ExecuteReader();
			DataTable dtt = new DataTable();
			dtt.Load(drr);
			cbCliente.DisplayMember = "nm_cliente";
			cbCliente.DataSource = dtt;

			cbCliente.SelectedIndex = -1;


			this.WindowState = FormWindowState.Maximized;


		}

        private void button1_Click(object sender, EventArgs e)
        {
			adcLivros frm = new adcLivros();
			frm.Show();
			
        }
    }
}
