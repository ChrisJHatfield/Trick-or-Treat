using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    
    public GameObject statusBox;
    
    public GameObject textbox;

    public GameObject TrickOrTreatButtonText;

    public void ClickTheButton()
    {
        GlobalCandies.CandyCount += 1;
        TrickOrTreatButtonText.GetComponent<Text>().text = "+1 Candies";
        statusBox.GetComponent<Animation>().Play("StatusAnimation");
    }
    
}
