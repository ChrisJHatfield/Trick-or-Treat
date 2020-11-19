using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    
    public GameObject statusBox;

    public float candyCheck;

    public int genChance;

    public bool disasterActive = false;

    public int candyLoss;

    void Update()
    {
        candyCheck = GlobalCandies.CandyCount / 10;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);

        if (candyCheck >= genChance)
        {
            candyLoss = Mathf.RoundToInt(GlobalCandies.CandyCount * 0.25f);
            statusBox.GetComponent<Text>().text = $"Trick or Treaters lost {candyLoss} pieces of their candy!";
            GlobalCandies.CandyCount -= candyLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        else
        {
            yield return new WaitForSeconds(10);
            disasterActive = false;
        }
    }
}

