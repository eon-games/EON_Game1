using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    public Transform Player;
    private float moveSpeed = 2f;
    float maxDist = 8;
    float minDist = 2;

    private int waypointIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        //Move();
        ChasePlayer();
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

    private void Move()
    {
        if(waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed*Time.deltaTime);

            if(transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
    private void ChasePlayer()
    {
        float distance = Vector3.Distance (Player.transform.position, transform.position);
        if(distance >= minDist )
        {
            transform.position = Vector3.MoveTowards(transform.position,
            Player.transform.position,
            moveSpeed*Time.deltaTime);
        }
        
    }
}
