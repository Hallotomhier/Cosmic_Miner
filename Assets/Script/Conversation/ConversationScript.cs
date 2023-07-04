using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ConversationScript : MonoBehaviour
{
    public TMP_Text textOnScreen;
    public int questionNumber;
    public Convo1 convo;
    // public GameObject yes;
    // public GameObject no;
    // public GameObject reset;
    public GameObject next;
    public bool isDone;
    public GameObject empty;
    public GameObject back;
    // Start is called before the first frame update
    void Start()
    {
        if(isDone == true)
        {
            empty.SetActive(false);
        }
        questionNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textOnScreen.text = convo.questions[questionNumber];
        if(questionNumber >= 4)
        {
            // no.SetActive(false);
            // yes.SetActive(false);
            // reset.SetActive(true);
            empty.SetActive(false);
            isDone = true;
        }
        if(questionNumber < 0)
        {
            questionNumber = 0;
        }
        if(questionNumber == 0)
        {
            back.SetActive(false);
        }
        else
        {
            back.SetActive(true);
        }
        // if (questionNumber = 3)
        // {
        //     next.SetActive(false);
        // }
        // else
        // {
        //     next.SetActive(true);
        // }
    }
    // public void Yes()
    // {
    //     questionNumber += questionNumber +1;
    // }
    // public void No()
    // {
    //     questionNumber += questionNumber +2;
    // }
    // public void Reset()
    // {
    //     SceneManager.LoadScene(0);
    // }
    public void Next()
    {
        questionNumber += 1;
    }
    public void Back()
    {
        questionNumber -= 1;
    }

}
