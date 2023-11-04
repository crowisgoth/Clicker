using UnityEngine;
using UnityEngine.UI;

public class ClickEarn : MonoBehaviour
{
    UpgradeClick clickup;
    
    public Text CurrentMoney;
    [SerializeField] Text moneyShow;
    bool firstLoad = true;
    void Start()
    {
        
        CurrentMoney.text = Values._myCurrentMoney.ToString("F" + 1);
  
    }
    private void Awake()
    {
        Values.Load();
    }

    public void IsClick()
    {


        Values._myCurrentMoney += (float)Values.moneyForClick;
        Values.exp += 1;
        CurrentMoney.text = Values._myCurrentMoney.ToString("F" + 1);
        Values.Save();

    }
    private void Update()
    {
        moneyShow.text = Values.moneyForClick.ToString() + " За клик";
        CurrentMoney.text = Values._myCurrentMoney.ToString("F" + 2);
    }
}
