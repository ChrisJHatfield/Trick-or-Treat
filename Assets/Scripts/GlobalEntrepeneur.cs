using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalEntrepeneur : MonoBehaviour
{
    public GameObject fakeButton;

    public GameObject realbutton;

    public GameObject fakeText;

    public GameObject realText;

    public GameObject EntrepeneurStats;

    public int currentCandyEaten;

    public static int EntrepeneurValue = 200;

    public static bool turnOffButton = false;

    public static int Modifier = 3;
    
    public void Update()
    {
        currentCandyEaten = GlobalEats.EatenCount;
        EntrepeneurStats.GetComponent<Text>().text = "";
        fakeText.GetComponent<Text>().text = $"Entrepeneur                    (+{Modifier} to Sell Candy)                {EntrepeneurValue} SR";
        realText.GetComponent<Text>().text = $"Entrepeneur                    (+{Modifier} to Sell Candy)                {EntrepeneurValue} SR";
        if (currentCandyEaten >= EntrepeneurValue)
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
            EntrepeneurStats.GetComponent<Text>().text = $"Entrepeneur (+3 to Sell Candy)";
            fakeButton.SetActive(false);
            realbutton.SetActive(false);
        }
    }
}
