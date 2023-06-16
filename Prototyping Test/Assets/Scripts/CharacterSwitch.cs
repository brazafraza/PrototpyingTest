using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
//using UnityEngine.UIElements;

public class CharacterSwitch : MonoBehaviour
{
    public KeyCode Harvard = KeyCode.Alpha1;
    public KeyCode Beanbag = KeyCode.Alpha2;

    public GameObject beanbagCamGameObj;
    public GameObject beanbagGameObj;
    public GameObject beanbagCam;


    public GameObject harvardCamGamObj;
    public GameObject harvardGameObj;
    public GameObject harvardCam;

    public GameObject harvardIcon;
    public GameObject beanbagIcon;

    public bool isImgOn;
    public Image img;



    void Start()
    {
        img.enabled = true;
        isImgOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Harvard))
        {
            Debug.Log("switch to harvard");
            //disabling camera, movement script and camera script on beanbag
            beanbagCamGameObj.GetComponent<MoveCamera>().enabled = false;
            beanbagGameObj.GetComponent<PlayerMovement>().enabled = false;
            beanbagCam.GetComponent<Camera>().enabled = false;

            //enabling camera, movement script and camera script on harvard
            harvardCamGamObj.GetComponent<MoveCamera>().enabled = true;
            harvardGameObj.GetComponent<PlayerMovement>().enabled = true;
            harvardCam.GetComponent<Camera>().enabled = true;

            //display harvard player icon
            if (isImgOn == true)
            {
                img.enabled = false;
                isImgOn = false;
            }
        }

        if (Input.GetKey(Beanbag))
        {
            Debug.Log("switch to beanbag");
            //disabling camera, movement script and camera script on beanbag
            beanbagCamGameObj.GetComponent<MoveCamera>().enabled = true;
            beanbagGameObj.GetComponent<PlayerMovement>().enabled = true;
            beanbagCam.GetComponent<Camera>().enabled = true;

            //enabling camera, movement script and camera script on harvard
            harvardCamGamObj.GetComponent<MoveCamera>().enabled = false;
            harvardGameObj.GetComponent<PlayerMovement>().enabled = false;
            harvardCam.GetComponent<Camera>().enabled = false;

            //display beanbag player icon
            if (isImgOn == false)
            {
                img.enabled = true;
                isImgOn = true;
            }
        }

       


    }
}
