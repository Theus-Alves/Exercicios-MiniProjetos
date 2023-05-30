using System;
using System.Data.SqlClient;

namespace CadastroFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configurar a string de conexão com o banco de dados do Azure
            string connectionString = "Server=tcp:nomedoservidor.database.windows.net,1433;Initial Catalog=nomebancodedados;Persist Security Info=False;User ID=usuario;Password=senha;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            // Realizar a conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    Console.WriteLine("Sistema de Cadastro de Funcionários");
                    Console.WriteLine("----------------------------------");

                    // Obter informações do usuário
                    Console.Write("Digite o nome do funcionário: ");
                    string? nome = Console.ReadLine();

                    Console.Write("Digite o cargo do funcionário: ");
                    string? cargo = Console.ReadLine();

                    Console.Write("Digite o salário do funcionário: ");
                    decimal salario = Convert.ToDecimal(Console.ReadLine());

                    // Inserir os dados na tabela de funcionários
                    string insertQuery = $"INSERT INTO Funcionarios (Nome, Cargo, Salario) VALUES ('{nome}', '{cargo}', {salario})";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Registro inserido com sucesso. Linhas afetadas: {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao inserir registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}

