using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SaleForClick : MonoBehaviour
{
    
    [SerializeField] Button UpButton;
    [SerializeField] Button ClickButton;
    
    
        public void SalePrice()
        {
            Values.bonusSaleClickedCount += 1.0f;
        }
  
    IEnumerator startSale()
    {
        if (Values.bonusSaleClickActive == false)
        {
            
            UpButton.interactable = false;
            ClickButton.interactable = true;
            
            yield return new WaitForSeconds(10);
            Values.oldUpgradeCost = Values.upgradeCost;
            Values.bonusSaleClickActive = true;
            ClickButton.interactable = false;
                if (Values.upgradeCost < Values.bonusSaleClickedCount)
                {
                Values.upgradeCost = 0;
                }
                    else
                        { Values.upgradeCost = Values.upgradeCost - Values.bonusSaleClickedCount; }
            Values.bonusSaleClickedCount = 0;
            yield return new WaitForSeconds(30);
            UpButton.interactable = true;
        }
       
    }
   public void StartSaleCorut()
    {
        StartCoroutine(startSale());
        
    }
      
}
