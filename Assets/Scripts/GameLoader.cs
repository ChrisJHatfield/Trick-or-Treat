using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    
    public int SavedCandies;

    public int SavedEats;

    public int SavedMoneys;

    public int SavedTrickorTreaters;
    public int SavedTrickorTreaterCount;
    public int SavedTrickorTreaterValue;

    public int SavedHyperTeenager;
    public int SavedHyperTeenagerCount;
    public int SavedHyperTeenagerValue;

    public int SavedAskGrandma;
    public int SavedAskGrandmaCount;
    public int SavedAskGrandmaValue;

    public int SavedCandyStand;
    public int SavedCandyStandCount;
    public int SavedCandyStandValue;

    public int SavedCarnivalBooth;
    public int SavedCarnivalBoothCount;
    public int SavedCarnivalBoothValue;

    public int SavedCandyStore;
    public int SavedCandyStoreCount;
    public int SavedCandyStoreValue;

    public int SavedCandyWarehouse;
    public int SavedCandyWarehouseCount;
    public int SavedCandyWarehouseValue;

    public int SavedValue;



    void Start()
    {
        if (MainMenuOptions.isLoading == true)
        {
            SavedCandies = PlayerPrefs.GetInt("SavedCandies");
            GlobalCandies.CandyCount = SavedCandies;

            SavedEats = PlayerPrefs.GetInt("SavedEats");
            GlobalEats.EatenCount = SavedEats;

            SavedMoneys = PlayerPrefs.GetInt("SavedMoney");
            GlobalMoney.MoneyCount = SavedMoneys;


            SavedTrickorTreaters = PlayerPrefs.GetInt("SavedTrickorTreaters");
            GlobalTrickorTreater.TrickorTreatersSec = SavedTrickorTreaters;
            SavedTrickorTreaterCount = PlayerPrefs.GetInt("SavedTrickorTreatersCount");
            GlobalTrickorTreater.numberOfTrickOrTreaters = SavedTrickorTreaterCount;
            SavedTrickorTreaterValue = PlayerPrefs.GetInt("SavedTrickorTreatersValue");
            GlobalTrickorTreater.trickOrTreaterValue = SavedTrickorTreaterValue;

            SavedHyperTeenager = PlayerPrefs.GetInt("SavedHyperTeenager");
            GlobalHyperTeenager.HyperTeenagersSec = SavedHyperTeenager;
            SavedHyperTeenagerCount = PlayerPrefs.GetInt("SavedHyperTeenagersCount");
            GlobalHyperTeenager.numberOfHyperTeenagers = SavedHyperTeenagerCount;
            SavedHyperTeenagerValue = PlayerPrefs.GetInt("SavedHyperTeenagersValue");
            GlobalHyperTeenager.HyperTeenagerValue = SavedHyperTeenagerValue;

            SavedAskGrandma = PlayerPrefs.GetInt("SavedAskGrandma");
            GlobalAskGrandma.AskGrandmasSec = SavedAskGrandma;
            SavedAskGrandmaCount = PlayerPrefs.GetInt("SavedAskGrandmasCount");
            GlobalAskGrandma.numberOfAskGrandmas = SavedAskGrandmaCount;
            SavedAskGrandmaValue = PlayerPrefs.GetInt("SavedAskGrandmasValue");
            GlobalAskGrandma.AskGrandmaValue = SavedAskGrandmaValue;

            SavedCandyStand = PlayerPrefs.GetInt("SavedCandyStand");
            GlobalCandyStand.CandyStandSec = SavedCandyStand;
            SavedCandyStandCount = PlayerPrefs.GetInt("SavedCandyStandsCount");
            GlobalCandyStand.numberOfCandyStands = SavedCandyStandCount;
            SavedCandyStandValue = PlayerPrefs.GetInt("SavedCandyStandsValue");
            GlobalCandyStand.CandyStandValue = SavedCandyStandValue;

            SavedCarnivalBooth = PlayerPrefs.GetInt("SavedCarnivalBooth");
            GlobalCarnivalBooth.CarnivalBoothSec = SavedCarnivalBooth;
            SavedCarnivalBoothCount = PlayerPrefs.GetInt("SavedCarnivalBoothsCount");
            GlobalCarnivalBooth.numberOfCarnivalBooth = SavedCarnivalBoothCount;
            SavedCarnivalBoothValue = PlayerPrefs.GetInt("SavedCarnivalBoothsValue");
            GlobalCarnivalBooth.CarnivalBoothValue = SavedCarnivalBoothValue;

            SavedCandyStore = PlayerPrefs.GetInt("SavedCandyStore");
            GlobalCandyStore.CandyStoreSec = SavedCandyStore;
            SavedCandyStoreCount = PlayerPrefs.GetInt("SavedCandyStoresCount");
            GlobalCandyStore.numberOfCandyStores = SavedCandyStoreCount;
            SavedCandyStoreValue = PlayerPrefs.GetInt("SavedCandyStoresValue");
            GlobalCandyStore.CandyStoreValue = SavedCandyStoreValue;

            SavedCandyWarehouse = PlayerPrefs.GetInt("SavedCandyWarehouse");
            GlobalCandyWarehouse.CandyWarehouseSec = SavedCandyWarehouse;
            SavedCandyWarehouseCount = PlayerPrefs.GetInt("SavedCandyWarehousesCount");
            GlobalCandyWarehouse.numberOfCandyWarehouses = SavedCandyWarehouseCount;
            SavedCandyWarehouseValue = PlayerPrefs.GetInt("SavedCandyWarehousesValue");
            GlobalCandyWarehouse.CandyWarehouseValue = SavedCandyWarehouseValue;

            SavedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = SavedValue;

            AutoCandy.CreatingCandy = false;
            AutoCandyHyperTeenager.CreatingCandy = false;
            AutoCandyAskGrandma.CreatingCandy = false;

            AutoSell.SellingCandy = false;
            AutoSellCarnivalBooth.SellingCandy = false;
            AutoSellCandyStore.SellingCandy = false;
            AutoSellCandyWarehouse.SellingCandy = false;
        }
    }
}
