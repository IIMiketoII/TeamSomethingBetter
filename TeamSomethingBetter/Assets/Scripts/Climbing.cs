using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{
    public float climbSpeed = 20f;
    public Rigidbody player;

    void OnCollisionStay(Collision thing)
    {
        if (thing.gameObject.tag == "Climbable")
        {
            if (Input.GetKey("d") || Input.GetKey("a"))
            {
                player.AddForce(0, climbSpeed, 0);
            }
        }
    }
}
