using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAskGrandma : MonoBehaviour
{
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject AskGrandmaStats;

    public int currentCandyEaten;

    public static int AskGrandmaValue = 120;

    public static bool turnOffButton = false;

    public static int numberOfAskGrandmas;

    public static int AskGrandmasSec;
    
    void Update()
    {
        currentCandyEaten = GlobalEats.EatenCount;
        AskGrandmaStats.GetComponent<Text>().text = $"Grandma's Candy Batches: {numberOfAskGrandmas} @ {AskGrandmasSec} Candies Per Second";
        fakeText.GetComponent<Text>().text = $"Grandma Makes Candy {AskGrandmaValue} SR";
        realText.GetComponent<Text>().text = $"Grandma Makes Candy {AskGrandmaValue} SR";
        if (currentCandyEaten >= AskGrandmaValue)
        {
            fakeButton.SetActive(false);
            realbutton.SetActive(true);
        }
        else
        {
            fakeButton.SetActive(true);
            realbutton.SetActive(false);
        }
        if (turnOffButton == true)
        {
            fakeButton.SetActive(true);
            realbutton.SetActive(false);
            turnOffButton = false;
        }
    }
}
