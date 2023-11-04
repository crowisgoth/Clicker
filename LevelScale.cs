using UnityEngine;

public class LevelScale : MonoBehaviour
{
   
    

    private void Start()
    {
        
    }
    void Update()
    {
       if(Values.exp == 500)
        {
            
            Values.level += 1;
            Values.exp = 0;
            LevelSwitch();
            Values.Save();
        } 
       if (Values.level > 20) 
        {
            Values.level = 20; //Сделай потом уведомление о том что макс уровень
        }
    }
    void LevelSwitch()
    {
        switch (Values.level)
        {
            case 1:
                Values.moneyPerMin = 30;
                
                break;
            case 2:
                Values.moneyPerMin = 40;
                break;
            case 3:
                Values.moneyPerMin = 50;
                break;
            case 4:
                Values.moneyPerMin = 60;
                break;
            case 5:
                Values.moneyPerMin = 70;
                break;
            case 6:
                Values.moneyPerMin = 80;
                break;
            case 7:
                Values.moneyPerMin = 90;
                break;
            case 8:
                Values.moneyPerMin = 95;
                break;
            case 9:
                Values.moneyPerMin = 100;
                break;
            case 10:
                Values.moneyPerMin = 150;
                break;

                
        }
    }
}
