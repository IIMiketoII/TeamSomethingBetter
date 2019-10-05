using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{
    public Rigidbody player;

    void OnCollisionStay(Collision thing)
    {
        if (thing.collider.material.name == "Climb Material" && (Input.GetKey("d") || Input.GetKey("a")))
        {
            player.AddForce(transform.up * 20);
        }
    }
}
