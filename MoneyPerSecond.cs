using System.Collections;
using UnityEngine;
using TMPro;

public class MoneyPerSecond : MonoBehaviour
{
    ClickEarn money;
    [SerializeField] TMP_Text MPMText;
    static public int MoneyPerMin = 30;
    void Start()
    {
        money = GetComponent<ClickEarn>();
        StartCoroutine(Curotine()); 
    }
    void Update()
    {
        MPMText.text = "В минуту вы получаете " + MoneyPerMin; 
    }
    private IEnumerator Curotine()
    {
        while (true)
        {
            yield return new WaitForSeconds(60);
            addMoney();  
        }
    }
    private void addMoney()
    {
        ClickEarn._currentMoney += MoneyPerMin;
        money.CurrentMoney.text = ClickEarn._currentMoney.ToString();
    }

}
