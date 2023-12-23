using UnityEngine;
using System.Collections;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DatabaseManager : MonoBehaviour {

    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    void Start () {
        server = "localhost";       // Endereço do servidor MySQL
        database = "mydatabase";    // Nome do banco de dados
        uid = "myusername";         // Nome de usuário do MySQL
        password = "mypassword";   // Senha do MySQL

        string connectionString = "Server=" + server + ";Database=" + database + ";Uid=" + uid + ";Pwd=" + password + ";";

        connection = new MySqlConnection(connectionString);
        OpenConnection();
        
        string query = "SELECT * FROM users"; // Consulta SQL para selecionar todos os usuários

        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read()) {
            // Simulando dados do usuário
            string userID = dataReader["id"].ToString();
            string userName = dataReader["username"].ToString();
            string userEmail = dataReader["email"].ToString();
            
            // Exibindo dados no console
            Debug.Log("ID: " + userID + ", Username: " + userName + ", Email: " + userEmail);
        }

        dataReader.Close();
        CloseConnection();
    }

    private void OpenConnection() {
        if (connection.State == ConnectionState.Closed)
            connection.Open();
    }

    private void CloseConnection() {
        if (connection.State == ConnectionState.Open)
            connection.Close();
    }
}
