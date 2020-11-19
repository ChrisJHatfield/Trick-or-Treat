using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCandyStore : MonoBehaviour
{
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject CandyStoreStats;

    public int currentMoney;

    public static int CandyStoreValue = 8200;

    public static bool turnOffButton = false;

    public static int numberOfCandyStores;

    public static int CandyStoreSec;

    void Update()
    {
        currentMoney = GlobalMoney.MoneyCount;
        CandyStoreStats.GetComponent<Text>().text = $"Candy Stores: {numberOfCandyStores} @ {CandyStoreSec} Candies Sold Per Second";
        fakeText.GetComponent<Text>().text = $"Buy A New Candy Store ${CandyStoreValue}";
        realText.GetComponent<Text>().text = $"Buy A New Candy Store ${CandyStoreValue}";
        if (currentMoney >= CandyStoreValue)
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
