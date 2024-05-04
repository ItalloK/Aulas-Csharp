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
                        // Exemplo: lendo uma coluna chamada "Nome"
                        string nome = reader["Nome"].ToString(); // Substitua "Nome" pelo nome da coluna que deseja acessar
                        Console.WriteLine(nome);
                    }
                }
            }
        }
    }
}
