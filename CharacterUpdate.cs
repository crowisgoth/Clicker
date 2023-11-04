using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUpdate : MonoBehaviour
{
    [SerializeField] Button UpdateClickbutton;
    
    [SerializeField] Button ClickButton;
    UpgradeClick upgradeClick;
    private void Start()
    {
        upgradeClick = GetComponent<UpgradeClick>();
        
    }
    public IEnumerator Corutine()
    {
        
        if (Values.bonusDoubleClickActive) 
        {
            Values.oldValueMoneyClick = Values.moneyForClick;
            Values.bonusDoubleClickActive = false;
            Values.moneyForClick += Values.moneyForClick;
            ClickButton.interactable = false;
            yield return new WaitForSeconds(30);
            Values.moneyForClick = Values.oldValueMoneyClick;
            Values.bonusDoubleClickActive = true;
            yield return new WaitForSeconds(60);
            ClickButton.interactable = true;
        }
    }


    public void StarCorut()
    {
        StartCoroutine(Corutine());
    }
}
