using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] bool click = true;
    [SerializeField] Button ClickButton;
    double oldValue= 0;
    UpgradeClick upgradeClick;
    private void Start()
    {
        upgradeClick = GetComponent<UpgradeClick>();
    }
    public IEnumerator Corutine()
    {
        if (click) 
        {
            Debug.Log("Hello");
            oldValue = upgradeClick.baseValue;
            click = false;
            upgradeClick.baseValue += upgradeClick.baseValue;
            ClickButton.interactable = false;
            yield return new WaitForSeconds(30);
            upgradeClick.baseValue = oldValue;
            yield return new WaitForSeconds(600);
            ClickButton.interactable = true;
            click = true;

        }
    }

    // Update is called once per frame
    public void StarCorut()
    {
        StartCoroutine(Corutine());
    }
}
