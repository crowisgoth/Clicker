using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using TMPro;

public class MoneyPerSecond : MonoBehaviour
{
    ClickEarn money;
    [SerializeField] TMP_Text MPMText;
    static public int MoneyPerMin = 30;
    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<ClickEarn>();
        StartCoroutine(Curotine());
        
        
    }

    // Update is called once per frame
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
