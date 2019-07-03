using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2;
    public float jumpForce = 1;
    private bool isFalling = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = speed/10;
    }
    void FixedUpdate()
    {
       float moveHorizontal = Input.GetAxis("Horizontal");

       transform.position += transform.TransformDirection(moveHorizontal * speed, 0, 0);


        if (((Input.GetKey(KeyCode.UpArrow)||(Input.GetKey(KeyCode.W)))&&(isFalling == false)))
        {
            Vector3 jump = new Vector3(0, 10*jumpForce, 0);
            rb.AddForce(jump);
            isFalling = true;
        }
    }
    void OnCollisionStay()
    {
        isFalling = false;
    }
}
