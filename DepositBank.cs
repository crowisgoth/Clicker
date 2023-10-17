
using UnityEngine;
using TMPro;



public class DepositBank : MonoBehaviour
{
    
    [SerializeField] public GameObject prefab;
    TMP_InputField inputFieldText;
    [SerializeField] int inputChar;

    
    private void Start()
    {
        inputFieldText = GetComponentInChildren<TMP_InputField>();

        GameObject zxc = GameObject.FindWithTag("Parent");
    }
    

    public void SetDeposit()
    {

        inputChar = int.Parse(inputFieldText.text);
        if (ClickEarn._currentMoney >= inputChar)
        {
            
            Instantiate(prefab, transform);
            ClickEarn._currentMoney -= inputChar;

        }
        else Debug.Log("Недостаточно денег");
        }
    

}
