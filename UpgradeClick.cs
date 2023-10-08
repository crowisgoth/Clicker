using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class UpgradeClick : MonoBehaviour
{
    ClickEarn cl;
    public int upgcost;


    [SerializeField]  public double baseValue = 1.0;
    static public double upgradeFactor = 0.1;
     static public double baseCost = 10.0;
    static double upgradeNumber;
    static public double upgradeCost = 10;
    static double clickValue;
     public TMP_Text upgCost;
    
    // Start is called before the first frame update
    void Start()
    {
        cl = GetComponent<ClickEarn>();
        
    }

    
    public void Upgrade()
     {
        
            
            upgradeCost = baseCost * Math.Pow(1 + upgradeFactor, upgradeNumber);
            clickValue = baseValue * Math.Pow(1 + upgradeFactor, upgradeNumber);
           
            if (ClickEarn._currentMoney >= (int)upgradeCost)
            {
                upgradeNumber = Math.Floor((double)ClickEarn._currentMoney / baseCost) + 1;
                ClickEarn._currentMoney -= (int)upgradeCost;
                baseValue = clickValue;
                baseCost = upgradeCost;
                cl.CurrentMoney.text = ClickEarn._currentMoney.ToString("F" + 1);
            }

        
    }
    void Update()
    {
        upgCost.text = "Улучшить клик за \n" + upgradeCost;
    }
}
