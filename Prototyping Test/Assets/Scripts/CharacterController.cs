using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterController : MonoBehaviour
{
    public float forwardSpeed = 0.1f;
    public float backwardSpeed = 0.08f;
    public float rotationalSpeed = 2f;
    public float jumpForce = 2f;
    public float groundCheckDistance;
    public bool isGrounded = true;



  



    //controls
    public KeyCode forwardsKey = KeyCode.W;
    public KeyCode backwardsKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode jumpKey = KeyCode.Space;



    //void OnTriggerEnter(Collider other)
    //{
    //
    //    //seeing if player is grounded
    //    if (other.tag == "Ground")
    //    {
    //        isGrounded = true;
    //        Debug.Log("grounded");
    //    }
    //}

    /* void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isGrounded = false;
            Debug.Log("not grounded");
        }
    } */


    void Update()
    {

        
       if(Physics.Raycast(transform.position, Vector3.down, groundCheckDistance))
        {
            Debug.Log("I am on da groun");
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }





        if (Input.GetKey(forwardsKey))
        {
            transform.position = transform.position + transform.forward * forwardSpeed;
        }

        if (Input.GetKey(backwardsKey))
        {
            transform.position = transform.position + transform.forward * -backwardSpeed;
        }

        if (Input.GetKey(leftKey))
        {
            transform.position = transform.position + transform.right * -forwardSpeed;
        }

        if (Input.GetKey(rightKey))
        {
            transform.position = transform.position + transform.right * forwardSpeed;
        }


        if (isGrounded)
        {
            if (Input.GetKey(jumpKey))
                GetComponent<Rigidbody>().AddForce(transform.up * jumpForce);
        
            
            
        }
    }
}
