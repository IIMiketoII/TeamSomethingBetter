using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverControls : MonoBehaviour
{
    public GameObject lever;
    public GameObject wallDestroy;

    bool activated = false;

    // Start is called before the first frame update
    void Start()
    {
        lever = GameObject.Find("lever");
        wallDestroy = GameObject.Find("wallDestroy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        if (activated == false)
        {
            activated = true;
            Destroy(wallDestroy);
            lever.transform.Rotate(0, 0, -30, Space.Self);
        }

    }
}
