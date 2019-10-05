using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{
    public float climbSpeed = 20f;
    public Rigidbody player;

    void OnCollision(Collision thing)
    {
        if (thing.gameObject.tag == "Climbable" && (Input.GetKey("d") || Input.GetKey("a")))
        {
            player.AddForce(-player.GetPointVelocity(transform.position));
        }
    }

    void OnCollisionStay(Collision thing)
    {
        if (thing.gameObject.tag == "Climbable" && (Input.GetKey("d") || Input.GetKey("a")))
        {
            player.AddForce(transform.up * climbSpeed);
        }
    }
}
