using UnityEngine;
using System.Collections;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public class ScoreManager : MonoBehaviour {

    private const string connectionString = "Server=yourServerAddress;Database=yourDatabaseName;Uid=yourUsername;Pwd=yourPassword;";
    private const string tableName = "scores";

    // Adiciona a pontuação do jogador ao banco de dados
    public void AddScore(string playerName, int score) {
        using (MySqlConnection connection = new MySqlConnection(connectionString)) {
            connection.Open();

            // Prepara a consulta SQL para inserir os dados no banco
            string query = $"INSERT INTO {tableName} (player_name, score) VALUES (@playerName, @score)";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            // Define os parâmetros da consulta para evitar injeção de SQL
            cmd.Parameters.AddWithValue("@playerName", playerName);
            cmd.Parameters.AddWithValue("@score", score);

            // Executa a consulta para inserir a pontuação
            cmd.ExecuteNonQuery();
        }
    }

    // Mostra as 10 melhores pontuações armazenadas no banco de dados
    public void ShowHighScores() {
        using (MySqlConnection connection = new MySqlConnection(connectionString)) {
            connection.Open();

            // Prepara a consulta SQL para buscar as melhores pontuações
            string query = $"SELECT * FROM {tableName} ORDER BY score DESC LIMIT 10";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            // Executa a consulta e lê os resultados
            using (MySqlDataReader dataReader = cmd.ExecuteReader()) {
                Debug.Log("High Scores:");
                while (dataReader.Read()) {
                    string playerName = dataReader.GetString("player_name");
                    int score = dataReader.GetInt32("score");
                    Debug.Log(playerName + ": " + score);
                }
            }
        }
    }
}
