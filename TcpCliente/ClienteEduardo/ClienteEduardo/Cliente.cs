using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEduardo
{
	class Cliente
	{

		public Cliente()
		{
			ConectarServidor();
			EnviarMensagem();
			FecharConexao();
		}

		public int Porta { get; set; } = 2000;
		public string EndIpServer { get; set; } = "192.168.0.24";

		// Criar o Cliente.
		TcpClient cliente = new TcpClient();
		private NetworkStream saida;
		private BinaryWriter escreve;
		private BinaryReader ler;
		private string Mensagem = "Eureca Funciona!";

		// Cria conexao com o cliente.
		private void ConectarServidor()
		{

			cliente.Connect(EndIpServer, Porta);
		}

		// Envia Mensagem para o servidor.
		private void EnviarMensagem()
		{

			Byte[] sendBytes = Encoding.UTF8.GetBytes("Is anybody there?");
			saida = cliente.GetStream();
			escreve = new BinaryWriter(saida);
			ler = new BinaryReader(saida);
			//MessageBox.Show(ler.ToString());
			saida.Write(sendBytes, 0, sendBytes.Length);
		}

		// Fecha conexao com o servidor.
		private void FecharConexao()
		{
			cliente.Close();
		}
	}
}
