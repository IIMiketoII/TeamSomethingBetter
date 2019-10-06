using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class Dash : MonoBehaviour
{
    public float dashDistance = 10f;
    public float dashSpeed = 40f;
    public Rigidbody player;
    //public VisualEffect fire;
    public ParticleSystem fire;

    public leaderMovement movement;

    bool facingRight = true;
    bool aKey = false;
    bool dKey = false;
    bool kKeyDown = false;
    bool dashUsed = false;

    bool dashing = false;
    Vector3 startPoint;

    void Start()
    {
        fire.Pause();
    }

    void Update()
    {
        if (movement.isGrounded)
        {
            dashUsed = false;
        }

        if (Input.GetKey("a"))
        {
            aKey = true;
        }
        else
        {
            aKey = false;
        }
        if (Input.GetKey("d"))
        {
            dKey = true;
        }
        else
        {
            dKey = false;
        }
        if (Input.GetKeyDown("k"))
        {
            kKeyDown = true;
        }
        else
        {
            kKeyDown = false;
        }
    }

    void FixedUpdate()
    {
        player.useGravity = true;
        if (aKey)
        {
            facingRight = false;
        }
        if (dKey)
        {
            facingRight = true;
        }

        
        if (kKeyDown && transform.gameObject.GetComponent<leaderMovement>().isLeader && !dashUsed)
        {
            dashUsed = true;
            fire.transform.position = transform.position;
            if (facingRight)
            {
                startPoint = transform.position;
                player.AddForce(transform.right * dashSpeed, ForceMode.VelocityChange);
                dashing = true;
            }
            else if (!facingRight)
            {
                startPoint = transform.position;
                player.AddForce(-transform.right * dashSpeed, ForceMode.VelocityChange);
                dashing = true;
            }
        }

        if (dashing)
        {
            fire.Emit(100);
            player.useGravity = false;
            if (Mathf.Abs(transform.position.x - startPoint.x) > dashDistance)
            {
                player.AddForce(-player.GetPointVelocity(transform.position), ForceMode.VelocityChange);
                dashing = false;
            }
        }
    }
}
