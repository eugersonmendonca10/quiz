using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ButtomClicked : MonoBehaviour {

    public void Buttomclicked(string ButtomName)
    {
        if (ButtomName == "Credits")
        {
            Application.LoadLevel("Credits");
        }
        if (ButtomName == "Play" || ButtomName == "PlayAgain")
        {
            Application.LoadLevel("Game");
        }
        if (ButtomName == "Back")
        {
            Application.LoadLevel("Menu");
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
