using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShot : MonoBehaviour
{
    public float damage = 10;
    public float range = 100;
    public float timeBetweenShots = 3.0f;
    public float timePassed = 3;
    public LayerMask layer;
    RaycastHit hit;

    void Start()
    {
        timePassed = timeBetweenShots;    
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E)) {
            if (timePassed > timeBetweenShots) {
                if (Physics.Raycast(transform.position, transform.right, out hit, range, layer)) {
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.TakeDamage(damage);
                    }
                }
                Debug.DrawRay(transform.position, transform.right * range, Color.green);
                timePassed = 0;
            }
        }
        else
        {
            timePassed += Time.deltaTime;
        }
    }
}
