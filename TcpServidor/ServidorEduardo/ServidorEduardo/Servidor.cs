﻿using System;
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
			
		}


		
		private NetworkStream socketScreen;
		private BinaryWriter escrita;
		private BinaryReader leitura;

		public string EstabeleceConexao()
		{
			// Estabelece a conexao com o cliente.
			// Realizando o aceite de conexao.
			Socket conexao = servidor.AcceptSocket();

			// Cria Local em memoria para escrever as mensagens.
			socketScreen = new NetworkStream(conexao);

			byte[] buffer = new byte[conexao.ReceiveBufferSize];
			int data = socketScreen.Read(buffer, 0, conexao.ReceiveBufferSize);
			string ch = Encoding.Unicode.GetString(buffer, 0, data);
			return ch;
		}

		public void IniciarServidor()
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
		public void FecharConexao()
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
