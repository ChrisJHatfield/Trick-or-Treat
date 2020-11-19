using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHandfulCandy : MonoBehaviour
{
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject HandfulCandyStats;

    public int currentCandyEaten;

    public int currentMoney;

    public static int HandfulCandyValue = 100;

    public static bool turnOffButton = false;

    public static int Modifier = 4;
    
    public void Update()
    {
        currentMoney = GlobalMoney.MoneyCount;
        currentCandyEaten = GlobalEats.EatenCount;
        HandfulCandyStats.GetComponent<Text>().text = "";
        fakeText.GetComponent<Text>().text = $"Handful of Candy           (+{Modifier} to Eat Candy)           ${HandfulCandyValue} & {HandfulCandyValue} SR";
        realText.GetComponent<Text>().text = $"Handful of Candy           (+{Modifier} to Eat Candy)           ${HandfulCandyValue} & {HandfulCandyValue} SR";
        if (currentCandyEaten >= HandfulCandyValue && currentMoney >= HandfulCandyValue)
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
            HandfulCandyStats.GetComponent<Text>().text = $"Handful of Candy (+4 to Eat Candy)";
            fakeButton.SetActive(false);
            realbutton.SetActive(false);
        }
    }
}
