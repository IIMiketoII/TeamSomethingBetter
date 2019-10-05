using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject red;
    public GameObject blue;
    public GameObject green;

    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("slimeRed");
        blue = GameObject.Find("slimeBlue");
        green = GameObject.Find("slimeGreen");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("switch"))
        {
            // Red is leader
            if (red.GetComponent<leaderMovement>().isLeader == true)
            {
                // Switch to 2 as leader
                red.GetComponent<leaderMovement>().isLeader = false;
                blue.GetComponent<leaderMovement>().isLeader = true;
                Debug.Log("red to blue succ");
            }
            // Blue is leader
            else if (blue.GetComponent<leaderMovement>().isLeader == true)
            {
                // Switch to 3 as leader
                blue.GetComponent<leaderMovement>().isLeader = false;
                green.GetComponent<leaderMovement>().isLeader = true;
                Debug.Log("blue to green succ");
            }
            // Green is leader
            else if (green.GetComponent<leaderMovement>().isLeader == true)
            {
                // Switch to 1 as leader
                green.GetComponent<leaderMovement>().isLeader = false;
                red.GetComponent<leaderMovement>().isLeader = true;
                Debug.Log("green to red succ");
            }
        }
    }
}
