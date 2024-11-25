using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja1
{
    public partial class frmMENU : Form
    {
		SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\luuis\\Downloads\\Vendas\\Vendas\\DbVenda.mdf;Integrated Security=True");
        public frmMENU()
        {
            InitializeComponent();
        }

		private void frmMENU_Load(object sender, EventArgs e)
		{

		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void pbxCadastroPDT_Click(object sender, EventArgs e)
		{
			Cadastroproduto cadastroproduto = new Cadastroproduto();
				cadastroproduto.Show();
		}
	}
}
