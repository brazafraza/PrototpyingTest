using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    // door to be destroy
    public GameObject dDoor;

    public bool onPlate;
    
    void Start()
    {
        //plate inactive
        onPlate = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if beanbag steps on plate it becomes active
        if (other.tag == "Beanbag")
        {
            onPlate = true;
        }

   
    }
    void Update()
    {
        //when plate is active destroy door
        if (onPlate)
        {
            Object.Destroy(dDoor);
        }

    }

    


}
