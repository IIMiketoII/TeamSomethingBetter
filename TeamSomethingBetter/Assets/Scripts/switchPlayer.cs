using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchPlayer : MonoBehaviour

    // Red: 1
    // Blue: 2
    // Green: 3

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
        if (Input.GetKey(KeyCode.J))
        {
            // Red is leader
            if ()
            {
                // Switch to 2 as leader
                red.isLeader = false;
                blue.isLeader = true;
            }
            // Blue is leader
            if (red.isLeader == true)
            {
                // Switch to 3 as leader
                blue.isLeader = false;
                green.isLeader = true;
            }
            // Green is leader
            if (red.isLeader == true)
            {
                // Switch to 1 as leader
                green.isLeader = false;
                red.isLeader = true;
            }
        }
    }
}
