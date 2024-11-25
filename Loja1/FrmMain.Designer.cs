namespace Loja1
{
    partial class frmMENU
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMENU));
			this.lblProduto = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblVendas = new System.Windows.Forms.Label();
			this.lblVendastotais = new System.Windows.Forms.Label();
			this.pbxVendasTotais = new System.Windows.Forms.PictureBox();
			this.pbxVendas = new System.Windows.Forms.PictureBox();
			this.pbxCadastroCLT = new System.Windows.Forms.PictureBox();
			this.pbxCadastroPDT = new System.Windows.Forms.PictureBox();
			this.btnFechar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbxVendasTotais)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCadastroCLT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCadastroPDT)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProduto
			// 
			this.lblProduto.AutoSize = true;
			this.lblProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProduto.Location = new System.Drawing.Point(12, 113);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(151, 17);
			this.lblProduto.TabIndex = 4;
			this.lblProduto.Text = "CADASTRAR PRODUTO";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCliente.Location = new System.Drawing.Point(471, 113);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(139, 17);
			this.lblCliente.TabIndex = 5;
			this.lblCliente.Text = "CADASTRAR CLIENTE";
			// 
			// lblVendas
			// 
			this.lblVendas.AutoSize = true;
			this.lblVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblVendas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVendas.Location = new System.Drawing.Point(40, 401);
			this.lblVendas.Name = "lblVendas";
			this.lblVendas.Size = new System.Drawing.Size(60, 17);
			this.lblVendas.TabIndex = 6;
			this.lblVendas.Text = "VENDAS";
			// 
			// lblVendastotais
			// 
			this.lblVendastotais.AutoSize = true;
			this.lblVendastotais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblVendastotais.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVendastotais.Location = new System.Drawing.Point(496, 401);
			this.lblVendastotais.Name = "lblVendastotais";
			this.lblVendastotais.Size = new System.Drawing.Size(114, 17);
			this.lblVendastotais.TabIndex = 7;
			this.lblVendastotais.Text = "VENDAS DO MES";
			// 
			// pbxVendasTotais
			// 
			this.pbxVendasTotais.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbxVendasTotais.Image = global::Loja1.Properties.Resources.calendario;
			this.pbxVendasTotais.Location = new System.Drawing.Point(499, 281);
			this.pbxVendasTotais.Name = "pbxVendasTotais";
			this.pbxVendasTotais.Size = new System.Drawing.Size(98, 105);
			this.pbxVendasTotais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxVendasTotais.TabIndex = 3;
			this.pbxVendasTotais.TabStop = false;
			// 
			// pbxVendas
			// 
			this.pbxVendas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pbxVendas.Image = global::Loja1.Properties.Resources.documentacao;
			this.pbxVendas.Location = new System.Drawing.Point(30, 281);
			this.pbxVendas.Name = "pbxVendas";
			this.pbxVendas.Size = new System.Drawing.Size(88, 105);
			this.pbxVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxVendas.TabIndex = 2;
			this.pbxVendas.TabStop = false;
			// 
			// pbxCadastroCLT
			// 
			this.pbxCadastroCLT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbxCadastroCLT.Image = global::Loja1.Properties.Resources.cliente;
			this.pbxCadastroCLT.Location = new System.Drawing.Point(493, 12);
			this.pbxCadastroCLT.Name = "pbxCadastroCLT";
			this.pbxCadastroCLT.Size = new System.Drawing.Size(98, 89);
			this.pbxCadastroCLT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxCadastroCLT.TabIndex = 1;
			this.pbxCadastroCLT.TabStop = false;
			// 
			// pbxCadastroPDT
			// 
			this.pbxCadastroPDT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbxCadastroPDT.Image = global::Loja1.Properties.Resources.controle;
			this.pbxCadastroPDT.Location = new System.Drawing.Point(30, 12);
			this.pbxCadastroPDT.Name = "pbxCadastroPDT";
			this.pbxCadastroPDT.Size = new System.Drawing.Size(101, 89);
			this.pbxCadastroPDT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxCadastroPDT.TabIndex = 0;
			this.pbxCadastroPDT.TabStop = false;
			this.pbxCadastroPDT.Click += new System.EventHandler(this.pbxCadastroPDT_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.Red;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Location = new System.Drawing.Point(265, 381);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(75, 58);
			this.btnFechar.TabIndex = 8;
			this.btnFechar.Text = "FECHAR";
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// frmMENU
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(622, 450);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.lblVendastotais);
			this.Controls.Add(this.lblVendas);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.lblProduto);
			this.Controls.Add(this.pbxVendasTotais);
			this.Controls.Add(this.pbxVendas);
			this.Controls.Add(this.pbxCadastroCLT);
			this.Controls.Add(this.pbxCadastroPDT);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMENU";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MENU";
			this.Load += new System.EventHandler(this.frmMENU_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbxVendasTotais)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxVendas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCadastroCLT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCadastroPDT)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCadastroPDT;
        private System.Windows.Forms.PictureBox pbxCadastroCLT;
        private System.Windows.Forms.PictureBox pbxVendas;
        private System.Windows.Forms.PictureBox pbxVendasTotais;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label lblVendastotais;
		private System.Windows.Forms.Button btnFechar;
	}
}

