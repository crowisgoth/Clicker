using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreatePrefab : MonoBehaviour
{
    [SerializeField] public TMP_InputField inputFieldText;
    [SerializeField] float ShowTime = 20;
     private float _showTime;
    [SerializeField] TMP_Text TimeText;
    [SerializeField] public  float inputChar;
    
    Text text;

    private void OnEnable()
    {
        
        text = GetComponentInChildren<Text>();
        GameObject zxc = GameObject.FindWithTag("Parent");
        inputFieldText = zxc.GetComponent<TMP_InputField>();
        TimeText = GetComponentInChildren<TMP_Text>();
        inputChar = float.Parse(inputFieldText.text);
        float money = (20 * inputChar) / 100 + inputChar;
        text.text = money.ToString();
        _showTime = ShowTime;
    }
    private void Update()
    {
        
            _showTime -= Time.deltaTime;
            TimeText.text = _showTime.ToString("F" + 0);
            if (_showTime <= 0)
            {
                Values._myCurrentMoney += (20 * inputChar) / 100 + inputChar;

                TimeText.text = "0";
                Destroy(this.gameObject);
            }
        
    }
}
