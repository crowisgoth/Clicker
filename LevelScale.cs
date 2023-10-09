using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScale : MonoBehaviour
{
    MoneyPerSecond _moneyPerMin;
    [SerializeField] static public int exp;
    [SerializeField] static int level = 1 ;
    [SerializeField] double border = 1.5;

    private void Start()
    {
        _moneyPerMin = GetComponent<MoneyPerSecond>();
    }



    // Update is called once per frame
    void Update()
    {
       if(exp == 5)
        {
            level += 1;
            exp = 0;
            LevelSwitch();
        } 
       if (level > 20) 
        {
            level = 20; //Сделай потом уведомление о том что макс уровень
        }
    }
    void LevelSwitch()
    {

        MoneyPerSecond.MoneyPerMin = MoneyPerSecond.MoneyPerMin * border;



    }
    
}
