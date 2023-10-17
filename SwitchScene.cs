using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] GameObject mainScene;
    [SerializeField] GameObject buisnesScene;
    [SerializeField] GameObject characterScene;
    [SerializeField] GameObject BankDeposit;
    // Start is called before the first frame update
   public void ToMain()
    {
        buisnesScene.SetActive(false);
        mainScene.SetActive(true);
        characterScene.SetActive(false);
        BankDeposit.SetActive(false);
    }
    public void ToBuisnes()
    {
        buisnesScene.SetActive(true);
        mainScene.SetActive(false);
        characterScene.SetActive(false);
        BankDeposit.SetActive(false);
    }
    public void ToChar()
    {
        buisnesScene.SetActive(false);
        mainScene.SetActive(false);
        characterScene.SetActive(true);
        BankDeposit.SetActive(false);
    }
    public void ToBankDeposit()
    {
        buisnesScene.SetActive(false);
        mainScene.SetActive(false);
        characterScene.SetActive(false);
        BankDeposit.SetActive(true) ;
    }
}
