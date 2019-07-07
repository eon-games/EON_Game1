using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            //We wait 5 seconds before destroying the game object
            StartCoroutine(WaitCoroutine());
            Destroy(gameObject);
        }

    }
    IEnumerator WaitCoroutine()
    {    
        yield return new WaitForSeconds(5);
    }
}
