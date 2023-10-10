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
        upgradeCost += upgradeCost * 2;
        upgCost.text = "Улучшить клик за \n" + upgradeCost.ToString("F" + 0);
    }

    
    public void Upgrade()
     {
            
            if (ClickEarn._currentMoney >= (int)upgradeCost)
            {
                ClickEarn._currentMoney = ClickEarn._currentMoney - upgradeCost;   
                baseValue = baseValue*2;
                
                cl.CurrentMoney.text = ClickEarn._currentMoney.ToString("F" + 0);
                upgradeCost += upgradeCost *2 ;
                upgCost.text = "Улучшить клик за \n" + upgradeCost.ToString("F" + 0);
        }

        
    }
    void Update()
    {

        
    }
}
