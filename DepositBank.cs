
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
        if (Values._myCurrentMoney >= inputChar && inputChar >= 10)
        {
            Values.Save();
            Instantiate(prefab, transform);
            Values._myCurrentMoney -= inputChar;

        }
        else Debug.Log("Минимальная сумма для вклада 10$");
        }
    

}
