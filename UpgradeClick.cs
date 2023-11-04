
using UnityEngine;
using TMPro;

public class UpgradeClick : MonoBehaviour
{
    ClickEarn cl;
    SaleForClick sale;
    CharacterUpdate charUp;
    public TMP_Text upgCost;

    void Start()
    {
        sale = GetComponent<SaleForClick>();
        cl = GetComponent<ClickEarn>();
        charUp = GetComponent<CharacterUpdate>();
        Values.upgradeCost += Values.upgradeCost * 2;
        upgCost.text = "Улучшить клик за \n" + Values.upgradeCost.ToString("F" + 0);

    }

    
    public void Upgrade()
     {
           
            if (Values._myCurrentMoney >= (int)Values.upgradeCost)
            {
            if (Values.bonusDoubleClickActive == false && Values.bonusSaleClickActive == false)
            {
                Values.oldValueMoneyClick = Values.oldValueMoneyClick * 2;
                Values._myCurrentMoney = Values._myCurrentMoney - Values.upgradeCost;

                cl.CurrentMoney.text = Values._myCurrentMoney.ToString("F" + 0);
                Values.upgradeCost += Values.upgradeCost * 2;

            }
                   else if (Values.bonusSaleClickActive == false && Values.bonusDoubleClickActive == true) 
                    {
                        Values._myCurrentMoney = Values._myCurrentMoney - Values.upgradeCost;
                        Values.moneyForClick = Values.moneyForClick * 2;
                        cl.CurrentMoney.text = Values._myCurrentMoney.ToString("F" + 0);
                        Values.upgradeCost += Values.upgradeCost * 2;
                    }
                if(Values.bonusSaleClickActive == true)
                {
                    Values._myCurrentMoney = Values._myCurrentMoney - Values.upgradeCost;
                    Values.oldValueMoneyClick = Values.oldValueMoneyClick * 2;
                    cl.CurrentMoney.text = Values._myCurrentMoney.ToString("F" + 0);
                    Values.upgradeCost = Values.oldUpgradeCost * 3 + Values.bonusSaleClickedCount;
                    Values.bonusSaleClickActive = false;
                }
                
            }
        Values.Save();

    }
    void Update()
    {
        upgCost.text = "Улучшить клик за \n" + Values.upgradeCost.ToString("F" + 0);

    }
}
