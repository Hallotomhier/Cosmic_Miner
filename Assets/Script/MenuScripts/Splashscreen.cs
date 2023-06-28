using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splashscreen : MonoBehaviour
{
    public GameObject splashscr;
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Splashscr");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Splashscr()
    {
        yield return new WaitForSeconds(4);
        splashscr.SetActive(false);
        mainMenu.SetActive(true);
    }
}
