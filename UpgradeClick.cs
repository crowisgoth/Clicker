using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class UpgradeClick : MonoBehaviour
{
    ClickEarn cl;
    SaleForClick sale;
    CharacterUpdate charUp;
    public int upgcost;


    [SerializeField]  public double baseValue = 1.0;
    static public double upgradeFactor = 0.1;
     static public double baseCost = 10.0;
    static public double baseCostSecond = 10.0;
    static double upgradeNumber;
    static public double upgradeCost = 10;
    static double clickValue;
     public TMP_Text upgCost;
    
    // Start is called before the first frame update
    void Start()
    {
        sale = GetComponent<SaleForClick>();
        cl = GetComponent<ClickEarn>();
        charUp = GetComponent<CharacterUpdate>();
        upgradeCost += upgradeCost * 2;
        upgCost.text = "Улучшить клик за \n" + upgradeCost.ToString("F" + 0);
    }

    
    public void Upgrade()
     {
           
            if (ClickEarn._currentMoney >= (int)upgradeCost)
            {
            if (charUp.click == false && sale.active == false)
            {
                charUp.oldValue = charUp.oldValue * 2;
                ClickEarn._currentMoney = ClickEarn._currentMoney - upgradeCost;

                cl.CurrentMoney.text = ClickEarn._currentMoney.ToString("F" + 0);
                upgradeCost += upgradeCost * 2;
            }
                   else if (sale.active == false && charUp.click == true) 
                    {
                        ClickEarn._currentMoney = ClickEarn._currentMoney - upgradeCost;
                        baseValue = baseValue * 2;
                        cl.CurrentMoney.text = ClickEarn._currentMoney.ToString("F" + 0);
                        upgradeCost += upgradeCost * 2;
                    }
                if(sale.active == true)
                {
                    ClickEarn._currentMoney = ClickEarn._currentMoney - upgradeCost;
                    charUp.oldValue = charUp.oldValue * 2;
                    cl.CurrentMoney.text = ClickEarn._currentMoney.ToString("F" + 0);
                    upgradeCost = sale.oldUpgradeCost * 3;
                    sale.active = false;
                }
                
            }

        
    }
    void Update()
    {
        upgCost.text = "Улучшить клик за \n" + upgradeCost.ToString("F" + 0);

    }
}
