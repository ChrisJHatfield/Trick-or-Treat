using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCandy : MonoBehaviour
{
    
    public static bool CreatingCandy = false;

    public static int CandyIncrease = 1;
    
    public int InternalIncrease;
    
    void Update()
    {
        CandyIncrease = GlobalTrickorTreater.TrickorTreatersSec / GlobalTrickorTreater.numberOfTrickOrTreaters * GlobalTrickorTreater.numberOfTrickOrTreaters;
        InternalIncrease = CandyIncrease;
        if (CreatingCandy == false)
        {
            CreatingCandy = true;
            StartCoroutine(CreateTheCandy());
        }
    }

    IEnumerator CreateTheCandy()
    {
        GlobalCandies.CandyCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCandy = false;
    }
}
