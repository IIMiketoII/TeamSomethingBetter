using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class leaderMovement : MonoBehaviour
{
    public float speed;
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
    void Update()
    {
        // Move right
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime,0,0);
        }
        // Move left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        // Jump
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
