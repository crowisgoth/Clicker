using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] GameObject mainScene;
    [SerializeField] GameObject buisnesScene;
    [SerializeField] GameObject characterScene;
    [SerializeField] GameObject BankDeposit;
    [SerializeField] GameObject ShopBuisnes;
    Canvas shop;
    Canvas bankDeposit;
    private void Start()
    {
        bankDeposit = BankDeposit.GetComponent<Canvas>();
        shop = ShopBuisnes.GetComponentInChildren<Canvas>();
    }
    // Start is called before the first frame update
    public void ToMain()
    {
        buisnesScene.SetActive(false);
        mainScene.SetActive(true);
        characterScene.SetActive(false);
        shop.sortingOrder = -1;
        bankDeposit.sortingOrder = -1;
    }
    public void ToBuisnes()
    {
        buisnesScene.SetActive(true);
        mainScene.SetActive(false);
        characterScene.SetActive(false);
        shop.sortingOrder = -1;
        bankDeposit.sortingOrder = -1;
    }
    public void ToChar()
    {
        buisnesScene.SetActive(false);
        mainScene.SetActive(false);
        characterScene.SetActive(true);
        bankDeposit.sortingOrder = -1;
        shop.sortingOrder = -1;
    }
    public void ToBankDeposit()
    {
        buisnesScene.SetActive(false);
        mainScene.SetActive(false);
        characterScene.SetActive(false);
        bankDeposit.sortingOrder = 1;
        shop.sortingOrder = -1;
    }
    public void ToShopBuisnes()
    {
        buisnesScene.SetActive(false);
        mainScene.SetActive(false);
        characterScene.SetActive(false);
        shop.sortingOrder = 1;
    }
}
