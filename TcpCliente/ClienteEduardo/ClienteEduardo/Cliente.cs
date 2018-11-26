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
			//ConectarServidor();
			//EnviarMensagem();
			//FecharConexao();
		}

		public int Porta { get; set; } = 2000;

		// Criar o Cliente.
		TcpClient cliente = new TcpClient();
		private NetworkStream saida;
		private BinaryWriter escreve;
		private BinaryReader ler;
		private string Mensagem = "Eureca Funciona!";

		// Cria conexao com o cliente.
		public void ConectarServidor(string ip)
		{
			
		}

		// Envia Mensagem para o servidor.
		public void EnviarMensagem(string mensagem, string ip)
		{
			try
			{
				// Cria Conexao
				cliente = new TcpClient();
				cliente.Connect(ip, Porta);

				// Pega mensagem e envia.
				saida = cliente.GetStream();
				escreve = new BinaryWriter(saida);
				byte[] message = Encoding.Unicode.GetBytes(mensagem);
				saida.Write(message, 0, message.Length);

				// Encera conexao.
				FecharConexao();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		// Fecha conexao com o servidor.
		public void FecharConexao()
		{
			cliente.Close();
		}
	}
}
