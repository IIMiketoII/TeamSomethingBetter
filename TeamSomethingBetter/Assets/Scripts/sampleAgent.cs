using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sampleAgent : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nextPos = agent.nextPosition;
        Vector3 correctPos = new Vector3(nextPos.x,nextPos.y,0);
        transform.position = correctPos;

        agent.SetDestination(target.position);
    }
}
