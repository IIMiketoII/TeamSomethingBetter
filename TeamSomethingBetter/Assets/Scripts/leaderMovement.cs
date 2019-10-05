using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class leaderMovement : MonoBehaviour
{
    public float speed;

    public bool isLeader = true;
    public bool isGrounded;
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

    // Update is called once per frame
    void FixedUpdate()
    {
        vel = rb.velocity;
        if (isLeader)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                // Move right
                if (Input.GetKey(KeyCode.D))
                {
                    rb.AddForce(transform.right * Time.deltaTime * speed);
                    //transform.Translate(speed * Time.deltaTime, 0, 0);
                }
                // Move left
                if (Input.GetKey(KeyCode.A))
                {
                    rb.AddForce(transform.right * Time.deltaTime * -speed);
                    //transform.Translate(-speed * Time.deltaTime, 0, 0);
                }
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
