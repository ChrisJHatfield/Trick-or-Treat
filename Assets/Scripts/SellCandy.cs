using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCandy : MonoBehaviour
{
    public GameObject textbox;

    public GameObject statusBox;

    public void ClickTheButton()
    {
        if (GlobalCandies.CandyCount <= 0)
        {
            statusBox.GetComponent<Text>().text = "There is no more Candy to sell!";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
        }
        else
        {
            GlobalCandies.CandyCount -= 1;
            GlobalMoney.MoneyCount += 1;
        }
        if (GlobalEntrepeneur.turnOffButton)
        {
            if (GlobalCandies.CandyCount <= GlobalEntrepeneur.Modifier + 1)
            {
                statusBox.GetComponent<Text>().text = "There is no more Candy to sell!";
                statusBox.GetComponent<Animation>().Play("StatusAnimation");
            }
            else
            {
                GlobalCandies.CandyCount -= GlobalEntrepeneur.Modifier;
                GlobalMoney.MoneyCount += GlobalEntrepeneur.Modifier;
            }
        }
    }
    
}

