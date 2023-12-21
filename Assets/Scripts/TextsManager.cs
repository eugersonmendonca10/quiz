using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;


public class TextsManager : MonoBehaviour
{
    public GameObject Phrases;
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Score;
    public GameObject Time;
    static int Price;
    static int MoneyGaven;
    public static int MoneyToBuyer;
    int NumberRandomize;
    public static float IenumeratorTimerNum;
    public static int TimeNum;
    public static int ScoreNum;
    public static bool Beated;
    public static bool Missed;
    public static bool OutScreen;
    public static bool LoseSell;
    string[] PhrasesList;
    public static string AnswerHaveToBe;
    int NumberRandomButtom;

    void Start()
    {
        AnswerHaveToBe = "";
        PhrasesList = new string[13];
        PhrasesList[0] = "O ARTISTA..... " + /*........(excursionará)*/ "POR VARIAS CIDADES DO INTERIOR.";
        PhrasesList[1] = "SUA AVAREZA E SEU EGOISMO...... " + /* ........(fizeram)*/ "COM QUE TODOS O ABANDONASSEM.";
        PhrasesList[2] = "EU E VOCE SOMOS PESSOAS " + /*.........(responsáveis)*/".......";
        PhrasesList[3] = "MARIA OU JOANA " + /*.........(será representante)*/"......";
        PhrasesList[4] = "O AMOR OU O ODIO " + /*..........(estão presentes)*/".......";
        PhrasesList[5] = "O ALUNO OU OS ALUNOS..... " + /* ..........(cuidarão)*/ "DA EXPOSICAO.";
        PhrasesList[6] = "A MAIORIA DOS JOVENS..... " + /* ........(quer) */ "AS REFORMAS.";
        PhrasesList[7] = "OS ESTADOS UNIDOS...... " + /* .........(reforçam)*/ "AS SUAS BASES.";
        PhrasesList[8] = "A ORQUESTRA...... " + /* .........(TOCOU)*/ "UMA VALSA LONGA.";
        PhrasesList[9] = "OS PARES QUE NOS...... " + /* .........(RODEAVAM)*/ "DANCAVAM BEM.";
        PhrasesList[10] = "A MAIORIA DOS JORNALISTAS..... " + /* .........(APROVOU)*/ "A IDEIA.";
        PhrasesList[11] = "AS CRIANCAS...... " + /* .........(ESTAO)*/ "ANIMADAS.";
        PhrasesList[12] = "ELE TEM PAI E MAE...... " + /* .........(LOUROS)*/ ".";
        CompareAnswer();
        ScoreNum = 0;
        TimeNum = 70;
        IenumeratorTimerNum = 0.5f;
        RandomizePhrases();
        TextsPhrases();
        StartCoroutine(Timer());
        Beated = false;
        Missed = false;
        OutScreen = false;
        LoseSell = false;
    }

