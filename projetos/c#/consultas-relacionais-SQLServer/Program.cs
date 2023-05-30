using System;
using System.Data.SqlClient;

namespace ConsultasRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configurar a string de conexão com o banco de dados
            string connectionString = "Server=nome_servidor;Database=nome_banco_dados;User Id=usuario;Password=senha;";

            // Realizar a conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    Console.WriteLine("Consultas Relacionais no SQL Server");
                    Console.WriteLine("----------------------------------");

                    // Consulta para obter todos os funcionários e seus departamentos correspondentes
                    string query = "SELECT Funcionarios.Nome AS NomeFuncionario, Departamentos.Nome AS NomeDepartamento " +
                                   "FROM Funcionarios " +
                                   "INNER JOIN Departamentos ON Funcionarios.DepartamentoId = Departamentos.Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Executar a consulta e obter o resultado
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterar sobre as linhas do resultado
                            while (reader.Read())
                            {
                                string? nomeFuncionario = reader["NomeFuncionario"].ToString();
                                string? nomeDepartamento = reader["NomeDepartamento"].ToString();

                                Console.WriteLine($"Funcionário: {nomeFuncionario}, Departamento: {nomeDepartamento}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao executar consulta: " + ex.Message);
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
