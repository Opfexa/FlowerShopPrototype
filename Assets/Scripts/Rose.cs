using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Rose : Flower
{
    [SerializeField]
    BasketManager _basketManager;

    public TextMeshProUGUI text;
    public Rose()
    {
        FlowerName = "Rose";
        Info = "Gül";
        GrowingTime = 30;
        Price = 17;
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
        GameObject rose = new GameObject(FlowerName);
        rose.AddComponent<Rose>();
        return rose;
    }
    private void OnMouseDown()
    {
        _basketManager.AddBasket(CreateFlower());
    }
}
