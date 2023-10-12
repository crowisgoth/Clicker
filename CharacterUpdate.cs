using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUpdate : MonoBehaviour
{
    [SerializeField] Button UpdateClickbutton;
    [SerializeField] public bool click = true;
    [SerializeField] Button ClickButton;
    UpgradeClick upgradeClick;
    public double oldValue= 0;
    private void Start()
    {
        upgradeClick = GetComponent<UpgradeClick>();
    }
    public IEnumerator Corutine()
    {
        if (click) 
        {
            oldValue = upgradeClick.baseValue;
            click = false;
            upgradeClick.baseValue += upgradeClick.baseValue;
            ClickButton.interactable = false;
            yield return new WaitForSeconds(30);
            upgradeClick.baseValue = oldValue;
            click = true;
            yield return new WaitForSeconds(60);
            ClickButton.interactable = true;
        }
    }


    public void StarCorut()
    {
        StartCoroutine(Corutine());
    }
}
