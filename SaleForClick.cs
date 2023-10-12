using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SaleForClick : MonoBehaviour
{
    
    [SerializeField] Button UpButton;
    [SerializeField] Button ClickButton;
    public double SaleCost = 0;
    public double oldUpgradeCost = 0.0;
    public bool active = false;
    
        public void SalePrice()
        {
            SaleCost += 1.0;
        }
  
    IEnumerator startSale()
    {
        if (active == false)
        {
            
            UpButton.interactable = false;
            ClickButton.interactable = true;
            
            yield return new WaitForSeconds(10);
            oldUpgradeCost = UpgradeClick.upgradeCost;
            active = true;
            ClickButton.interactable = false;
                if (UpgradeClick.upgradeCost < SaleCost)
                {
                    UpgradeClick.upgradeCost = 0;
                }
                    else
                        { UpgradeClick.upgradeCost = UpgradeClick.upgradeCost - SaleCost; }
            SaleCost = 0;
            yield return new WaitForSeconds(30);
            UpButton.interactable = true;
        }
       
    }
   public void StartSaleCorut()
    {
        StartCoroutine(startSale());
        
    }
      
}
