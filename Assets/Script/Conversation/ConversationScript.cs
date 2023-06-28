using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class conversationScript : MonoBehaviour
{
    public TMP_Text textOnScreen;
    public int questionNumber;
    public Convo1 convo;
    public GameObject yes;
    public GameObject no;
    public GameObject reset;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        questionNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textOnScreen.text = convo.questions[questionNumber];
        if(questionNumber >= 3)
        {
            no.SetActive(false);
            yes.SetActive(false);
            reset.SetActive(true);
        }
    }
    public void Yes()
    {
        questionNumber += questionNumber +1;
    }
    public void No()
    {
        questionNumber += questionNumber +2;
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
