using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUIControl : MonoBehaviour
{
    public GameObject greenSelected, redSelected, blueSelected;
    public GameObject greenUnselected, redUnselected, blueUnselected;
    public GameObject timeBar;

    public GameObject red, green, blue;
    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        greenSelected = GameObject.Find("greenSelect");
        redSelected = GameObject.Find("redSelect");
        blueSelected = GameObject.Find("blueSelect");
        greenUnselected = GameObject.Find("greenUnselected");
        redUnselected = GameObject.Find("redUnselected");
        blueUnselected = GameObject.Find("blueUnselected");

        redSelected.GetComponent<Image>().enabled = false;
        greenSelected.GetComponent<Image>().enabled = false;
        blueSelected.GetComponent<Image>().enabled = false;
        greenUnselected.GetComponent<Image>().enabled = false;
        blueUnselected.GetComponent<Image>().enabled = false;
        redUnselected.GetComponent<Image>().enabled = false;

        red = GameObject.Find("slimeRed");
        green = GameObject.Find("slimeGreen");
        blue = GameObject.Find("slimeBlue");
        manager = GameObject.Find("GameManager");

        timeBar = GameObject.Find("timeBar");
        timeBar.GetComponent<Image>().fillAmount = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // who is leader
        // red is leader: red selected, green and blue unselect
        if (red.GetComponent<leaderMovement>().isLeader == true)
        {
            redSelected.GetComponent<Image>().enabled = true;
            greenSelected.GetComponent<Image>().enabled = false;
            blueSelected.GetComponent<Image>().enabled = false;
            greenUnselected.GetComponent<Image>().enabled = true;
            blueUnselected.GetComponent<Image>().enabled = true;
            redUnselected.GetComponent<Image>().enabled = false;
        }
        // green is leader: green selected, red and blue unselect
        if (green.GetComponent<leaderMovement>().isLeader == true)
        {
            redSelected.GetComponent<Image>().enabled = false;
            blueSelected.GetComponent<Image>().enabled = false;
            greenSelected.GetComponent<Image>().enabled = true;
            redUnselected.GetComponent<Image>().enabled = true;
            blueUnselected.GetComponent<Image>().enabled = true;
            greenUnselected.GetComponent<Image>().enabled = false;
        }
        // blue is leader: blue selected, red and green unselect
        if (blue.GetComponent<leaderMovement>().isLeader == true)
        {
            blueSelected.GetComponent<Image>().enabled = true;
            greenSelected.GetComponent<Image>().enabled = false;
            redSelected.GetComponent<Image>().enabled = false;
            redUnselected.GetComponent<Image>().enabled = true;
            greenUnselected.GetComponent<Image>().enabled = true;
            blueUnselected.GetComponent<Image>().enabled = false;
        }

        // timeBar
        if (manager.GetComponent<GameManager>().SlowDownAmount > 0)
        {
            //timeBar.GetComponent<Image>().fillAmount = manager.GetComponent<GameManager>().SlowDownAmount;
        }
    }
}
