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
        key1 = false;
        key2 = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (key1 && key2)
        {
            Object.Destroy(finalDoor);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Beanbag") 
        {
            key1 = true;
        }

        if (other.tag == "Harvard")
        {
            key2 = true;
        }
    }


}
