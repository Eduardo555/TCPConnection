using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEduardo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Cliente cliente = new Cliente();

		private void button1_Click(object sender, EventArgs e)
		{
			cliente.EnviarMensagem(DateTime.Now + " :: " + txtMensagem.Text, txtIp.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			cliente.ConectarServidor(txtIp.Text);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
