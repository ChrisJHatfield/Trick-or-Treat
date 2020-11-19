using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHyperTeenager : MonoBehaviour
{
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject HyperTeenagerStats;

    public int currentCandyEaten;

    public static int HyperTeenagerValue = 60;

    public static bool turnOffButton = false;

    public static int numberOfHyperTeenagers;

    public static int HyperTeenagersSec;
    
    void Update()
    {
        currentCandyEaten = GlobalEats.EatenCount;
        HyperTeenagerStats.GetComponent<Text>().text = $"Hyper Teenagers: {numberOfHyperTeenagers} @ {HyperTeenagersSec} Candies Per Second";
        fakeText.GetComponent<Text>().text = $"Recruit Hyper Teenager {HyperTeenagerValue} SR";
        realText.GetComponent<Text>().text = $"Recruit Hyper Teenager {HyperTeenagerValue} SR";
        if (currentCandyEaten >= HyperTeenagerValue)
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
