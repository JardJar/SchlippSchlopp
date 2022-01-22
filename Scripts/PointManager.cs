using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager Instance; 
    private void Awake()
    {
        Instance = this;
    }
    public int PriceUpgradeAmount(int x)
    {
        return x*x*x*x;
    }

    private int points = 0;
    private int currentPointAdd = 0;
    public int multiplier = 1;
    public int amount = 1;
    private int currentUpgradeAmount = 1;
    private int currentMultiplierAmount = 1;
    private int currentUpgradePrice = 1;
    private int currentMultiplierPrice = 1;
    private int rand;
    private int schlopp = 0;
    private string type = "Schlipp\n ";
    public void AddPoints()
    {
        rand = Random.Range(0, 1000);
        print(rand);
        if (rand > 900)
        {
            schlopp++;
            type = "\nSchlopp";
        }
        else
        {
            type = "Schlipp\n ";
        }
        currentPointAdd = amount * multiplier;
        points += currentPointAdd;
        UpdateText(type);
    }
    public void UpgradeAmount()
    {
        if (PriceUpgradeAmount(currentUpgradeAmount) <= points)
        {
            currentUpgradeAmount++;
            points -= currentUpgradePrice;
            currentUpgradePrice = PriceUpgradeAmount(currentUpgradeAmount);
            amount++;
            currentPointAdd = amount * multiplier;
            UpdateText(type);
            TextManager.tm.UpdateUpgradeText(currentUpgradePrice.ToString(), currentMultiplierPrice.ToString());
        }
    }
    public void UpgradeMultiplier()
    {
        if (PriceUpgradeAmount(currentMultiplierAmount) <= points) {
            currentMultiplierAmount++;
            points -= currentMultiplierPrice;
            currentMultiplierPrice = PriceUpgradeAmount(currentMultiplierAmount);
            multiplier++;
            currentPointAdd = amount * multiplier;
            UpdateText(type);
            TextManager.tm.UpdateUpgradeText(currentUpgradePrice.ToString(), currentMultiplierPrice.ToString());
        }
    }
    private void UpdateText(string schloppsschlipps)
    {   
        TextManager.tm.SetText("" + points, "" + currentPointAdd, ""+schlopp, ""+schloppsschlipps);
    }

    public int GetPoints()
    {
        return points;
    }

}