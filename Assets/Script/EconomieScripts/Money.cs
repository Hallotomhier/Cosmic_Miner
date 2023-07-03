using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money : MonoBehaviour
{
    public float cash;
    public float iron, gold, diamond, oil;
    public TMP_Text text;
    public TMP_Text iron_text;
    public TMP_Text gold_text;
    public TMP_Text diamond_text;
    public TMP_Text oil_text;



    public void Update()
    {
        text.text = cash.ToString("0");
        iron_text.text = iron.ToString("0");
        gold_text.text = gold.ToString("0");
        diamond_text.text = diamond.ToString("0");
        oil_text.text = oil.ToString("0");

    }
}
