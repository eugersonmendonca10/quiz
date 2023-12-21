using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ButtonsTexts : MonoBehaviour {

    public GameObject Missed;
    public GameObject Beated;
    public GameObject InstancePosition;

    public void Buttomclicked(GameObject ButtomName)
    {
        if (ButtomName.GetComponent<Text>().text == TextsManager.AnswerHaveToBe.ToString())
        {
            Instantiate(Beated, new Vector3(InstancePosition.transform.position.x, InstancePosition.transform.position.y, InstancePosition.transform.position.z), InstancePosition.transform.rotation);
           // print("acertou");
            TextsManager.ScoreNum += 10;
            TextsManager.TimeNum += 15;
            TextsManager.Beated = true;
            TextsManager.IenumeratorTimerNum -= 0.03f;
        }
        if (ButtomName.GetComponent<Text>().text != TextsManager.AnswerHaveToBe.ToString())
        {
            Instantiate(Missed, new Vector3(InstancePosition.transform.position.x, InstancePosition.transform.position.y, InstancePosition.transform.position.z), InstancePosition.transform.rotation);
            //print("errou");
            TextsManager.TimeNum -= 5;
            TextsManager.Missed = true;
        }
    }
}
