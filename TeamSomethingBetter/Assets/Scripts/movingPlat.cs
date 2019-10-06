using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlat : MonoBehaviour
{
    public GameObject pointLeft, pointRight;
    public GameObject platform;
    bool moveRight;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        pointLeft = GameObject.Find("pointLeft");
        pointRight = GameObject.Find("pointRight");
        platform = GameObject.Find("MovingPlatform");
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > pointRight.transform.position.x)
        {
            moveRight = false;
        }
        if (transform.position.x < pointLeft.transform.position.x)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.Translate(new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, 0));
        }
        else
        {
            transform.Translate(new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 0));
        }
        /*float step = speed * Time.deltaTime;
        if (atLeft)
        {
        //platform.transform.position += new Vector3(pointRight.transform.position.x * step, 0, 0);
        //platform.transform.position = Vector3.Lerp(platform.transform.position, pointRight.transform.position, step);
            platform.transform.Translate(new Vector3(pointRight.transform.position.x * (Time.deltaTime), platform.transform.position.y * step, platform.transform.position.z));
            Debug.Log("TRYING TO MOVE LEFT");
            Debug.Log(platform.transform.position);
            //atLeft = false;
            //atRight = true;
        }
        if (atRight)
        {
            platform.transform.Translate(new Vector3(pointLeft.transform.position.x * (Time.deltaTime), platform.transform.position.y * step, platform.transform.position.z));
            Debug.Log("TRYING TO MOVE RIGHT");
            //platform.transform.position = Vector3.MoveTowards(platform.transform.position, pointLeft.transform.position, step);
            //atLeft = true;
            //atRight = false;
        }
        OnCollisionEnter(platform.GetComponent<Collision>());*/

    }

    /*void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "pointRight")
        {
            atLeft = false;
            atRight = true;
        }
        if (col.gameObject.name == "pointLeft")
        {
            atLeft = true;
            atRight = false;
        }
    }*/
}
