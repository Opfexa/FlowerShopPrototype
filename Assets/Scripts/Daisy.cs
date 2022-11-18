using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Daisy : Flower
{

    [SerializeField]
    BasketManager _basketManager;

    public TextMeshProUGUI text;
    public Daisy()
    {
        FlowerName = "Daisy";
        Info = "�i�ek i�te";
        GrowingTime = 30;
        Price = 10;
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
        text.text = "�i�e�in Ad�: " + FlowerName + "\n\n" + "Bilgi: " + Info + "\n\n" + "B�y�me S�resi: " + GrowingTime + " Saat" + "\n\n" + "Fiyat�: " + Price + "TL";
    }
    private GameObject CreateFlower()
    {
        GameObject daisy = new GameObject(FlowerName);
        daisy.AddComponent<Daisy>();
        return daisy;
    }
    private void OnMouseDown()
    {
        _basketManager.AddBasket(CreateFlower());
    }
}
