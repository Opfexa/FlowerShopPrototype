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
        moneyText.text = "Paran�z: " + money;
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
            moneyText.text = "Paran�z: " + money;
            Debug.Log(money + " Bu kadar paran kald�." + price + " Bu kadar harcad�n.");
        }
        else
        {
            Debug.Log("Fakirsin alamazs�n.");
        }
    }
}
