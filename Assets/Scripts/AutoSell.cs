using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    
    public static bool SellingCandy = false;

    public static int MoneyIncrease = 1;
    
    public int InternalIncrease;
    
    void Update()
    {
        MoneyIncrease = GlobalCandyStand.CandyStandSec / GlobalCandyStand.numberOfCandyStands * GlobalCandyStand.CandyStandSec;
        InternalIncrease = MoneyIncrease;
        if (SellingCandy == false)
        {
            SellingCandy = true;
            StartCoroutine(SellTheCandy());
        }
    }

    IEnumerator SellTheCandy()
    {
        if ( GlobalCandies.CandyCount <= 0 )
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
