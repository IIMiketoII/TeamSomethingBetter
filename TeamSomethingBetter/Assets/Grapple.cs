using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    public GameObject node;
    bool kKeyDown = false;

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
        if (Distance(transform.position, node.transform.position) < 50)
        {

    }
}
