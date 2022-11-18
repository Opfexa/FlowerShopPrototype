using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    BasketManager _basketManager;

    [SerializeField]
    private TextMeshProUGUI moneyText;

    public float money;
    private float price;
    public ShopManager(BasketManager basketManager)
    {
        _basketManager = basketManager;
    }
    private void Awake()
    {
        BasketManager _basketManager = GetComponent<BasketManager>();
        TextMeshProUGUI moneyText = GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Paranýz: " + money;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
        if (money >= _basketManager.totalPrice)
        {
            price = _basketManager.totalPrice;
            money = money - price;
            _basketManager.pieceCherry = 0;
            _basketManager.pieceRose = 0;
            _basketManager.pieceDiasy = 0;
            _basketManager.totalPrice = 0;
            _basketManager.cherryText.text = string.Empty;
            _basketManager.daisyText.text = string.Empty;
            _basketManager.roseText.text = string.Empty;
            moneyText.text = "Paranýz: " + money;
            Debug.Log(money + " Bu kadar paran kaldý." + price + " Bu kadar harcadýn.");
        }
        else
        {
            Debug.Log("Fakirsin alamazsýn.");
        }
    }
}
