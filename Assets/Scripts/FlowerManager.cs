using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : MonoBehaviour
{
    [SerializeField]
    private Cherry _cherry;

    [SerializeField]
    BasketManager _basketManager;

    public FlowerManager(BasketManager basketManager, Cherry cherry)
    {
        _basketManager = basketManager;
        _cherry = cherry;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
