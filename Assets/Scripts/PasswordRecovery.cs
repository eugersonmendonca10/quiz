using UnityEngine;
using System.Collections;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public class PasswordRecovery : MonoBehaviour {

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

        string usernameToRecover = "usernameToRecover"; // Nome de usuário para recuperar senha
        string query = "SELECT password FROM users WHERE username = '" + usernameToRecover + "'";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        if (dataReader.Read()) {
            string recoveredPassword = dataReader["password"].ToString();
            Debug.Log("A senha para o usuário '" + usernameToRecover + "' é: " + recoveredPassword);
        } else {
            Debug.Log("Usuário não encontrado ou senha não existe para o usuário: " + usernameToRecover);
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
