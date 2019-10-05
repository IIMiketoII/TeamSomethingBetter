using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sampleAgent : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public GameObject leader;
    public GameObject red;
    public GameObject green;
    public GameObject blue;

    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("slimeRed");
        green = GameObject.Find("slimeGreen");
        blue = GameObject.Find("slimeBlue");

    }

    // Update is called once per frame
    void Update()
    {

        /*
        Vector3 nextPos = leader.transform.position;
        Vector3 correctPos = new Vector3(nextPos.x,nextPos.y,0);
        transform.position = correctPos;
        */

        if (red.GetComponent<leaderMovement>().isLeader == true)
        {
            target = GameObject.Find("slimeRed").GetComponent<Transform>();
            target2 = GameObject.Find("slimeBlue").GetComponent<Transform>();
            if (green.GetComponent<NavMeshAgent>().enabled == true && blue.GetComponent<NavMeshAgent>().enabled == true)
            {
                blue.GetComponent<NavMeshAgent>().SetDestination(target.position);
                green.GetComponent<NavMeshAgent>().SetDestination(target2.position);
            }
        }
        if (blue.GetComponent<leaderMovement>().isLeader == true)
        {
            target = GameObject.Find("slimeBlue").GetComponent<Transform>();
            target2 = GameObject.Find("slimeGreen").GetComponent<Transform>();
            if (red.GetComponent<NavMeshAgent>().enabled == true && green.GetComponent<NavMeshAgent>().enabled == true)
            {
                red.GetComponent<NavMeshAgent>().SetDestination(target2.position);
                green.GetComponent<NavMeshAgent>().SetDestination(target.position);
            }
        }
        if (green.GetComponent<leaderMovement>().isLeader == true)
        {
            target = GameObject.Find("slimeGreen").GetComponent<Transform>();
            target2 = GameObject.Find("slimeRed").GetComponent<Transform>();
            if (red.GetComponent<NavMeshAgent>().enabled == true && blue.GetComponent<NavMeshAgent>().enabled == true)
            {
                red.GetComponent<NavMeshAgent>().SetDestination(target.position);
                blue.GetComponent<NavMeshAgent>().SetDestination(target2.position);
            }
        }


        //agent.SetDestination(target.position);
    }
}
