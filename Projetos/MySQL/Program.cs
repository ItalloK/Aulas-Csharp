using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=csharp;Uid=root;Pwd=root;"; // conecta ao server
        string query = "SELECT * FROM usuarios"; // Tabela de Consulta
        using (MySqlConnection connection = new MySqlConnection(connectionString)) // Cria a conexão com o banco de dados
        {
            connection.Open(); // Abre a conexão
            using (MySqlCommand command = new MySqlCommand(query, connection)) // Cria um comando SQL
            {
                using (MySqlDataReader reader = command.ExecuteReader()) // Executa o comando SQL e obtém um leitor de dados
                {
                    while (reader.Read()) // Itera sobre as linhas retornadas
                    {
                        // Lendo as colunas "Nome", "Idade" e "Cargo"
                        string nome = reader["Nome"].ToString();
                        string idade = reader["Idade"].ToString();
                        string cargo = reader["Cargo"].ToString();
                        
                        // Exibindo as informações
                        Console.WriteLine("Nome: {0}, Idade: {1}, Cargo: {2}", nome, idade, cargo);
                    }
                }
            }
        }
    }
}
