using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaleForClick : MonoBehaviour
{
    BuyingABuisnes aBuisnes;
    UpgradeClick upClick;
    UpgradeClick upCost;
    [SerializeField] Button UpButton;
    [SerializeField] Button ClickButton;
    double SaleCost = 0;
    double oldUpgradeCost = 0.0;
    bool active;
    double[] oldPricesOfBuisnes = new double[6];
    // Start is called before the first frame update
    private void Start()
    {
        upClick = GetComponent<UpgradeClick>();
        aBuisnes = GetComponent<BuyingABuisnes>();
        upCost = GetComponent<UpgradeClick>();
    }
        public void SalePrice()
    {
        SaleCost += 1.0;
        
        
    }
  
    IEnumerator startSale()
    {
        UpButton.interactable = false;
        ClickButton.interactable = true;
;        yield return new WaitForSeconds(30);
        ClickButton.interactable = false;
        oldUpgradeCost = UpgradeClick.upgradeCost;
        if (UpgradeClick.upgradeCost < SaleCost)
        {
            UpgradeClick.upgradeCost = 0;
        }
            else 
                { UpgradeClick.upgradeCost = UpgradeClick.upgradeCost - SaleCost; }
        //for (int i = 0; i< 5; i++)
        //{

        //    aBuisnes.PriceMoney[i] = aBuisnes.PriceMoney[i] - 1;
        //    Debug.Log("Заходит v 1");
        //}
        //for(int i = 0; i < 5; i++)
        //{

        //    aBuisnes.PriceMoney[i] = aBuisnes.PriceMoney[i] - SaleCost;
        //    Debug.Log("Заходит v 2");
        //}

        //for(int i = 0; i < 5; i++)
        //{
        //    aBuisnes.PriceMoney[i] = oldPricesOfBuisnes[i];
        //}
        yield return new WaitForSeconds(18000);
        //UpgradeClick.upgradeCost = oldUpgradeCost;
        UpButton.interactable = true;
    }
   public void test()
    {
        StartCoroutine(startSale());
        
    }
      
}
