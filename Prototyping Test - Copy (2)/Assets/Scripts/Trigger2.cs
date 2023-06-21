using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public GameObject dDoor;

    public bool onPlate;
    
    void Start()
    {
        onPlate = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (onPlate)
        {
            Object.Destroy(dDoor);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Beanbag")
        {
            onPlate = true;
        }

   
    }


}
