using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envInteract : MonoBehaviour
{
    public GameObject lever, button;
    public GameObject wallDestroy, wallMove;

    // Update is called once per frame
    void Update()
    {
        /*
        if (activated)
        {
            wallMove.SetActive(false);
        }
        else
        {
            wallMove.SetActive(true);
        }
        /*
        if (red.GetComponent<leaderMovement>().isLeader == true)
        {
            col = red.GetComponent<Collider>();
        }
        if (green.GetComponent<leaderMovement>().isLeader == true)
        {
            col = green.GetComponent<Collider>();
        }
        if (blue.GetComponent<leaderMovement>().isLeader == true)
        {
            col = blue.GetComponent<Collider>();
        }
        OnTriggerStay(col);
        */
    }

    void OnTriggerExit (Collider col)
    {
        if (col.gameObject.GetComponent<leaderMovement>().isLeader)
        {
            Debug.Log("plop");
            wallMove.SetActive(true);
        }
        
    }

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.GetComponent<leaderMovement>().isLeader)
        {
            Debug.Log("asoidnkmlaksd");
            wallMove.SetActive(false);
        }
    }
}
