using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{

    public GameObject AutoCandy;

    public GameObject CandyStandAutoSell;

    public GameObject CarnivalBoothAutoSell;

    public GameObject CandyStoreAutoSell;

    public GameObject CandyWarehouseAutoSell;

    public GameObject HyperTeenagerCandy;

    public GameObject AskGrandmaCandy;

    public GameObject HandfulCandy;

    public GameObject Entrepeneur;

    public void StartAutoCandy()
    {
        AutoCandy.SetActive(true);
        GlobalEats.EatenCount -= GlobalTrickorTreater.trickOrTreaterValue;
        GlobalTrickorTreater.trickOrTreaterValue = Mathf.RoundToInt(GlobalTrickorTreater.trickOrTreaterValue * 1.111f);
        GlobalTrickorTreater.turnOffButton = true;
        GlobalTrickorTreater.TrickorTreatersSec += 1;
        GlobalTrickorTreater.numberOfTrickOrTreaters += 1;
    }

    public void StartHyperTeenagerAutoCandy()
    {
        HyperTeenagerCandy.SetActive(true);
        GlobalEats.EatenCount -= GlobalHyperTeenager.HyperTeenagerValue;
        GlobalHyperTeenager.HyperTeenagerValue = Mathf.RoundToInt(GlobalHyperTeenager.HyperTeenagerValue * 1.225f);
        GlobalHyperTeenager.turnOffButton = true;
        GlobalHyperTeenager.HyperTeenagersSec += 4;
        GlobalHyperTeenager.numberOfHyperTeenagers += 1;
    }

    public void StartAskGrandmaAutoCandy()
    {
        AskGrandmaCandy.SetActive(true);
        GlobalEats.EatenCount -= GlobalAskGrandma.AskGrandmaValue;
        GlobalAskGrandma.AskGrandmaValue = Mathf.RoundToInt(GlobalAskGrandma.AskGrandmaValue * 1.575f);
        GlobalAskGrandma.turnOffButton = true;
        GlobalAskGrandma.AskGrandmasSec += 14;
        GlobalAskGrandma.numberOfAskGrandmas += 1;
    }

    public void StartCandyStandAutoSell()
    {
        CandyStandAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalCandyStand.CandyStandValue;
        GlobalCandyStand.CandyStandValue = Mathf.RoundToInt(GlobalCandyStand.CandyStandValue * 1.225f);
        GlobalCandyStand.turnOffButton = true;
        GlobalCandyStand.CandyStandSec += 1;
        GlobalCandyStand.numberOfCandyStands += 1;
    }

    public void StartCarnivalBoothAutoSell()
    {
        CarnivalBoothAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalCarnivalBooth.CarnivalBoothValue;
        GlobalCarnivalBooth.CarnivalBoothValue = Mathf.RoundToInt(GlobalCarnivalBooth.CarnivalBoothValue * 1.427f);
        GlobalCarnivalBooth.turnOffButton = true;
        GlobalCarnivalBooth.CarnivalBoothSec += 10;
        GlobalCarnivalBooth.numberOfCarnivalBooth += 1;
    }

    public void StartCandyStoreAutoSell()
    {
        CandyStoreAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalCandyStore.CandyStoreValue;
        GlobalCandyStore.CandyStoreValue = Mathf.RoundToInt(GlobalCandyStore.CandyStoreValue * 1.639f);
        GlobalCandyStore.turnOffButton = true;
        GlobalCandyStore.CandyStoreSec += 50;
        GlobalCandyStore.numberOfCandyStores += 1;
    }

    public void StartCandyWarehouseAutoSell()
    {
        CandyWarehouseAutoSell.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalCandyWarehouse.CandyWarehouseValue;
        GlobalCandyWarehouse.CandyWarehouseValue = Mathf.RoundToInt(GlobalCandyWarehouse.CandyWarehouseValue * 1.85f);
        GlobalCandyWarehouse.turnOffButton = true;
        GlobalCandyWarehouse.CandyWarehouseSec += 100;
        GlobalCandyWarehouse.numberOfCandyWarehouses += 1;
    }

    public void UpgradedHandfulCandy()
    {
        HandfulCandy.SetActive(true);
        GlobalMoney.MoneyCount -= GlobalHandfulCandy.HandfulCandyValue;
        GlobalEats.EatenCount -= GlobalHandfulCandy.HandfulCandyValue;
        GlobalHandfulCandy.turnOffButton = true;
    }

    public void UpgradedEntrepeneur()
    {
        Entrepeneur.SetActive(true);
        GlobalEats.EatenCount -= GlobalEntrepeneur.EntrepeneurValue;
        GlobalEntrepeneur.turnOffButton = true;
    }

}