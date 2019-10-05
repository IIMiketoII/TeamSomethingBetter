using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour
{
    public GameObject other1;
    public GameObject other2;

    public float combineSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && (Vector3.Distance(transform.position, other1.transform.position) < 5) && (Vector3.Distance(transform.position, other2.transform.position) < 5))
        {
            float step = combineSpeed * Time.deltaTime;
            other1.transform.position = Vector3.MoveTowards(other1.transform.position, transform.position, step);
            other2.transform.position = Vector3.MoveTowards(other2.transform.position, transform.position, step);
        }
    }
}
