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
    public float isDone;
    public GameObject empty;
    public GameObject back;
    public GameObject player;
    public GameObject saveLoad;
    public GameObject camera;
    public GameObject done;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("isDone"))
        {
            Load();
            if(isDone == 1)
            {
                empty.SetActive(false);
            }
            else
            {
                player.GetComponent<Move>().enabled = false;
                saveLoad.SetActive(false);
                camera.GetComponent<CamRot>().enabled = false;
            }
        }
        else
        {
            player.GetComponent<Move>().enabled = false;
            saveLoad.SetActive(false);
            camera.GetComponent<CamRot>().enabled = false;
        }
        
        questionNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textOnScreen.text = convo.questions[questionNumber];
        if(questionNumber == 3)
        {
            // no.SetActive(false);
            // yes.SetActive(false);
            // reset.SetActive(true);
            next.SetActive(false);
            done.SetActive(true);
            
        }
        else
        {
            next.SetActive(true);
            done.SetActive(false);
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
    public void Done()
    {
        empty.SetActive(false);
        isDone = 1;

        player.GetComponent<Move>().enabled = true;
        saveLoad.SetActive(true);
        camera.GetComponent<CamRot>().enabled = true;
        PlayerPrefs.SetFloat("isDone", isDone);
    }
    public void Load()
    {
        isDone = PlayerPrefs.GetFloat("isDone");
    }
}
