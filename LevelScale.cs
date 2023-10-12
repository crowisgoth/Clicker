using UnityEngine;

public class LevelScale : MonoBehaviour
{
    MoneyPerSecond _moneyPerMin;
    [SerializeField] static public int exp;
    [SerializeField] static int level ;

    private void Start()
    {
        _moneyPerMin = GetComponent<MoneyPerSecond>();
    }
    void Update()
    {
       if(exp == 500)
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
        switch (level)
        {
            case 1: MoneyPerSecond.MoneyPerMin = 30;
                break;
            case 2:
                MoneyPerSecond.MoneyPerMin = 40;
                break;
            case 3:
                MoneyPerSecond.MoneyPerMin = 50;
                break;
            case 4:
                MoneyPerSecond.MoneyPerMin = 60;
                break;
            case 5:
                MoneyPerSecond.MoneyPerMin = 70;
                break;
            case 6:
                MoneyPerSecond.MoneyPerMin = 80;
                break;
            case 7:
                MoneyPerSecond.MoneyPerMin = 90;
                break;
            case 8:
                MoneyPerSecond.MoneyPerMin = 95;
                break;
            case 9: MoneyPerSecond.MoneyPerMin = 100;
                break;
            case 10:
                MoneyPerSecond.MoneyPerMin = 150;
                break;

                
        }
    }
}
