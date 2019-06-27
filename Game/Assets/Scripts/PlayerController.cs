using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
       float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(0, 0, moveHorizontal);

        transform.position += transform.TransformDirection(movement);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 2, ForceMode.Impulse);

        }
    }
}
