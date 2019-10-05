using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchPlayer : MonoBehaviour
    
    // Red: 1
    // Blue: 2
    // Green: 3

{
    /*
    public GameObject red;
    public GameObject blue;
    public GameObject green;

    public float keyDelay = 5f;
    public float timePassed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("slimeRed");
        blue = GameObject.Find("slimeBlue");
        green = GameObject.Find("slimeGreen");
        red.GetComponent<leaderMovement>().isLeader = true;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (Input.GetButtonUp("switch") && timePassed >= keyDelay)
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

            timePassed = 0f;
        }
    }
    */
}
