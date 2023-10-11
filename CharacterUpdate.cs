using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUpdate : MonoBehaviour
{
    [SerializeField] Button UpdateClickbutton;
    // Start is called before the first frame update
    [SerializeField] public bool click = true;
    [SerializeField] Button ClickButton;
    public double oldValue= 0;
    UpgradeClick upgradeClick;
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

    // Update is called once per frame
    public void StarCorut()
    {
        StartCoroutine(Corutine());
    }
}
