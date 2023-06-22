using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject level;
    public GameObject endMenu;

    private void OnTriggerEnter(Collider other)
    {
       
        //when the final room is reached, set level in inactive and activate the end menu screen
        level.gameObject.SetActive(false);
        endMenu.gameObject.SetActive(true);
    }

    private void Update()
    {
        {
            //dev shortcut to skip to end of level
            if (Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.LeftShift))
            {
                level.gameObject.SetActive(false);
                endMenu.gameObject.SetActive(true);
                
            }
        }


    }




}

    
