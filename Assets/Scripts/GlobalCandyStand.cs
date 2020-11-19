using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCandyStand : MonoBehaviour
{
    
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject CandyStandStats;

    public int currentMoney;

    public static int CandyStandValue = 50;

    public static bool turnOffButton = false;

    public static int numberOfCandyStands;

    public static int CandyStandSec;

    void Update()
    {
        currentMoney = GlobalMoney.MoneyCount;
        CandyStandStats.GetComponent<Text>().text = $"Candy Stands: {numberOfCandyStands} @ {CandyStandSec} Candies Sold Per Second";
        fakeText.GetComponent<Text>().text = $"Buy A New Candy Stand ${CandyStandValue}";
        realText.GetComponent<Text>().text = $"Buy A New Candy Stand ${CandyStandValue}";
        if (currentMoney >= CandyStandValue)
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

