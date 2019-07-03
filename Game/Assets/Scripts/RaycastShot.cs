using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShot : MonoBehaviour
{
    public float damage = 10;
    public float range = 100;
    public LayerMask layer;
    RaycastHit hit;

    void Update()
    {
        if (Input.GetKey(KeyCode.E)) {

            if (Physics.Raycast(transform.position, transform.forward, out hit, range, layer)){
            }
            Debug.DrawRay(transform.position, transform.right *range, Color.green);
        }
    }
}
