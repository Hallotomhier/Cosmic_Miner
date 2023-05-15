using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public float cash;
    public float iron, gold, diamond, oil;
    public Text text;


    public void Update()
    {
        text.text = cash.ToString();
    }
}
