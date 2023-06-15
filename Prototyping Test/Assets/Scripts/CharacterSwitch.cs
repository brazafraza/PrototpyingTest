using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    public KeyCode Harvard = KeyCode.Alpha1;
    public KeyCode Beanbag = KeyCode.Alpha2;

    public GameObject BeanbagCGO;
    public GameObject BeanbagGO;
    public GameObject BeanbagCam;

    public MoveCamera CGOScript;
    public PlayerMovement GOScript;

    public GameObject HarvardCGO;
    public GameObject HarvardGO;
    public GameObject HarvardCam;

    public MoveCamera HCGOScript;
    public PlayerMovement HGOScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Harvard))
        {
            Debug.Log("switch to harvard");
            //disabling camera, movement script and camera script on beanbag
            BeanbagCGO.GetComponent<MoveCamera>().enabled = false;
            BeanbagGO.GetComponent<PlayerMovement>().enabled = false;
            BeanbagCam.GetComponent<Camera>().enabled = false;

            //enabling camera, movement script and camera script on harvard
            HarvardCGO.GetComponent<MoveCamera>().enabled = true;
            HarvardGO.GetComponent<PlayerMovement>().enabled = true;
            HarvardCam.GetComponent<Camera>().enabled = true;

        }

        if (Input.GetKey(Beanbag))
        {
            Debug.Log("switch to beanbag");
        }


    }
}
