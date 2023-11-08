using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    [SerializeField] int priceForProducts = 1000;
    [SerializeField] int productsForBuy = 0;
    [SerializeField] int storageMax = 250;
    
    TMP_Text productCountText;
    [SerializeField] Text storageText;
   
    
    public void BuyProducts()
    {
        if (Values._myCurrentMoney >= priceForProducts && Values.productCount <= storageMax)
        {
            if (Values.productCount + 50 >= storageMax + 1  )
            {
                Debug.Log("достигнут максимальный объем склада");
                return;
            }
            Values.Save();
            Values._myCurrentMoney -= priceForProducts;
            Values.productCount += 50;
            
        }
        else Debug.Log("недостаточно денег");
    }
    public IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            if (Values.productCount > 0)
            {
                Values.productCount -= 1;
                Values._myCurrentMoney += 30;
                Values.Save();
                
            }
            
        }
        

    }
    public void Start()
    {
        productCountText = GetComponentInChildren<TMP_Text>();
        StartCoroutine(Timer());
        ChangeStorageText();
    }
    public void ChangeStorageText()
    {
        storageText.text = "Размер склада - " + storageMax ;
    }
    public void Update()
    {
        productCountText.text = "Продуктов в наличии: " + Values.productCount;
    }
}
