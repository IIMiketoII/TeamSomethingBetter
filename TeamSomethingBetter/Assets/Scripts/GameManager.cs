using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject red;
    public GameObject blue;
    public GameObject green;

    public bool toggleTime;
    private float OGSpeed;

    public float SlowDownAmount;
    public float SlowDownAmountMax;

    public bool follow;

    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("slimeRed");
        blue = GameObject.Find("slimeBlue");
        green = GameObject.Find("slimeGreen");

        OGSpeed = blue.GetComponent<leaderMovement>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (toggleTime == true)
        {
            SlowDownAmount -= 1;
            Debug.Log(SlowDownAmount);
            if (SlowDownAmount <= 0)
            {
                SlowDownAmount = 0;
            }
        }
        else if(toggleTime == false)
        {
            SlowDownAmount = SlowDownAmount + 0.1f;
            Debug.Log(SlowDownAmount);
            if (SlowDownAmount >= SlowDownAmountMax)
            {
                SlowDownAmount = SlowDownAmountMax;
            }
        }
        if (SlowDownAmount <= 0)
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02F;
            toggleTime = false;
        }

        if (Input.GetKeyDown("c"))
        {
            if (follow)
            {
                follow = false;
            } else if (!follow)
            {
                follow = true;
            }
        }

        //Switch Character Functionality
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
        //Time Dialation
        if (Input.GetKeyDown("f"))
        {
            if (SlowDownAmount > 0)
            {
                if (toggleTime == false)
                {
                    //Time.timeScale = 0.2f;
                    DoSlowMotion();
                    toggleTime = true;
                }
                else if (toggleTime == true)
                {
                    Time.timeScale = 1;
                    Time.fixedDeltaTime = 0.02F;
                    toggleTime = false;
                }

            }



            /*
            if(toggleTime == false)
            {

                toggleTime = true;
                blue.GetComponent<leaderMovement>().speed = OGSpeed;
                red.GetComponent<leaderMovement>().speed = OGSpeed;
                green.GetComponent<leaderMovement>().speed = OGSpeed;
                Debug.Log("RegularTime");
            }
            else
            {
                toggleTime = false;
                blue.GetComponent<leaderMovement>().speed = OGSpeed/2;
                red.GetComponent<leaderMovement>().speed = OGSpeed/2;
                green.GetComponent<leaderMovement>().speed = OGSpeed/2;
                Debug.Log("SlowTime");
            }
            */
        }
        void DoSlowMotion()
        {
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = 0.02F * Time.timeScale;
        }
    }
}
