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
    public partial class VizualizarCliente : Form
    {

        String conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();

        //MySqlConnection conexao = new MySqlConnection(conn);


        MySqlCommand objCommand = null;
        MySqlConnection conexao = null;



        public VizualizarCliente()
        {
            InitializeComponent();
        }

        private void VizualizarCliente_Load(object sender, EventArgs e)
        {
            listagrid();
            this.WindowState = FormWindowState.Maximized;
        }

        public void listagrid()
        {
            dgDadosCliente.DataSource = null;
            dgDadosCliente.Rows.Clear();
            dgDadosCliente.Columns.Clear();
            dgDadosCliente.AllowUserToAddRows = false;

            String strSQL = "Select * from cliente";

            conexao = new MySqlConnection(conn);
            objCommand = new MySqlCommand(strSQL, conexao);

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtlista = new DataTable();

                objAdp.Fill(dtlista);

                dgDadosCliente.DataSource = dtlista;

                dgDadosCliente.RowHeadersVisible = false;
                dgDadosCliente.MultiSelect = false;

            }
            catch
            {
                MessageBox.Show("Deu erro");
            }


        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja excluir o cliente '" + dgDadosCliente.CurrentRow.Cells[1].Value + "' ?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
            if (dialogResult == DialogResult.Yes)
            {
                String strSQL = "delete from cliente where id_cliente =" + dgDadosCliente.CurrentRow.Cells[0].Value + ";";

                conexao = new MySqlConnection(conn);
                objCommand = new MySqlCommand(strSQL, conexao);

                try
                {
                    MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                    DataTable dtlista = new DataTable();

                    objAdp.Fill(dtlista);                   

                }
                catch(MySqlException msqle)
			{
                    MessageBox.Show("Erro de acesso ao MySQL: " + msqle.Message, "erro");
                }
                finally
                {
                    listagrid();
                }

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja alterar o cliente '" + dgDadosCliente.CurrentRow.Cells[1].Value + "' ?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string nome, cpf, datanascI, endereco, compl, bairro, cidade, estado, pais, celular,cep;
                int nr_endereco;
                DateTime datanasc;

                nome = dgDadosCliente.CurrentRow.Cells[1].Value.ToString();
                cpf = dgDadosCliente.CurrentRow.Cells[2].Value.ToString();
                datanascI = dgDadosCliente.CurrentRow.Cells[3].Value.ToString();
                datanasc = Convert.ToDateTime(datanascI);
                endereco = dgDadosCliente.CurrentRow.Cells[4].Value.ToString();
                nr_endereco = Convert.ToInt32(dgDadosCliente.CurrentRow.Cells[5].Value.ToString());
                compl = dgDadosCliente.CurrentRow.Cells[6].Value.ToString();
                bairro = dgDadosCliente.CurrentRow.Cells[7].Value.ToString();
                cidade = dgDadosCliente.CurrentRow.Cells[8].Value.ToString();
                estado = dgDadosCliente.CurrentRow.Cells[9].Value.ToString();
                pais = dgDadosCliente.CurrentRow.Cells[10].Value.ToString();                
                cep = dgDadosCliente.CurrentRow.Cells[11].Value.ToString();
                celular = dgDadosCliente.CurrentRow.Cells[12].Value.ToString();

                String strSQL = "delete from cliente where id_cliente =" + dgDadosCliente.CurrentRow.Cells[1].Value + ";";


                strSQL = "UPDATE cliente";
                strSQL = strSQL + " SET";
                strSQL = strSQL + " nm_cliente ='" + nome + "'";
                strSQL = strSQL + " ,nr_cpf ='" + cpf + "'";
                strSQL = strSQL + " ,dt_nascimento ='" + datanasc.Year + "/" + datanasc.Month + "/" + datanasc.Day + "'"; 
                strSQL = strSQL + " ,nm_endereco ='" + endereco + "'";
                strSQL = strSQL + " ,nr_endereco =" + Convert.ToInt64(nr_endereco);
                strSQL = strSQL + " ,nm_complemento ='" + compl + "'";
                strSQL = strSQL + " ,nm_bairro ='" + bairro + "'";
                strSQL = strSQL + " ,nm_cidade ='" + cidade + "'";
                strSQL = strSQL + " ,nm_estado ='" + estado + "'";
                strSQL = strSQL + " ,nm_pais ='" + pais + "'";
                strSQL = strSQL + " ,nr_cep ='" + cep + "'";
                strSQL = strSQL + " ,celular ='" + celular + "'";
                strSQL = strSQL + "  WHERE id_cliente =" + dgDadosCliente.CurrentRow.Cells[0].Value;


                conexao = new MySqlConnection(conn);
                objCommand = new MySqlCommand(strSQL, conexao);

                try
                {
                    MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                    DataTable dtlista = new DataTable();

                    objAdp.Fill(dtlista);

                }
                catch(MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao MySQL: " + msqle.Message, "erro");
                }
                finally
                {
                    listagrid();
                }





            }
        }
    }
}
