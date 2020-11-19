using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTrickorTreater : MonoBehaviour
{
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject trickOrTreaterStats;

    public int currentCandyEaten;

    public static int trickOrTreaterValue = 12;

    public static bool turnOffButton = false;

    public static int numberOfTrickOrTreaters;

    public static int TrickorTreatersSec;


    void Start()
    {
        
    }

    
    void Update()
    {
        currentCandyEaten = GlobalEats.EatenCount;
        trickOrTreaterStats.GetComponent<Text>().text = $"Trick or Treaters: {numberOfTrickOrTreaters} @ {TrickorTreatersSec} Candies Per Second";
        fakeText.GetComponent<Text>().text = $"Recruit Trick or Treater      {trickOrTreaterValue} SR";
        realText.GetComponent<Text>().text = $"Recruit Trick or Treater      {trickOrTreaterValue} SR";
        if (currentCandyEaten >= trickOrTreaterValue)
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
