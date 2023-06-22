using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItem : MonoBehaviour
{
    //how much coins how much player has
    public int coinsCollected;

    //all 5 coin game objects
    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    public GameObject coin5;

    
    public TMP_Text numberOfCoins;
    public TMP_Text numberOfFinalCoins;

    private void OnTriggerEnter(Collider other)
    {
        //colect coin 1
        if (other.tag == "Col1")
        {
            Debug.Log("collected");
            coinsCollected = coinsCollected + 1;
            Object.Destroy(coin1);
        }

        //colect coin 2
        if (other.tag == "Col2")
        {
            Debug.Log("collected");
            coinsCollected = coinsCollected + 1;
            Object.Destroy(coin2);
        }

        //colect coin 3
        if (other.tag == "Col3")
        {
            Debug.Log("collected");
            coinsCollected = coinsCollected + 1;
            Object.Destroy(coin3);
        }

        //colect coin 4
        if (other.tag == "Col4")
        {
            Debug.Log("collected");
            coinsCollected = coinsCollected + 1;
            Object.Destroy(coin4);
        }

        //colect coin 5
        if (other.tag == "Col5")
        {
            Debug.Log("collected");
            coinsCollected = coinsCollected + 1;
            Object.Destroy(coin5);
        }



    }

    private void Update()
    {
        //displying number of  coins collected on screen
        numberOfCoins.text = coinsCollected.ToString();
        //displaying final number of coins on end screen
        numberOfFinalCoins.text = coinsCollected.ToString();
    }
}
