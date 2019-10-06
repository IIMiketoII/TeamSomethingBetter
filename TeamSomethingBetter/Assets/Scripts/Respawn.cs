using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 spawnPoint;
    public GameObject other1;
    public GameObject other2;

    private IEnumerator coroutine;

    public void Spawn()
    {
        coroutine = execute();
        StartCoroutine(coroutine);
    }

    private IEnumerator execute()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<leaderMovement>().frozen = true;
        yield return new WaitForSeconds(0.4f);
        transform.position = spawnPoint;
        other1.transform.position = spawnPoint;
        other2.transform.position = spawnPoint;
        GetComponent<leaderMovement>().frozen = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Checkpoint")
        {
            Debug.Log("wowzer");
            spawnPoint = col.transform.position;
        }
    }
}
