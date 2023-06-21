using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItem : MonoBehaviour
{
    
    public int coinsCollected;
    public TMP_Text numberOfCoins;
    public TMP_Text numberOfFinalCoins;

    private void OnTriggerEnter(Collider Col)
    {
        Debug.Log("collected");
        coinsCollected = coinsCollected + 1;
        Col.gameObject.SetActive(false);


    }

    private void Update()
    {
        numberOfCoins.text = coinsCollected.ToString();
        numberOfFinalCoins.text = coinsCollected.ToString();
    }
}
