using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBuyngBuisnes : MonoBehaviour
{
    ClickEarn money;
    [SerializeField] GameObject Buyisnes;
    [SerializeField] double costBuyisnes;
    [SerializeField] string nameBuyisnes;
    [SerializeField] TMP_Text text;
    [SerializeField] int passiveSalary;
    int maxValue = 10;
    int currentValue;
    public void Buying()
    {
        if(currentValue < maxValue && ClickEarn._currentMoney >= costBuyisnes)
        {
            ClickEarn._currentMoney = ClickEarn._currentMoney - costBuyisnes;
            MoneyPerSecond.MoneyPerMin += passiveSalary;
        }
        
    }
    private void Start()
    {
        money = GetComponent<ClickEarn>();
        text = GetComponentInChildren<TMP_Text>();
        text.text = nameBuyisnes + costBuyisnes;
    }
}
