using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
 
    //skip to next scene
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //back to previous scene
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //close application
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    //back 
    public void ReturnMenu()
    {
        Back();
    }

   private void Update()
    {

        //unlocking the cursor at mouse
        Cursor.lockState = CursorLockMode.None;
        //making cursor visble again
        Cursor.visible = true;

    } 

    
   



}
