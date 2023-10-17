using UnityEngine;
using UnityEngine.UI;

public class ClickEarn : MonoBehaviour
{
    UpgradeClick clickup;
    public LevelScale lvl;
    public Text CurrentMoney;
    [SerializeField] Text moneyShow;
    public static double _currentMoney;

    void Start()
    {
        CurrentMoney.text = _currentMoney.ToString("F" + 1);
        clickup = GetComponent<UpgradeClick>();
        lvl = GetComponent<LevelScale>();
    }

    public void IsClick()
    {
        
        
        _currentMoney += (double)clickup.baseValue;
        LevelScale.exp += 1;
        CurrentMoney.text = _currentMoney.ToString("F" + 1);

    }
    private void Update()
    {
        moneyShow.text = clickup.baseValue.ToString() + " За клик";
        CurrentMoney.text = _currentMoney.ToString("F" + 2);
    }
}
