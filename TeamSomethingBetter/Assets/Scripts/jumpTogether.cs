using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpTogether : MonoBehaviour
{
    private UnityAction someListener;

    // Start is called before the first frame update
    void Awake()
    {
        someListener = new UnityAction(jump);
    }

    void OnEnable()
    {
        eventManager.StartListening("jump", someListener);
    }

    void OnDisable()
    {
        eventManager.StopListening("jump", someListener);
    }

    void jump ()
    {
        Debug.Log("JUMPED BABY");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
