using UnityEngine;
using System.Collections;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public class PlayerRegistration : MonoBehaviour {

    private const string connectionString = "Server=yourServerAddress;Database=yourDatabaseName;Uid=yourUsername;Pwd=yourPassword;";
    private const string tableName = "players";

    // Método para cadastrar um novo jogador no banco de dados
    public void RegisterPlayer(string playerName, int initialScore) {
        using (MySqlConnection connection = new MySqlConnection(connectionString)) {
            connection.Open();

            // Prepara a consulta SQL para inserir o novo jogador
            string query = $"INSERT INTO {tableName} (player_name, score) VALUES (@playerName, @score)";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            // Define os parâmetros da consulta para evitar injeção de SQL
            cmd.Parameters.AddWithValue("@playerName", playerName);
            cmd.Parameters.AddWithValue("@score", initialScore);

            // Executa a consulta para inserir o novo jogador
            cmd.ExecuteNonQuery();
        }
    }
}
