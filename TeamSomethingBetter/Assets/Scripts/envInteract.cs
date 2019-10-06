using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envInteract : MonoBehaviour
{
    public GameObject red, green, blue;
    public GameObject lever, button;
    public GameObject wallDestroy, wallMove;
    public Collider col;

    bool activated = false;

    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("slimeRed");
        green = GameObject.Find("slimeGreen");
        blue = GameObject.Find("slimeBlue");

        lever = GameObject.Find("lever");
        button = GameObject.Find("button");

        wallDestroy = GameObject.Find("wallDestroy");
        wallMove = GameObject.Find("wallMove");
        wallMove.GetComponent<Renderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
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
    }

    /*void OnTriggerExit (Collider other)
    {
        if (activated == false)
        {
            activated = true;
            Destroy(wallDestroy);
            lever.transform.Rotate(0,0,-30,Space.Self);
        }
        
    }*/

    void OnTriggerStay (Collider other)
    {
        if (wallMove.GetComponent<Renderer>().enabled == true)
        {
            wallMove.GetComponent<Renderer>().enabled = false;
        }
        /*else
        {
            wallMove.GetComponent<Renderer>().enabled = true;
        }*/
    }
}
