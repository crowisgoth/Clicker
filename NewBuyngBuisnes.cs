using TMPro;
using UnityEngine;

public class NewBuyngBuisnes : MonoBehaviour
{
    ClickEarn money;
    [SerializeField] GameObject Buyisnes;
    [SerializeField] float costBuyisnes;
    [SerializeField] string nameBuyisnes;
    [SerializeField] TMP_Text text;
    [SerializeField] int passiveSalary;
    
    public void Buying()
    {
        
        if (Values.currentCountOfBuisneses < Values.buisnesesMaxCount && Values._myCurrentMoney >= costBuyisnes)
        {
            Values._myCurrentMoney = Values._myCurrentMoney - costBuyisnes;
            Values.moneyPerMin += passiveSalary;
        }
        
    }
    private void Start()
    {
        money = GetComponent<ClickEarn>();
        text = GetComponentInChildren<TMP_Text>();
        text.text = nameBuyisnes + costBuyisnes;
    }
}
