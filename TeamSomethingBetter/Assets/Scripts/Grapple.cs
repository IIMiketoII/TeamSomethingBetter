using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    public GameObject node;
    bool kKeyDown = false;
    bool grappling = false;
    float newScale;
    Vector3 center;
    bool isJoint = false;
    float speed = 20f;
    RaycastHit hit;
    public Transform child;
    public GameObject player;

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
        if ((Vector3.Distance(transform.position, node.transform.position) < 50) && (kKeyDown) && (!grappling))
        {
            var rayDirection = node.transform.position - transform.position;
            if (Physics.Raycast(transform.position, rayDirection, out hit))
            {
                if (hit.transform == node.transform)
                {
                    grappling = true;
                    /*
                    newScale = Vector3.Distance(child.position, node.transform.position);
                    child.localScale = new Vector3(child.localScale.x, child.localScale.y, newScale);
                    player.AddComponent<FixedJoint>();
                    player.GetComponent<FixedJoint>().connectedBody = child.gameObject.GetComponent<Rigidbody>();
                    grappling = true;
                    */
                }
            }
        }
        else if (kKeyDown && grappling)
        {
            child.position = transform.position;
            grappling = false;
        }

        if (grappling)
        {
            /*
            float step = speed * Time.deltaTime;
            child.LookAt(node.transform);
            center = Vector3.Lerp(player.transform.position, node.transform.position, 0.5F);
            child.position = center;
            */

        }
    }
}
