using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beegMovement : MonoBehaviour
{
    public float speed;
    public float jumpHeight;

    public bool isGrounded;
    Rigidbody rb;

    public GameObject green;
    public GameObject red;
    public GameObject blue;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        /*
        green = GameObject.Find("slimeGreen");
        red = GameObject.Find("slimeRed");
        blue = GameObject.Find("slimeBlue");
        */
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == ("ground") && isGrounded == false)
        {
            isGrounded = true;
            Debug.Log("I have landed");
        }

        if (col.gameObject.tag == ("breakable"))
        {
            Destroy(col.gameObject);
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == ("ground"))
        {
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
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
                rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
                Debug.Log("I HAVE JUMPED");
                isGrounded = false;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            green.SetActive(true);
            green.transform.position = transform.position;
            red.SetActive(true);
            red.transform.position = transform.position;
            blue.SetActive(true);
            blue.transform.position = transform.position;

            transform.gameObject.SetActive(false);
        }
    }
}
