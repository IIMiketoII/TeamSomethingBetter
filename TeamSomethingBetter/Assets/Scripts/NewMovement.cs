using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public GameObject red;
    public GameObject green;
    public GameObject blue;

    public float DistanceToDetect;
    public float DistanceToForget;

    public float AISpeed;

    public GameObject redFollow;
    private GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("slimeRed");
        green = GameObject.Find("slimeGreen");
        blue = GameObject.Find("slimeBlue");

        redFollow = GameObject.Find("RedFollow");
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.follow == true)
        {
            //if red is the leader
            if (red.GetComponent<leaderMovement>().isLeader == true)
            {
                // Blue Follows Red
                if ((Vector3.Distance(red.transform.position, blue.transform.position) < DistanceToDetect) && (Vector3.Distance(red.transform.position, blue.transform.position) > DistanceToForget))
                {
                    //blue.transform.position = Vector3.MoveTowards(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    blue.GetComponent<Rigidbody>().AddForce((red.transform.position - blue.transform.position).normalized * AISpeed);
                    //transform.position = Vector3.Lerp(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    if (red.GetComponent<Transform>().position.y - 3 > blue.GetComponent<Transform>().position.y)
                    {
                        if (blue.GetComponent<leaderMovement>().isGrounded == true)
                        {
                            blue.GetComponent<Rigidbody>().AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
                        }
                    }
                }
                // green Follows blue
                if ((Vector3.Distance(blue.transform.position, green.transform.position) < DistanceToDetect) && (Vector3.Distance(blue.transform.position, green.transform.position) > DistanceToForget))
                {
                    //blue.transform.position = Vector3.MoveTowards(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    green.GetComponent<Rigidbody>().AddForce((blue.transform.position - green.transform.position).normalized * AISpeed);
                    //transform.position = Vector3.Lerp(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    if (blue.GetComponent<Transform>().position.y - 3 > green.GetComponent<Transform>().position.y)
                    {
                        if (green.GetComponent<leaderMovement>().isGrounded == true)
                        {
                            green.GetComponent<Rigidbody>().AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
                        }
                    }
                }
            }
            //if Blue is the leader
            if (blue.GetComponent<leaderMovement>().isLeader == true)
            {
                // green Follows blue
                if ((Vector3.Distance(blue.transform.position, green.transform.position) < DistanceToDetect) && (Vector3.Distance(blue.transform.position, green.transform.position) > DistanceToForget))
                {
                    //blue.transform.position = Vector3.MoveTowards(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    green.GetComponent<Rigidbody>().AddForce((blue.transform.position - green.transform.position).normalized * AISpeed);
                    //transform.position = Vector3.Lerp(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    if (blue.GetComponent<Transform>().position.y - 3 > green.GetComponent<Transform>().position.y)
                    {
                        if (green.GetComponent<leaderMovement>().isGrounded == true)
                        {
                            green.GetComponent<Rigidbody>().AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
                        }
                    }
                }
                // red Follows green
                if ((Vector3.Distance(green.transform.position, red.transform.position) < DistanceToDetect) && (Vector3.Distance(green.transform.position, red.transform.position) > DistanceToForget))
                {
                    //blue.transform.position = Vector3.MoveTowards(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    red.GetComponent<Rigidbody>().AddForce((green.transform.position - red.transform.position).normalized * AISpeed);
                    //transform.position = Vector3.Lerp(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    if (green.GetComponent<Transform>().position.y - 3 > red.GetComponent<Transform>().position.y)
                    {
                        Debug.Log("Red is higher");
                        if (red.GetComponent<leaderMovement>().isGrounded == true)
                        {
                            red.GetComponent<Rigidbody>().AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
                        }
                    }
                }
            }
            //if Blue is the leader
            if (green.GetComponent<leaderMovement>().isLeader == true)
            {
                // red Follows green
                if ((Vector3.Distance(green.transform.position, red.transform.position) < DistanceToDetect) && (Vector3.Distance(green.transform.position, red.transform.position) > DistanceToForget))
                {
                    //blue.transform.position = Vector3.MoveTowards(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    red.GetComponent<Rigidbody>().AddForce((green.transform.position - red.transform.position).normalized * AISpeed);
                    //transform.position = Vector3.Lerp(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    if (green.GetComponent<Transform>().position.y - 3 > red.GetComponent<Transform>().position.y)
                    {
                        Debug.Log("Red is higher");
                        if (red.GetComponent<leaderMovement>().isGrounded == true)
                        {
                            red.GetComponent<Rigidbody>().AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
                        }
                    }
                }
                // Blue Follows Red
                if ((Vector3.Distance(red.transform.position, blue.transform.position) < DistanceToDetect) && (Vector3.Distance(red.transform.position, blue.transform.position) > DistanceToForget))
                {
                    //blue.transform.position = Vector3.MoveTowards(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    blue.GetComponent<Rigidbody>().AddForce((red.transform.position - blue.transform.position).normalized * AISpeed);
                    //transform.position = Vector3.Lerp(blue.transform.position, red.transform.position, AISpeed * Time.deltaTime);
                    if (red.GetComponent<Transform>().position.y - 3 > blue.GetComponent<Transform>().position.y)
                    {
                        if (blue.GetComponent<leaderMovement>().isGrounded == true)
                        {
                            blue.GetComponent<Rigidbody>().AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
                        }
                    }
                }
            }
        }
    }
}
