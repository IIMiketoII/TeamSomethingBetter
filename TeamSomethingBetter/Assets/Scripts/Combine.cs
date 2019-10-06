using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour
{
    public GameObject other1;
    public GameObject other2;
    public GameObject beeg;
    public ParticleSystem poof;

    bool canCombine = true;

    public float combineSpeed = 5f;

    void Start()
    {
        poof.Pause();
    }

    void Morph()
    {
        if ((Vector3.Distance(transform.position, other1.transform.position) < 0.5) && (Vector3.Distance(transform.position, other2.transform.position) < 0.5))
        {
            beeg.SetActive(true);
            beeg.transform.position = transform.position;
            poof.transform.position = beeg.transform.position;
            poof.Emit(100);

            transform.gameObject.SetActive(false);
            other1.SetActive(false);
            other2.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (Vector3.Distance(transform.position, other1.transform.position) < 5) && (Vector3.Distance(transform.position, other2.transform.position) < 5) && GetComponent<leaderMovement>().isLeader && canCombine)
        {
            float step = combineSpeed * Time.deltaTime;
            other1.transform.position = Vector3.MoveTowards(other1.transform.position, transform.position, step);
            other2.transform.position = Vector3.MoveTowards(other2.transform.position, transform.position, step);
            Morph();
        }
    }
}
