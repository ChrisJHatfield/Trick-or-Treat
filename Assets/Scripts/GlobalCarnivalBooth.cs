using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCarnivalBooth : MonoBehaviour
{
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject CarnivalBoothStats;

    public int currentMoney;

    public static int CarnivalBoothValue = 600;

    public static bool turnOffButton = false;

    public static int numberOfCarnivalBooth;

    public static int CarnivalBoothSec;

    void Update()
    {
        currentMoney = GlobalMoney.MoneyCount;
        CarnivalBoothStats.GetComponent<Text>().text = $"Carnival Booths: {numberOfCarnivalBooth} @ {CarnivalBoothSec} Candies Sold Per Second";
        fakeText.GetComponent<Text>().text = $"Rent A Carnival Booth ${CarnivalBoothValue}";
        realText.GetComponent<Text>().text = $"Rent A Carnival Booth ${CarnivalBoothValue}";
        if (currentMoney >= CarnivalBoothValue)
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
