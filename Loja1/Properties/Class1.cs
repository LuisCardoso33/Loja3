using System;                      // Importa funcionalidades básicas, como manipulação de exceções e operações de console.
using System.Data.SqlClient;       // Importa classes para trabalhar com SQL Server, como conexões e comandos SQL.
using System.Configuration;        // Permite acessar configurações, como a connection string no arquivo de configuração.
using System.Windows.Forms;        // Fornece classes para criar interfaces gráficas (caso precise exibir mensagens).

namespace Loja1                    // Define um espaço de nomes (namespace) chamado Loja1 para organizar o código.
{
	internal class BancoDeDados    // Declara uma classe chamada BancoDeDados. É "internal" para que só seja acessível dentro do mesmo assembly.
	{
		private SqlConnection connection; // Declara um campo `connection` do tipo SqlConnection, que representa a conexão com o banco de dados.

		// Construtor que inicializa a conexão com o banco de dados usando uma connection string
		public BancoDeDados()       // Método especial que é chamado ao criar uma instância da classe BancoDeDados.
		{
			// Define a connection string para conectar ao SQL Server.
			string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=SeuBanco;Integrated Security=True;";

			// Inicializa o objeto `connection` com a connection string, configurando a conexão.
			connection = new SqlConnection(connectionString);
		}

		// Método para abrir a conexão com o banco de dados
		public void AbrirConexao()   // Define um método chamado AbrirConexao para abrir a conexão com o banco.
		{
			try                     // Inicia um bloco try-catch para capturar erros.
			{
				connection.Open();   // Tenta abrir a conexão com o banco.
				Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso."); // Exibe mensagem de sucesso no console.
			}
			catch (Exception ex)     // Bloco executado se ocorrer um erro ao abrir a conexão.
			{
				// Exibe mensagem de erro, mostrando detalhes do problema (ex.Message).
				Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
			}
		}

		// Método para fechar a conexão com o banco de dados
		public void FecharConexao()  // Define um método chamado FecharConexao para fechar a conexão.
		{
			connection.Close();      // Fecha a conexão com o banco.
			Console.WriteLine("Conexão com o banco de dados foi fechada."); // Exibe mensagem no console.
		}

		// Método para inserir um produto no banco de dados (Create)
		public void InserirProduto(string nome, decimal preco, string categoria) // Define o método InserirProduto para adicionar dados.
		{
			// Define a consulta SQL para inserir um novo registro na tabela produtos.
			string query = "INSERT INTO produtos (nome, preco, categoria) VALUES (@nome, @preco, @categoria)";

			// Cria um objeto SqlCommand, associando a consulta SQL e a conexão com o banco.
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				// Adiciona os parâmetros ao comando SQL para proteger contra injeção de SQL.
				command.Parameters.AddWithValue("@nome", nome);       // Define o parâmetro `@nome` com o valor `nome`.
				command.Parameters.AddWithValue("@preco", preco);     // Define o parâmetro `@preco` com o valor `preco`.
				command.Parameters.AddWithValue("@categoria", categoria); // Define o parâmetro `@categoria` com o valor `categoria`.

				try
				{
					AbrirConexao();              // Chama o método para abrir a conexão com o banco.
					command.ExecuteNonQuery();   // Executa o comando de inserção, sem retorno de dados.
					Console.WriteLine("Produto inserido com sucesso."); // Exibe mensagem de sucesso.
				}
				catch (Exception ex)             // Bloco executado em caso de erro ao inserir o produto.
				{
					Console.WriteLine("Erro ao inserir produto: " + ex.Message); // Exibe mensagem de erro.
				}
				finally
				{
					FecharConexao();             // Garante que a conexão será fechada, mesmo se ocorrer um erro.
				}
			}
		}

		// Método para listar todos os produtos no banco de dados (Read)
		public void ListarProdutos() // Define o método ListarProdutos para buscar e exibir todos os produtos.
		{
			// Define a consulta SQL para buscar todos os registros da tabela produtos.
			string query = "SELECT * FROM produtos";

			// Cria um objeto SqlCommand para executar a consulta SQL com a conexão aberta.
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				try
				{
					AbrirConexao();  // Abre a conexão com o banco.

					// Executa o comando e obtém os resultados usando um SqlDataReader.
					using (SqlDataReader reader = command.ExecuteReader())
					{
						// Enquanto houver linhas (registros) para ler, o loop continuará.
						while (reader.Read())
						{
							// Exibe cada produto no console, usando as colunas ProdutoID, nome, preco e categoria.
							Console.WriteLine($"ID: {reader["ProdutoID"]}, Nome: {reader["nome"]}, Preço: {reader["preco"]}, Categoria: {reader["categoria"]}");
						}
					}
				}
				catch (Exception ex) // Bloco executado se houver erro na leitura dos produtos.
				{
					Console.WriteLine("Erro ao listar produtos: " + ex.Message); // Exibe mensagem de erro.
				}
				finally
				{
					FecharConexao(); // Fecha a conexão após terminar ou em caso de erro.
				}
			}
		}

		// Método para atualizar um produto no banco de dados (Update)
		public void AtualizarProduto(int produtoID, string nome, decimal preco, string categoria) // Define o método AtualizarProduto.
		{
			// Define a consulta SQL para atualizar os dados de um produto específico.
			string query = "UPDATE produtos SET nome = @nome, preco = @preco, categoria = @categoria WHERE ProdutoID = @produtoID";

			// Cria um SqlCommand para executar a consulta de atualização.
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				// Associa valores aos parâmetros para evitar injeção de SQL.
				command.Parameters.AddWithValue("@produtoID", produtoID); // Define o ID do produto a ser atualizado.
				command.Parameters.AddWithValue("@nome", nome);           // Define o novo nome do produto.
				command.Parameters.AddWithValue("@preco", preco);         // Define o novo preço.
				command.Parameters.AddWithValue("@categoria", categoria); // Define a nova categoria.

				try
				{
					AbrirConexao();              // Abre a conexão.
					command.ExecuteNonQuery();   // Executa a consulta de atualização.
					Console.WriteLine("Produto atualizado com sucesso."); // Exibe mensagem de sucesso.
				}
				catch (Exception ex)             // Bloco executado se houver erro.
				{
					Console.WriteLine("Erro ao atualizar produto: " + ex.Message); // Exibe mensagem de erro.
				}
				finally
				{
					FecharConexao();             // Garante que a conexão será fechada.
				}
			}
		}

		// Método para excluir um produto do banco de dados (Delete)
		public void ExcluirProduto(int produtoID) // Define o método ExcluirProduto para deletar um produto.
		{
			// Define a consulta SQL para excluir um produto específico com base no ProdutoID.
			string query = "DELETE FROM produtos WHERE ProdutoID = @produtoID";

			// Cria um SqlCommand para executar a consulta de exclusão.
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@produtoID", produtoID); // Define o ID do produto a ser excluído.

				try
				{
					AbrirConexao();              // Abre a conexão com o banco.
					command.ExecuteNonQuery();   // Executa o comando de exclusão.
					Console.WriteLine("Produto excluído com sucesso."); // Exibe mensagem de sucesso.
				}
				catch (Exception ex)             // Bloco executado em caso de erro.
				{
					Console.WriteLine("Erro ao excluir produto: " + ex.Message); // Exibe mensagem de erro.
				}
				finally
				{
					FecharConexao();             // Garante que a conexão seja fechada.
				}
			}
		}
	}
}


