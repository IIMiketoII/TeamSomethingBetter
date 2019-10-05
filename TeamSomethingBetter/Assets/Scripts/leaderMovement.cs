using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class leaderMovement : MonoBehaviour
{
    public float speed;

    public bool isLeader = true;
    public bool isGrounded;
    bool wKeyDown = false;
    bool spaceKeyDown = false;
    Rigidbody rb;
    Vector3 vel;

    // Start is called before the first frame update
    void Start()
    {
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

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == ("ground"))
        {
            isGrounded = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            wKeyDown = true;
        }
        else
        {
            wKeyDown = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceKeyDown = true;
        }
        else
        {
            spaceKeyDown = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vel = rb.velocity;
        if (isLeader)
        {
            // Move right
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(transform.right * Time.deltaTime * speed, ForceMode.VelocityChange);
            }
            // Move left
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(transform.right * Time.deltaTime * -speed, ForceMode.VelocityChange);
            }

            // Jump
            if ((wKeyDown || spaceKeyDown) && isGrounded)
            {
                rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
                isGrounded = false;
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
