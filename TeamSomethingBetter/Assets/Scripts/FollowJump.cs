using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowJump : MonoBehaviour
{
    public leaderMovement movement;
    public GameObject other1;
    public GameObject other2;
    public float jumpHeight;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (!movement.isLeader)
        {
            Debug.Log("butt");
            if (other1.GetComponent<leaderMovement>().isLeader && other1.GetComponent<leaderMovement>().hasJumped)
            {
                Debug.Log("duck");
                rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            }
            if (other2.GetComponent<leaderMovement>().isLeader && other2.GetComponent<leaderMovement>().hasJumped)
            {
                Debug.Log("dumdum");
                rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            }
        }
    }
}
