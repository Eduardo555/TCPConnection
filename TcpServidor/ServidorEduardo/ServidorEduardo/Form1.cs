using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorEduardo
{
	public partial class Form1 : Form
	{

		Servidor server = new Servidor();
		

		public Form1()
		{
			InitializeComponent();
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			server.IniciarServidor();
			txtDesligado.Visible = false;
			txtDesligado.Refresh();
			txtLigado.Visible = true;
			txtLigado.Refresh();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			server.FecharConexao();
			txtDesligado.Visible = true;
			txtDesligado.Refresh();
			txtLigado.Visible = false;
			txtLigado.Refresh();
		}

		private void ferramnetasToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			string resposta = server.EstabeleceConexao();
			txtMensagens.Text = resposta + "\n" + txtMensagens.Text;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string NomeMaquina = Dns.GetHostName();
			IPAddress[] ip = Dns.GetHostAddresses(NomeMaquina);
			txtNumroIp.Text = ip[1].ToString();
		}
	}
}
