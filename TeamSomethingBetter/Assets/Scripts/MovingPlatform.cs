using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Platform;

    public Transform pointA;
    public Transform pointB;

    public float speed;

    public bool toggle;

    public GameObject red;
    public GameObject blue;
    public GameObject green;

 

     void Start()
    {
        red = GameObject.Find("redSlime");
        blue = GameObject.Find("blueSlime");
        green = GameObject.Find("greenSlime");
    }

    // Update is called once per frame
    void Update()
    {
        if(toggle == false)
        {
            Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, pointA.position, speed);
        }
        if (toggle == true)
        {
            Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, pointB.position, speed);
        }

        if(Platform.transform.position == pointA.position)
        {
            toggle = true;
        }
        if (Platform.transform.position == pointB.position)
        {
            toggle = false;
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == red)
        {
            red.transform.parent = transform;
        }
        if (other.gameObject == blue)
        {
            blue.transform.parent = transform;
        }
        if (green.gameObject == green)
        {
            green.transform.parent = transform;
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.gameObject == red)
        {
            red.transform.parent = null;
        }
        if (other.gameObject == blue)
        {
            blue.transform.parent = null;
        }
        if (green.gameObject == green)
        {
            green.transform.parent = null;
        }
    }

}
