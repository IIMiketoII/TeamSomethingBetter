using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class LeaderMovement : MonoBehaviour
{
    public float speed;

    public bool isLeader = true;
    public bool isGrounded;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = 6;
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == ("ground") && isGrounded == false)
        {
            isGrounded = true;
        }

        // ignore friends
        if (col.gameObject.tag == "friend")
        {
            Physics.IgnoreCollision(col.transform.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isLeader)
        {
            // Move right
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(speed, 0, 0, ForceMode.VelocityChange);
                //transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            else
            {
                rb.AddForce(-rb.GetPointVelocity(transform.position));
            }
            // Move left
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(-speed, 0, 0, ForceMode.VelocityChange);
                //transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            else
            {
                rb.AddForce(-rb.GetPointVelocity(transform.position));
            }
            // Jump
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && isGrounded)
            {
                rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
                isGrounded = false;
            }
        }
    }
}
