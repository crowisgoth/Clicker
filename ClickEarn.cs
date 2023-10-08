using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ClickEarn : MonoBehaviour
{
    UpgradeClick clickup;
    public LevelScale lvl;
    public Text CurrentMoney;
    public static double _currentMoney;
   
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentMoney.text = _currentMoney.ToString("F" + 1);
        clickup = GetComponent<UpgradeClick>();
        lvl = GetComponent<LevelScale>();
    }

    // Update is called once per frame
    public void IsClick()
    {
        
        
        _currentMoney += (double)clickup.baseValue;
        LevelScale.exp += 1;
        CurrentMoney.text = _currentMoney.ToString("F" + 1);

    }
    private void Update()
    {
        CurrentMoney.text = _currentMoney.ToString("F" + 1);
    }
}
