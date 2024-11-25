using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Loja1.Models;
using System.Windows.Forms;
using System.Drawing;

namespace Loja1.Controller
{
    public class Produto
    {
 
        public int Id { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }

        public List<Produto> Listaproduto()
        {
            List<Produto> produtos = new List<Produto>();
            string Sql = "SELECT * FROM Produto";

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\luuis\\Downloads\\Vendas\\Vendas\\DbVenda.mdf;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(Sql, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Produto produto = new Produto
                                {
                                    Id = (int)dr["Id"],
                                    nome = dr["nome"].ToString(),
                                    quantidade = (int)dr["quantidade"],
                                    preco = (decimal)dr["preco"]
                                };
                                produtos.Add(produto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return produtos;
        }




    }
}
