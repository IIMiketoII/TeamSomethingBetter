using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]

public class leaderMovement : MonoBehaviour
{
    public float speed;
    public float jumpHeight;

    public bool isLeader;
    public bool isGrounded;
    bool wKeyDown = false;
    bool spaceKeyDown = false;
    Rigidbody rb;
    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == ("ground") && isGrounded == false)
        {
            isGrounded = true;
            Debug.Log("I have landed");
        }

        // ignore friends
        if (col.gameObject.tag == "friend")
        {
            Physics.IgnoreCollision(col.transform.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == ("ground"))
        {
            isGrounded = false;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (isLeader)
        {
            GetComponent<NavMeshAgent>().enabled = false;

            // Move right
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(transform.right * Time.deltaTime * speed, ForceMode.VelocityChange);
                //Debug.Log(transform.right * Time.deltaTime * speed);
            }
            // Move left
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(transform.right * Time.deltaTime * -speed, ForceMode.VelocityChange);
                //Debug.Log(transform.right * Time.deltaTime * -speed);
            }

            // Jump
            if (((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.Space))))
            {
                if (isGrounded == true)
                {
                    sound.Play();
                    rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
                    //WaitForSeconds(5);
                    blue.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
                    Debug.Log(blue.GetComponent<Transform>().position);
                    green.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
                    //eventManager.TriggerEvent("jump");
                    //Debug.Log("event jump");
                    Debug.Log("I HAVE JUMPED");
                    isGrounded = false;
                }
            }

            transform.position = new Vector3(transform.position.x, transform.position.y, 0.0f);

        }
        else
        {
           GetComponent<NavMeshAgent>().enabled = true;
           transform.position = new Vector3 (transform.position.x,transform.position.y,0.0f);
        }
    }
}
