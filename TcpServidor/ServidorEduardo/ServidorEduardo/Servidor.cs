using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorEduardo
{
	class Servidor
	{

		// Criar a espera pela conexao.
		// Espera na porta 2000.
		TcpListener servidor = new TcpListener(2000);

		public Servidor()
		{
			// Construtuor, inicia o sistema de comunicacao.
			IniciarServidor();
			EstabeleceConexao();
			FecharConexao();
		}


		
		private NetworkStream socketScreen;
		private BinaryWriter escrita;
		private BinaryReader leitura;

		private void EstabeleceConexao()
		{
			// Estabelece a conexao com o cliente.
			// Realizando o aceite de conexao.
			Socket conexao = servidor.AcceptSocket();

			// Cria Local em memoria para escrever as mensagens.
			socketScreen = new NetworkStream(conexao);

			// Esreve a mensagem.
			escrita = new BinaryWriter(socketScreen);
			leitura = new BinaryReader(socketScreen);
			MessageBox.Show("Escrita: " + escrita.ToString() + " Leitura:" + leitura.ToString());
		}

		private void IniciarServidor()
		{
			// Inicia o servidor.
			try
			{
				servidor.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro:" + ex.Message.ToString());
			}

		}
		private void FecharConexao()
		{
			// Encera a conexao.
			try
			{
				servidor.Stop();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro:" + ex.Message.ToString());
			}
		}
	}
}
