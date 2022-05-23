using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
	public partial class Menu : MetroFramework.Forms.MetroForm
	{
		public Menu()
		{
			InitializeComponent();

			foreach(Control c in this.Controls)
			{
				if(c is MdiClient)
				{
					c.BackColor = Color.Black;
				}
			}
		}

		private void Menu_Load(object sender, EventArgs e)
		{
			//var frmLogin = new FrmLogin();
			//frmLogin.ShowDialog();
		}

		private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cadLivros novo = new cadLivros();
			novo.MdiParent = this;
			
			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

		

		private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cliente novo = new Cliente();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

		private void gêneroLivroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GeneroLivro novo = new GeneroLivro();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

		private void tipoTransaçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TipoTransacao novo = new TipoTransacao();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

		private void transaçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Transacao novo = new Transacao();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			vizualizarLivros novo = new vizualizarLivros();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			VizualizarCliente novo = new VizualizarCliente();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

        private void gênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
			VizualizarGenero novo = new VizualizarGenero();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

        private void transaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			VizualizarTransacao novo = new VizualizarTransacao();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

			usuario novo = new usuario();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
			VizualizarUsuario novo = new VizualizarUsuario();
			novo.MdiParent = this;

			var fmrcadGenero = Application.OpenForms["GeneroLivro"];
			var fmrcliente = Application.OpenForms["Cliente"];
			var fmrcadlivro = Application.OpenForms["cadLivros"];
			var fmrtransacao = Application.OpenForms["Transacao"];
			var fmrtipotransacao = Application.OpenForms["TipoTransacao"];
			var fmrvizualizarLivros = Application.OpenForms["vizualizarLivros"];
			var fmrVizualizarClientes = Application.OpenForms["VizualizarCliente"];
			var fmrVizualizarGenero = Application.OpenForms["VizualizarGenero"];
			var fmrVizualizarTransacao = Application.OpenForms["VizualizarTransacao"];
			var fmrUsuario = Application.OpenForms["usuario"];
			var fmrVizualizarUsuario = Application.OpenForms["VizualizarUsuario"];

			if ((fmrcadGenero == null) && (fmrcliente == null) && (fmrcadlivro == null) && (fmrtransacao == null) && (fmrtipotransacao == null) && (fmrvizualizarLivros == null) && (fmrVizualizarClientes == null) && (fmrVizualizarGenero == null) && (fmrVizualizarTransacao == null) && (fmrUsuario == null) && (fmrVizualizarUsuario == null))
			{
				novo.Show();
			}
		}
    }
}
