using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreatePrefab : MonoBehaviour
{
    [SerializeField] public TMP_InputField inputFieldText;
    [SerializeField] float ShowTime = 20;
     private float _showTime ;
    [SerializeField] TMP_Text TimeText;
    [SerializeField] public  double inputChar;

    private void OnEnable()
    {
        GameObject zxc = GameObject.FindWithTag("Parent");
        inputFieldText = zxc.GetComponent<TMP_InputField>();
        TimeText = GetComponentInChildren<TMP_Text>();
        inputChar = double.Parse(inputFieldText.text);
        _showTime = ShowTime;
    }

    private void Update()
    {
       
            _showTime -= Time.deltaTime;

            TimeText.text = _showTime.ToString();
            if (_showTime <= 0)
            {
                ClickEarn._currentMoney += (20 * inputChar) / 100 + inputChar;

                TimeText.text = "0";
                Destroy(this.gameObject);
            }
        
    }
}
