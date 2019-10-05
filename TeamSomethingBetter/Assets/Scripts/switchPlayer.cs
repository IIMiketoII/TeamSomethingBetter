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

    public float keyDelay = 5f;
    public float timePassed = 0f;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("slimeRed");
        blue = GameObject.Find("slimeBlue");
        green = GameObject.Find("slimeGreen");
        red.GetComponent<leaderMovement>().isLeader = true;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame

}
