using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{

    public int saveGameCash;

    public static int saveValue = 10;

    public GameObject saveButton;

    public GameObject saveText;

    void Update()
    {
        saveText.GetComponent<Text>().text = $"Cost: {saveValue} SR";
        saveGameCash = GlobalEats.EatenCount;
        if (saveGameCash >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            saveButton.GetComponent<Button>().interactable = false;
        }
    }

    public void SaveTheGame()
    {

        AutoCandy.CreatingCandy = true;
        AutoCandyHyperTeenager.CreatingCandy = true;
        AutoCandyAskGrandma.CreatingCandy = true;

        AutoSell.SellingCandy = true;
        AutoSellCarnivalBooth.SellingCandy = true;
        AutoSellCandyStore.SellingCandy = true;
        AutoSellCandyWarehouse.SellingCandy = true;

        GlobalEats.EatenCount -= saveValue;

        PlayerPrefs.SetInt("SavedCandies", GlobalCandies.CandyCount);
        PlayerPrefs.SetInt("SavedEats", GlobalEats.EatenCount);
        PlayerPrefs.SetInt("SavedMoney", GlobalMoney.MoneyCount);

        PlayerPrefs.SetInt("SavedTrickorTreaters", GlobalTrickorTreater.TrickorTreatersSec);
        PlayerPrefs.SetInt("SavedTrickorTreatersCount", GlobalTrickorTreater.numberOfTrickOrTreaters);
        PlayerPrefs.SetInt("SavedTrickorTreatersValue", GlobalTrickorTreater.trickOrTreaterValue);

        PlayerPrefs.SetInt("SavedHyperTeenager", GlobalHyperTeenager.HyperTeenagersSec);
        PlayerPrefs.SetInt("SavedHyperTeenagersCount", GlobalHyperTeenager.numberOfHyperTeenagers);
        PlayerPrefs.SetInt("SavedHyperTeenagersValue", GlobalHyperTeenager.HyperTeenagerValue);

        PlayerPrefs.SetInt("SavedAskGrandma", GlobalAskGrandma.AskGrandmasSec);
        PlayerPrefs.SetInt("SavedAskGrandmasCount", GlobalAskGrandma.numberOfAskGrandmas);
        PlayerPrefs.SetInt("SavedAskGrandmasValue", GlobalAskGrandma.AskGrandmaValue);

        PlayerPrefs.SetInt("SavedCandyStand", GlobalCandyStand.CandyStandSec);
        PlayerPrefs.SetInt("SavedCandyStandsCount", GlobalCandyStand.numberOfCandyStands);
        PlayerPrefs.SetInt("SavedCandyStandsValue", GlobalCandyStand.CandyStandValue);

        PlayerPrefs.SetInt("SavedCarnivalBooth", GlobalCarnivalBooth.CarnivalBoothSec);
        PlayerPrefs.SetInt("SavedCarnivalBoothsCount", GlobalCarnivalBooth.numberOfCarnivalBooth);
        PlayerPrefs.SetInt("SavedCarnivalBoothsValue", GlobalCarnivalBooth.CarnivalBoothValue);

        PlayerPrefs.SetInt("SavedCandyStore", GlobalCandyStore.CandyStoreSec);
        PlayerPrefs.SetInt("SavedCandyStoresCount", GlobalCandyStore.numberOfCandyStores);
        PlayerPrefs.SetInt("SavedCandyStoresValue", GlobalCandyStore.CandyStoreValue);

        PlayerPrefs.SetInt("SavedCandyWarehouse", GlobalCandyWarehouse.CandyWarehouseSec);
        PlayerPrefs.SetInt("SavedCandyWarehousesCount", GlobalCandyWarehouse.numberOfCandyWarehouses);
        PlayerPrefs.SetInt("SavedCandyWarehousesValue", GlobalCandyWarehouse.CandyWarehouseValue);

        saveValue *= 2;
        PlayerPrefs.SetInt("SaveValue", saveValue);
    }
}
