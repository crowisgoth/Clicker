//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;

//public class BuyingABuisnes : MonoBehaviour
//{
    
//    int maxValue = 10;
//    [SerializeField] public   double[] PriceMoney;
//    [SerializeField] TMP_Text[] PricesText;

//    private void Start()
//    {
        
//        //PricesText[0].text = "������ ����� ��" + PriceMoney[0];
//        //PricesText[1].text = "������ ���� ��" + PriceMoney[1];
//        //PricesText[2].text = "������ ���� ��" + PriceMoney[2];
//        //PricesText[3].text = "������ ������������ ���� ��" + PriceMoney[3];
//        //PricesText[4].text = "������ �������� ��" + PriceMoney[4];
//        //PricesText[5].text = "������ ����� ��" + PriceMoney[5];
//    }
//    public void BuyAFarm()
//    {
//        int currentValue = 0;
//        if (currentValue<maxValue && ClickEarn._currentMoney >= PriceMoney[0]) 
//        {
            
//            MoneyPerSecond.MoneyPerMin += 30;
//            ClickEarn._currentMoney -= PriceMoney[0];
//            currentValue += 1;
            
//        }
//        else {
//            //������ ����� ���� ��� ������ ���������
//             }
//    }
//    public void BuyABank()
//    {
//        int currentValue = 0;
//        if (currentValue < maxValue && ClickEarn._currentMoney >= PriceMoney[1])
//        {

//            MoneyPerSecond.MoneyPerMin += 50;
//            ClickEarn._currentMoney -= PriceMoney[1];
//            currentValue += 1;

//        }
//        else
//        {
//            //������ ����� ���� ��� ������ ���������
//        }
//    }
//    public void BuyACaffe()
//    {
//        int currentValue = 0;
//        if (currentValue < maxValue && ClickEarn._currentMoney >= PriceMoney[2])
//        {

//            MoneyPerSecond.MoneyPerMin += 70;
//            ClickEarn._currentMoney -= PriceMoney[2];
//            currentValue += 1;

//        }
//        else
//        {
//            //������ ����� ���� ��� ������ ���������
//        }
//    }
//    public void BuyAComputer()
//    {
//        int currentValue = 0;
//        if (currentValue < maxValue && ClickEarn._currentMoney >= PriceMoney[3])
//        {

//            MoneyPerSecond.MoneyPerMin += 100;
//            ClickEarn._currentMoney -= PriceMoney[3];
//            currentValue += 1;

//        }
//        else
//        {
//            //������ ����� ���� ��� ������ ���������
//        }
//    }
//    public void BuyAFood()
//    {
//        int currentValue = 0;
//        if (currentValue < maxValue && ClickEarn._currentMoney >= PriceMoney[4])
//        {

//            MoneyPerSecond.MoneyPerMin += 130;
//            ClickEarn._currentMoney -= PriceMoney[4];
//            currentValue += 1;

//        }
//        else
//        {
//            //������ ����� ���� ��� ������ ���������
//        }
//    }
//    public void BuyAZavod()
//    {
//        int currentValue = 0;
//        if (currentValue < maxValue && ClickEarn._currentMoney >= PriceMoney[5])
//        {

//            MoneyPerSecond.MoneyPerMin += 150;
//            ClickEarn._currentMoney -= PriceMoney[5];
//            currentValue += 1;

//        }
//        else
//        {
//            //������ ����� ���� ��� ������ ���������
//        }
//    }


//}
