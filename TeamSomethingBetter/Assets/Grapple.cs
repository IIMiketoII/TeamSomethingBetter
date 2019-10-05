using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    public GameObject node;
    bool kKeyDown = false;
    bool grappled = false;
    float speed = 20f;
    RaycastHit hit;
    public Transform child; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
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
        if ((Vector3.Distance(transform.position, node.transform.position) < 50) && (kKeyDown) && (!grappled))
        {
            var rayDirection = node.transform.position - transform.position;
            if (Physics.Raycast(transform.position, rayDirection, out hit))
            {
                Debug.Log(hit.transform);
                if (hit.transform == node.transform)
                {
                    grappled = true;
                }
            }
        }
        else if (kKeyDown && grappled)
        {
            child.position = transform.position;
            grappled = false;
        }

        if (grappled)
        {
            float step = speed * Time.deltaTime;
            child.position = Vector3.MoveTowards(child.position, node.transform.position, step);
        }
    }
}
