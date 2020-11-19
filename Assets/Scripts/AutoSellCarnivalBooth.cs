using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AutoSellCarnivalBooth : MonoBehaviour
{
    public static bool SellingCandy = false;

    public static int MoneyIncrease;
    
    public int InternalIncrease;
    
    public void Update()
    {
        MoneyIncrease = GlobalCarnivalBooth.CarnivalBoothSec / GlobalCarnivalBooth.numberOfCarnivalBooth * GlobalCarnivalBooth.numberOfCarnivalBooth;
        InternalIncrease = MoneyIncrease;
        if (SellingCandy == false)
        {
            SellingCandy = true;
            StartCoroutine(SellTheCandy());
        }
    }

    IEnumerator SellTheCandy()
    {
        if ( GlobalCandies.CandyCount <= InternalIncrease)
        {
            SellingCandy = false;
        }
        else
        {
            GlobalCandies.CandyCount -= InternalIncrease; 
            GlobalMoney.MoneyCount += InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingCandy = false;
        }
    }
}
