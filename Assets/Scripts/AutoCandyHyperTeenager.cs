using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCandyHyperTeenager : MonoBehaviour
{
    public static bool CreatingCandy = false;

    public static int CandyIncrease;
    
    public int InternalIncrease;
    
    void Update()
    {
        CandyIncrease = GlobalHyperTeenager.HyperTeenagersSec / GlobalHyperTeenager.numberOfHyperTeenagers * GlobalHyperTeenager.numberOfHyperTeenagers;
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
