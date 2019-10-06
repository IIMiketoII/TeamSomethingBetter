using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTip : MonoBehaviour
{
    public Canvas tip;

    void Start()
    {
        tip.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<leaderMovement>().isLeader)
        {
            Debug.Log("oogieboogie");
            tip.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        tip.gameObject.SetActive(false);
    }
}
