using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BasketManager : MonoBehaviour
{
    private float discount;
    private float kdv;
    internal float pieceCherry;
    internal float priceCherry;
    internal float pieceRose;
    internal float priceRose;
    internal float pieceDiasy;
    internal float priceDiasy;
    public float totalPrice;
    [SerializeField]
    internal TextMeshProUGUI cherryText;
    [SerializeField]
    internal TextMeshProUGUI roseText;
    [SerializeField]
    internal TextMeshProUGUI daisyText;
    [SerializeField]
    internal TextMeshProUGUI totalPriceText;
    
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI cherryText = GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI roseText = GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI daisyText = GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI totalPriceText = GetComponent<TextMeshProUGUI>();
        pieceCherry = 0;
        pieceRose= 0;
        pieceDiasy = 0;
        totalPrice = 0;
    }

    // Update is called once per frame
    void Update()
    {
        totalPriceText.text = totalPrice.ToString() + "  Tl";
    }

    public void AddBasket(GameObject flower)
    {
        GameObject newFlower = flower;
        Category(newFlower);
    }
    private void Category(GameObject flowers)
    {
        if (flowers.name == "Cherry")
        {
            pieceCherry++;
            priceCherry = pieceCherry * flowers.GetComponent<Cherry>().Price;
            totalPrice += priceCherry * pieceCherry;
            BasketUpdate();
            Destroy(flowers);
        }
        if (flowers.name == "Rose")
        {
            pieceRose++;
            priceRose = pieceRose * flowers.GetComponent<Rose>().Price;
            totalPrice += priceRose * pieceRose;
            BasketUpdate();
            Destroy(flowers);
        }
        if (flowers.name == "Daisy")
        {
            pieceDiasy++;
            priceDiasy = pieceDiasy * flowers.GetComponent<Daisy>().Price;
            totalPrice += priceDiasy * pieceDiasy;
            BasketUpdate();
            Destroy(flowers);
        }
    }
    private void BasketUpdate()
    {
        if (pieceRose >= 1)
        {
            roseText.text = "Rose x" + pieceRose + "     " + priceRose + "Tl \n";
        }
        if (pieceCherry >= 1)
        {
            cherryText.text = "Cherry x" + pieceCherry + "     " + priceCherry + "Tl \n";
        }
        if (pieceDiasy >= 1)
        {
            daisyText.text = "Daisy x" + pieceDiasy + "     " + priceDiasy + "Tl \n";
        }
    }

    
}
