using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float smooth = 0.125f;
    public Vector3 offset;

    public GameObject red, green, blue, beeg;

    void Start()
    {
        red = GameObject.Find("slimeRed");
        green = GameObject.Find("slimeGreen");
        blue = GameObject.Find("slimeBlue");
        //beeg = GameObject.Find("beeg");
    }

    void FixedUpdate ()
    {
        if (beeg.activeSelf)
        {
            target = beeg.GetComponent<Transform>();
        }
        else
        {
            // follow red if leader
            if (red.GetComponent<leaderMovement>().isLeader == true)
            {
                target = red.GetComponent<Transform>();
            }
            if (green.GetComponent<leaderMovement>().isLeader == true)
            {
                target = green.GetComponent<Transform>();
            }
            if (blue.GetComponent<leaderMovement>().isLeader == true)
            {
                target = blue.GetComponent<Transform>();
            }
        }

        Vector3 desiredPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smooth);
        transform.position = smoothPos;
    }
}
