using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCandyWarehouse : MonoBehaviour
{
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject CandyWarehouseStats;

    public int currentMoney;

    public static int CandyWarehouseValue = 30000;

    public static bool turnOffButton = false;

    public static int numberOfCandyWarehouses;

    public static int CandyWarehouseSec;

    void Update()
    {
        currentMoney = GlobalMoney.MoneyCount;
        CandyWarehouseStats.GetComponent<Text>().text = $"Candy Warehouses: {numberOfCandyWarehouses} @ {CandyWarehouseSec} Candies Sold Per Second";
        fakeText.GetComponent<Text>().text = $"Buy A Candy Warehouse ${CandyWarehouseValue}";
        realText.GetComponent<Text>().text = $"Buy A Candy Warehouse ${CandyWarehouseValue}";
        if (currentMoney >= CandyWarehouseValue)
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
