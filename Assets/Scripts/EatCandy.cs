using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatCandy : MonoBehaviour
{
    
    public GameObject textbox;

    public GameObject statusBox;

    public void ClickTheButton()
    {
        if (GlobalCandies.CandyCount <= 0)
        {
            statusBox.GetComponent<Text>().text = "There is no more Candy to eat!";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
        }
        else
        {
            GlobalCandies.CandyCount -= 1;
            GlobalEats.EatenCount += 1;
        }
        if (GlobalHandfulCandy.turnOffButton)
        {
            if (GlobalCandies.CandyCount <= GlobalHandfulCandy.Modifier + 1)
            {
                statusBox.GetComponent<Text>().text = "There is no more Candy to eat!";
                statusBox.GetComponent<Animation>().Play("StatusAnimation");
            }
            else
            {
                GlobalCandies.CandyCount -= GlobalHandfulCandy.Modifier;
                GlobalEats.EatenCount += GlobalHandfulCandy.Modifier;
            }
        }
    }
    
}
