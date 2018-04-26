using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

    //public Rigidbody player;
    public float dashSpeed;
    private float dashTimeCounter;
    public float dashTime;
    private bool dashing = false;
    private CharacterController controller;
    private int direction;
    
    // Use this for initialization
	void Start () {
        dashTimeCounter = dashTime;
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(PlayerController.pointToLook);
            //controller.Move(new Vector3(PlayerController.pointToLook.x, transform.position.y, PlayerController.pointToLook.z));
            //player.AddForce(0, 0, 10, ForceMode.Impulse); //= new Vector3(10, transform.position.y, 0);
            //Debug.Log(player.velocity);
        }*/
        
        if (!dashing)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dashing = true;
                //Debug.Log("Great success!");
                if (Input.GetKey("w"))
                {
                    //Debug.Log("You r almost there");
                    direction = 1;
                }
                else if (Input.GetKey("a"))
                {
                    direction = 2;
                }
                else if (Input.GetKey("s"))
                {
                    direction = 3;
                }
                else if (Input.GetKey("d"))
                {
                    direction = 4;
                }
            }
        }
        else
        {
            if (dashTimeCounter <= 0)
            {
                dashing = false;
                dashTimeCounter = dashTime;
                //player.velocity = Vector3.zero;
                //Debug.Log("Done");
            }
            else
            {
                //Debug.Log("Even greater success!!");
                dashTimeCounter -= Time.deltaTime;
                //Vector3 hi = PlayerController.pointToLook;
                //player.velocity = new Vector3(PlayerController.pointToLook.x, transform.position.y, PlayerController.pointToLook.z) * dashSpeed;
                //player.velocity = new Vector3(dashSpeed, transform.position.y, 0);
                //controller.Move(new Vector3(dashSpeed, 0, 0));
                if(direction == 1)
                {
                    controller.Move(new Vector3(0, 0, dashSpeed));
                }
                else if (direction == 2)
                {
                    controller.Move(new Vector3(-dashSpeed, 0, 0));
                }
                else if (direction == 3)
                {
                    controller.Move(new Vector3(0, 0, -dashSpeed));
                }
                else if (direction == 4)
                {
                    controller.Move(new Vector3(dashSpeed, 0, 0));
                }
            }
        }
	}
}
