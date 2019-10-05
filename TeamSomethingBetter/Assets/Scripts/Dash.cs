﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float dashDistance = 10f;
    public float dashSpeed = 40f;
    public Rigidbody player;

    public LeaderMovement movement;

    bool facingRight = true;
    bool aKey = false;
    bool dKey = false;
    bool kKeyDown = false;

    bool dashing = false;
    Vector3 startPoint;

    void Update()
    {
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
        if (aKey)
        {
            facingRight = false;
        }
        if (dKey)
        {
            facingRight = true;
        }

        
        if (kKeyDown && movement.isGrounded)
        {
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
            if (Mathf.Abs(transform.position.x - startPoint.x) > dashDistance)
            {
                player.AddForce(-player.GetPointVelocity(transform.position), ForceMode.VelocityChange);
                dashing = false;
            }
        }
    }
}
