namespace ServidorEduardo
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumroIp = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ferramnetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtMensagens = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.txtLigado = new System.Windows.Forms.Label();
			this.txtDesligado = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(140, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 26);
			this.button1.TabIndex = 0;
			this.button1.Text = "Ligar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "IP do servidor";
			// 
			// txtNumroIp
			// 
			this.txtNumroIp.Enabled = false;
			this.txtNumroIp.Location = new System.Drawing.Point(12, 64);
			this.txtNumroIp.Name = "txtNumroIp";
			this.txtNumroIp.Size = new System.Drawing.Size(122, 20);
			this.txtNumroIp.TabIndex = 2;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramnetasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(259, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// ferramnetasToolStripMenuItem
			// 
			this.ferramnetasToolStripMenuItem.Name = "ferramnetasToolStripMenuItem";
			this.ferramnetasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.ferramnetasToolStripMenuItem.Text = "Ferramnetas";
			this.ferramnetasToolStripMenuItem.Click += new System.EventHandler(this.ferramnetasToolStripMenuItem_Click);
			// 
			// txtMensagens
			// 
			this.txtMensagens.Location = new System.Drawing.Point(12, 112);
			this.txtMensagens.Name = "txtMensagens";
			this.txtMensagens.Size = new System.Drawing.Size(235, 190);
			this.txtMensagens.TabIndex = 4;
			this.txtMensagens.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Mensagens Recebidas";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(140, 76);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 26);
			this.button2.TabIndex = 6;
			this.button2.Text = "Desligar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtLigado
			// 
			this.txtLigado.AutoSize = true;
			this.txtLigado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtLigado.Location = new System.Drawing.Point(137, 32);
			this.txtLigado.Name = "txtLigado";
			this.txtLigado.Size = new System.Drawing.Size(39, 13);
			this.txtLigado.TabIndex = 7;
			this.txtLigado.Text = "Ligado";
			// 
			// txtDesligado
			// 
			this.txtDesligado.AutoSize = true;
			this.txtDesligado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtDesligado.Location = new System.Drawing.Point(139, 32);
			this.txtDesligado.Name = "txtDesligado";
			this.txtDesligado.Size = new System.Drawing.Size(54, 13);
			this.txtDesligado.TabIndex = 8;
			this.txtDesligado.Text = "Desligado";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 308);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(136, 26);
			this.button3.TabIndex = 9;
			this.button3.Text = "Verificar Mensagens";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(259, 343);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.txtDesligado);
			this.Controls.Add(this.txtLigado);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMensagens);
			this.Controls.Add(this.txtNumroIp);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "SERVIDOR";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumroIp;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ferramnetasToolStripMenuItem;
		private System.Windows.Forms.RichTextBox txtMensagens;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label txtLigado;
		private System.Windows.Forms.Label txtDesligado;
		private System.Windows.Forms.Button button3;
	}
}

