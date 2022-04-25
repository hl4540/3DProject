using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 10f; //set a float variable for the moovement speed
    public float jumpHeight = 7f;
    public bool isGrounded;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")* Time.deltaTime * moveSpeed; //set a float variable to measure the horizontal input
        float vertical = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        
        transform.Translate(horizontal, 0, vertical); //calculate the new position for the object

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector3 (0, jumpHeight, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
 
    // void OnCollisionExit(Collision other)
    // {
    //     if (other.gameObject.tag == "Ground")
    //     {
    //         isGrounded = false;
    //     }
    // }
}
