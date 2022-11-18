using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Cherry : Flower
{

    [SerializeField]
    BasketManager _basketManager;

    public TextMeshProUGUI text;
    public Cherry()
    {
        FlowerName = "Cherry";
        Info = "Kiraz";
        GrowingTime = 30;
        Price = 15;
    }
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        BasketManager _basketManager = GetComponent<BasketManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        text.text = "Çiçeðin Adý: " + FlowerName + "\n\n" + "Bilgi: " + Info + "\n\n" + "Büyüme Süresi: " + GrowingTime + " Saat" + "\n\n" + "Fiyatý: " + Price + "TL";
    }
    private GameObject CreateFlower()
    {
        GameObject cherry = new GameObject(FlowerName);
        cherry.AddComponent<Cherry>();
        return cherry;
    }
    private void OnMouseDown()
    {
        _basketManager.AddBasket(CreateFlower());
    }
}
