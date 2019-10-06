using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 spawnPoint;

    public void Spawn()
    {
        transform.position = spawnPoint;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "checkpoint")
        {
            spawnPoint = col.transform.position;
        }
    }
}
