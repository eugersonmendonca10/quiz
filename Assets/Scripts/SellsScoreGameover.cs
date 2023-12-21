using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class SellsScoreGameover : MonoBehaviour {

    public GameObject Scoregameover;
    
	void Update () 
    {
        int scoregameover = PlayerPrefs.GetInt("Player Score");
        Scoregameover.GetComponent<Text>().text = "SCORE : " + scoregameover.ToString();
	}
}
