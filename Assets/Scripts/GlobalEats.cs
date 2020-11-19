using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalEats : MonoBehaviour
{

    public static int EatenCount;

    public GameObject EatenDisplay;

    public int InternalEat;

    void Update()
    {
        InternalEat = EatenCount;
        EatenDisplay.GetComponent<Text>().text = "Sugar Rush: " + InternalEat;
    }
}