    void CompareAnswer()
    {
        if (NumberRandomize == 0)
        {
            AnswerHaveToBe = "EXCURSIONARA";
        }
        if (NumberRandomize == 1)
        {
            AnswerHaveToBe = "FIZERAM";
        }
        if (NumberRandomize == 2)
        {
            AnswerHaveToBe = "RESPONSAVEIS";
        }
        if (NumberRandomize == 3)
        {
            AnswerHaveToBe = "SERA REPRESENTANTE";
        }
        if (NumberRandomize == 4)
        {
            AnswerHaveToBe = "ESTAO PRESENTES";
        }
        if (NumberRandomize == 5)
        {
            AnswerHaveToBe = "CUIDARAO";
        }
        if (NumberRandomize == 6)
        {
            AnswerHaveToBe = "QUER";
        }
        if (NumberRandomize == 7)
        {
            AnswerHaveToBe = "REFORCAM";
        }
        if (NumberRandomize == 8)
        {
            AnswerHaveToBe = "TOCOU";
        }
        if (NumberRandomize == 9)
        {
            AnswerHaveToBe = "RODEAVAM";
        }
        if (NumberRandomize == 10)
        {
            AnswerHaveToBe = "APROVOU";
        }
        if (NumberRandomize == 11)
        {
            AnswerHaveToBe = "ESTAO";
        }
        if (NumberRandomize == 12)
        {
            AnswerHaveToBe = "LOUROS";
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(IenumeratorTimerNum);
        TimeNum -= 1;
        StartCoroutine(Timer());
    }

    void TimeSell()
    {
        Time.GetComponent<Text>().text = "TEMPO\n" + TimeNum.ToString();
    }

    void ScoreSell()
    {
        Score.GetComponent<Text>().text = "SCORE\n" + ScoreNum.ToString();
    }

    void RandomizePhrases()
    {
        NumberRandomize = Random.Range(0,13);
    }

    void ChooseButtom()
    {
        NumberRandomButtom = Random.Range(0, 12);
        CompareAnswer();
        if(NumberRandomButtom <= 5)
        {
            Answer1.GetComponent<Text>().text = AnswerHaveToBe.ToString();
            if(AnswerHaveToBe == "EXCURSIONARA")
            {
                Answer2.GetComponent<Text>().text = "EXCURSIONARAO";
            }
            if (AnswerHaveToBe == "FIZERAM")
            {
                Answer2.GetComponent<Text>().text = "FEZ";
            }
            if (AnswerHaveToBe == "RESPONSAVEIS")
            {
                Answer2.GetComponent<Text>().text = "RESPONSAVEL";
            }
            if (AnswerHaveToBe == "SERA REPRESENTANTE")
            {
                Answer2.GetComponent<Text>().text = "SERAO REPRESENTANTES";
            }
            if (AnswerHaveToBe == "ESTAO PRESENTES")
            {
                Answer2.GetComponent<Text>().text = "ESTA PRESENTE";
            }
            if (AnswerHaveToBe == "CUIDARAO")
            {
                Answer2.GetComponent<Text>().text = "CUIDARA";
            }
            if (AnswerHaveToBe == "QUER")
            {
                Answer2.GetComponent<Text>().text = "QUEREM";
            }
            if (AnswerHaveToBe == "REFORCAM")
            {
                Answer2.GetComponent<Text>().text = "REFORCA";
            }
            if (AnswerHaveToBe == "TOCOU")
            {
                Answer2.GetComponent<Text>().text = "TOCARAM";
            }
            if (AnswerHaveToBe == "RODEAVAM")
            {
                Answer2.GetComponent<Text>().text = "RODEOU";
            }
            if (AnswerHaveToBe == "APROVOU")
            {
                Answer2.GetComponent<Text>().text = "APROVARAM";
            }
            if (AnswerHaveToBe == "ESTAO")
            {
                Answer2.GetComponent<Text>().text = "ESTA";
            }
            if (AnswerHaveToBe == "LOUROS")
            {
                Answer2.GetComponent<Text>().text = "LOURO";
            }
        }
        if (NumberRandomButtom >= 6)
        {
            Answer2.GetComponent<Text>().text = AnswerHaveToBe.ToString();
            if (AnswerHaveToBe == "EXCURSIONARA")
            {
                Answer1.GetComponent<Text>().text = "EXCURSIONARAO";
            }
            if (AnswerHaveToBe == "FIZERAM")
            {
                Answer1.GetComponent<Text>().text = "FEZ";
            }
            if (AnswerHaveToBe == "RESPONSAVEIS")
            {
                Answer1.GetComponent<Text>().text = "RESPONSAVEL";
            }
            if (AnswerHaveToBe == "SERA REPRESENTANTE")
            {
                Answer1.GetComponent<Text>().text = "SERAO REPRESENTANTES";
            }
            if (AnswerHaveToBe == "ESTAO PRESENTES")
            {
                Answer1.GetComponent<Text>().text = "ESTA PRESENTE";
            }
            if (AnswerHaveToBe == "CUIDARAO")
            {
                Answer1.GetComponent<Text>().text = "CUIDARA";
            }
            if (AnswerHaveToBe == "QUER")
            {
                Answer1.GetComponent<Text>().text = "QUEREM";
            }
            if (AnswerHaveToBe == "REFORCAM")
            {
                Answer1.GetComponent<Text>().text = "REFORCA";
            }
            if (AnswerHaveToBe == "TOCOU")
            {
                Answer1.GetComponent<Text>().text = "TOCARAM";
            }
            if (AnswerHaveToBe == "RODEAVAM")
            {
                Answer1.GetComponent<Text>().text = "RODEOU";
            }
            if (AnswerHaveToBe == "APROVOU")
            {
                Answer1.GetComponent<Text>().text = "APROVARAM";
            }
            if (AnswerHaveToBe == "ESTAO")
            {
                Answer1.GetComponent<Text>().text = "ESTA";
            }
            if (AnswerHaveToBe == "LOUROS")
            {
                Answer1.GetComponent<Text>().text = "LOURO";
            }
        }
    }

    void TextsPhrases()
    {
        Phrases.GetComponent<Text>().text = PhrasesList[NumberRandomize].ToString();
        ChooseButtom();
    }

    void BeatedFunction()
    {
        if (Beated)
        {
            Beated = false;
            RandomizePhrases();
            TextsPhrases();
        }
    }

    void MissedFunction()
    {
        if (Missed)
        {
            Missed = false;
            RandomizePhrases();
            TextsPhrases();
        }
    }

    void Lose()
    {
        if (TimeNum <= 0)
        {
            LoseSell = true;
            PlayerPrefs.SetInt("Player Score", ScoreNum);
        }
        if (LoseSell)
        {
            Application.LoadLevel("GameOver");
        }
    }

    void Update()
    {
        if (NumberRandomize == 0)
        {
            RandomizePhrases();
        }
        CompareAnswer();
        Lose();
        BeatedFunction();
        MissedFunction();
        ScoreSell();
        TimeSell();
//        print(IenumeratorTimerNum);
    }
}
