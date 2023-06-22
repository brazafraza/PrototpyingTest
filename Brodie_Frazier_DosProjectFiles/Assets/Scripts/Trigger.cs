using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject finalDoor;

    public bool key1;
    public bool key2;
    void Start()
    {
        //keys both false on start
        key1 = false;
        key2 = false;
    }

   
    void Update()
    {
        //if both keys are true, destroy the door
        if (key1 && key2)
        {
            Object.Destroy(finalDoor);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {

        //beanbag sets key 1 to true
        if(other.tag == "Beanbag") 
        {
            key1 = true;
        }
         //harvard sets key 2 to true
        if (other.tag == "Harvard")
        {
            key2 = true;
        }
    }


}
