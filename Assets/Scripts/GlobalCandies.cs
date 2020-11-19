using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCandies : MonoBehaviour
{

    public static int CandyCount;

    public GameObject CandyDisplay;

    public int InternalCandy;

    void Update()
    {
        InternalCandy = CandyCount;
        CandyDisplay.GetComponent<Text>().text = "Candies: " + InternalCandy;
    }
}
