using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGrapple : MonoBehaviour
{
    public float distanceToGrapple;
    public Transform GrappleLocation;
    public GameObject GrappleNode;
    public GameObject Hook;
    public leaderMovement movement;

    public float hookTravelSpeed;
    public float playerTravelSpeed;
    public float pushSpeed;

    public static bool hooked;

    private float currentDistance;


    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<leaderMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<SphereCollider>().radius = distanceToGrapple;

        if(GrappleNode != null)
        {
            GrappleLocation = GrappleNode.transform;
        }

        if ((Input.GetKey("k")) && (GrappleNode != null) && movement.isLeader){
            //Hook.transform.position = Vector3.MoveTowards(Hook.transform.position, GrappleNode.transform.position, hookTravelSpeed);
            this.GetComponent<Rigidbody>().AddForce((GrappleNode.transform.position - transform.position).normalized * playerTravelSpeed);
            hooked = true;
            Debug.Log("I WANT TO GRAPPLE");
        }
        else
        {
            hooked = false;
        }
        if (hooked)
        {
            if (Vector3.Distance(GrappleNode.transform.position, transform.position) < distanceToGrapple)
            {
                this.GetComponent<Rigidbody>().AddForce((transform.position - GrappleNode.transform.position).normalized *  pushSpeed);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GrappleNode")
        {
            GrappleNode = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "GrappleNode")
        {
            GrappleNode = null;
        }
    }
}
