using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    //reference to cam pos
    public Transform cameraPosition;
    
    private void Update()
    {
        
        transform.position = cameraPosition.position; 
    }
}
