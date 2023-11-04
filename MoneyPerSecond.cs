using System.Collections;
using UnityEngine;
using TMPro;

public class MoneyPerSecond : MonoBehaviour
{
    
    [SerializeField] TMP_Text MPMText;
    ClickEarn money;
    void Start()
    {
        money = GetComponent<ClickEarn>();
        StartCoroutine(Curotine()); 
    }
    void Update()
    {
        MPMText.text = "В минуту вы получаете " + Values.moneyPerMin; 
    }
    private IEnumerator Curotine()
    {
        while (true)
        {
            yield return new WaitForSeconds(60);
            addMoney();
            Values.Save();

        }
    }
    private void addMoney()
    {
        Values._myCurrentMoney += Values.moneyPerMin;
        money.CurrentMoney.text = Values._myCurrentMoney.ToString();
    }

}
