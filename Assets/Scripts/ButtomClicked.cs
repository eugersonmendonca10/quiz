using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ButtomClicked : MonoBehaviour {

    public void Buttomclicked(string ButtomName)
    {
        if (ButtomName == "Deslogar")
        {
            Application.LoadLevel("Menu_Login");
        }
        if (ButtomName == "Play" || ButtomName == "PlayAgain")
        {
            Application.LoadLevel("Game");
        }
        if (ButtomName == "Back")
        {
            Application.LoadLevel("Menu");
        }
       if (ButtomName == "Login")
        {
            Debug.Log("aasaasasasasasasasa")
            InputField user - GameObject.Find("Usuario”).GetComponent<InputField>();
            string usenText = usen.text;
            InputField email = GameObject.Find("Senha”).GetComponent<InputField>();
            string emailText - email.text;

            if(userText == "amarinho” && emailText == "matheusg12”)
            {   
            Application.LoadLevel("Menu");
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
