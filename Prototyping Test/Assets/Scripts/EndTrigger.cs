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
       /* if (other.tag == "Beanbag")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.tag == "Harvard")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } */

        level.gameObject.SetActive(false);
        endMenu.gameObject.SetActive(true);
    }

    private void Update()
    {
        {
            if (Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.LeftShift))
            {
                level.gameObject.SetActive(false);
                endMenu.gameObject.SetActive(true);
                // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }


    }




}

    
