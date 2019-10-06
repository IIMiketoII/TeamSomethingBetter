using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public GameObject slimeAnimation;
    //public GameObject blueAnimation;
    //public GameObject greenAnimation;
    public Rigidbody rb;
    public float currentXPosition;

    private Animator animator;


    bool moving;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        currentXPosition = this.transform.position.x;
        animator = slimeAnimation.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()

    {

        if (this.GetComponent<leaderMovement>() != null)
        {

            if (this.GetComponent<leaderMovement>().isLeader == true)
            {
                if (Input.GetKey("a"))
                {
                    slimeAnimation.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    animator.SetBool("IsIdle", false);
                    animator.SetBool("IsRunning", true);
                    animator.SetBool("IsJumping", false);
                    moving = true;
                }
                if (Input.GetKey("d"))
                {
                    slimeAnimation.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
                    animator.SetBool("IsIdle", false);
                    animator.SetBool("IsRunning", true);
                    animator.SetBool("IsJumping", false);
                    moving = true;
                }
                if (!Input.GetKey("a") && !Input.GetKey("d"))
                {
                    moving = false;
                }
                if (moving == false && this.GetComponent<leaderMovement>().isGrounded == true)
                {
                    animator.SetBool("IsIdle", true);
                    animator.SetBool("IsRunning", false);
                    animator.SetBool("IsJumping", false);
                }
                if (this.GetComponent<leaderMovement>().isGrounded == false)
                {
                    animator.SetBool("IsIdle", false);
                    animator.SetBool("IsRunning", false);
                    animator.SetBool("IsJumping", true);
                }


            }

            if (this.GetComponent<leaderMovement>().isLeader == false)
            {
                if (this.transform.position.x > currentXPosition && this.GetComponent<leaderMovement>().isGrounded)
                {
                    slimeAnimation.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
                    currentXPosition = this.transform.position.x;
                    Debug.Log("Going RIght");
                    animator.SetBool("IsIdle", false);
                    animator.SetBool("IsRunning", true);
                    animator.SetBool("IsJumping", false);
                }
                if (this.transform.position.x < currentXPosition && this.GetComponent<leaderMovement>().isGrounded)
                {
                    slimeAnimation.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    currentXPosition = this.transform.position.x;
                    Debug.Log("Going Left");
                    animator.SetBool("IsIdle", false);
                    animator.SetBool("IsRunning", true);
                    animator.SetBool("IsJumping", false);
                }

                //Set Idle
                if (this.transform.position.x == 0 && this.GetComponent<leaderMovement>().isGrounded)
                {
                    animator.SetBool("IsIdle", true);
                    animator.SetBool("IsRunning", false);
                    animator.SetBool("IsJumping", false);
                }
                //Set Jumping
                if (this.GetComponent<leaderMovement>().isGrounded == false)
                {
                    animator.SetBool("IsIdle", false);
                    animator.SetBool("IsRunning", false);
                    animator.SetBool("IsJumping", true);
                }
            }
        }
            if(this.GetComponent<beegMovement>() != null){
            if (Input.GetKey("a"))
            {
                slimeAnimation.gameObject.transform.rotation = Quaternion.Euler(0, -95, 0);
                animator.SetBool("IsIdle", false);
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsJumping", false);
                moving = true;
            }
            if (Input.GetKey("d"))
            {
                slimeAnimation.gameObject.transform.rotation = Quaternion.Euler(0, 95, 0);
                animator.SetBool("IsIdle", false);
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsJumping", false);
                moving = true;
            }
            if (!Input.GetKey("a") && !Input.GetKey("d"))
            {
                moving = false;
            }
            if (moving == false && this.GetComponent<beegMovement>().isGrounded == true)
            {
                animator.SetBool("IsIdle", true);
                animator.SetBool("IsRunning", false);
                animator.SetBool("IsJumping", false);
            }
            if (this.GetComponent<beegMovement>().isGrounded == false)
            {
                animator.SetBool("IsIdle", false);
                animator.SetBool("IsRunning", false);
                animator.SetBool("IsJumping", true);
            }
            Debug.Log(moving);
        }
    }
}
